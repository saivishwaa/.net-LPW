using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AndroidDataViewer
{
    public partial class ContactsForm : Form
    {
        public ContactsForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string output = RunAdbCommand("shell content query --uri content://contacts/phones/");

            // Parse the output and add to DataGridView
            var table = new DataTable();
            table.Columns.Add("Name");
            table.Columns.Add("PhoneNumber");

            string[] lines = output.Split('\n');
            foreach (string line in lines)
            {
                if (line.Contains("name=") && line.Contains("number="))
                {
                    string name = ExtractValue(line, "name=");
                    string number = ExtractValue(line, "number=");
                    table.Rows.Add(name, number);
                }
            }

            dataGridView1.DataSource = table;
        }
        private string RunAdbCommand(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = $"/C adb {command}";
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            using (Process process = Process.Start(psi))
            {
                return process.StandardOutput.ReadToEnd();
            }
        }

        private string ExtractValue(string input, string key)
        {
            int index = input.IndexOf(key);
            if (index == -1) return "";
            int end = input.IndexOf(",", index);
            if (end == -1) end = input.Length;
            return input.Substring(index + key.Length, end - index - key.Length).Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string dbPath = "Data Source=androiddata.db"; // DB file will be in bin/Debug

            using (var conn = new SQLiteConnection(dbPath))
            {
                conn.Open();

                string createTable = @"
            CREATE TABLE IF NOT EXISTS ContactsTable (
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT,
                PhoneNumber TEXT,
                Email TEXT
            );";
                new SQLiteCommand(createTable, conn).ExecuteNonQuery();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string name = row.Cells["Name"].Value?.ToString() ?? "";
                    string number = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                    string email = ""; // If you have email data

                    var cmd = new SQLiteCommand("INSERT INTO ContactsTable (Name, PhoneNumber, Email) VALUES (@name, @number, @email)", conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@number", number);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Contacts saved to database.");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "ContactsReport.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        // Write headers
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            sw.Write(dataGridView1.Columns[i].HeaderText);
                            if (i < dataGridView1.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Write rows
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;

                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value?.ToString());
                                if (i < row.Cells.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Report exported successfully.");
                }
            }
        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {

        }
    }
}

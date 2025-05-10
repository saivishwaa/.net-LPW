using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidDataViewer
{
    public partial class b : Form
    {
        public b()
        {
            InitializeComponent();
        }

        // Load messages from the device via ADB
        private void btnLoadMessages_Click(object sender, EventArgs e)
        {
            string output = RunAdbCommand("shell content query --uri content://sms/");

            // Parse the output and add to DataGridView
            var table = new DataTable();
            table.Columns.Add("Sender");
            table.Columns.Add("Message");
            table.Columns.Add("Timestamp");

            string[] lines = output.Split('\n');
            foreach (string line in lines)
            {
                if (line.Contains("address=") && line.Contains("body="))
                {
                    string messageSender = ExtractValue(line, "address=");  // Renamed 'sender' to 'messageSender'
                    string message = ExtractValue(line, "body=");
                    string timestamp = ExtractValue(line, "date="); // This might need conversion

                    table.Rows.Add(messageSender, message, timestamp);
                }
            }

            dataGridViewMessages.DataSource = table;
        }

        // Run ADB command and return output
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

        // Extract key-value pair from the string
        private string ExtractValue(string input, string key)
        {
            int index = input.IndexOf(key);
            if (index == -1) return "";
            int end = input.IndexOf(",", index);
            if (end == -1) end = input.Length;
            return input.Substring(index + key.Length, end - index - key.Length).Trim();
        }

        // Save messages to SQLite database
        private void btnSaveMessages_Click(object sender, EventArgs e)
        {
            string dbPath = "Data Source=androiddata.db"; // DB file will be in bin/Debug

            using (var conn = new SQLiteConnection(dbPath))
            {
                conn.Open();

                // Create table for Messages
                string createTable = @"
                    CREATE TABLE IF NOT EXISTS MessagesTable (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Sender TEXT,
                        Message TEXT,
                        Timestamp TEXT
                    );";
                new SQLiteCommand(createTable, conn).ExecuteNonQuery();

                // Insert messages into database
                foreach (DataGridViewRow row in dataGridViewMessages.Rows)
                {
                    if (row.IsNewRow) continue;

                    string messageSender = row.Cells["Sender"].Value?.ToString() ?? "";
                    string message = row.Cells["Message"].Value?.ToString() ?? "";
                    string timestamp = row.Cells["Timestamp"].Value?.ToString() ?? "";

                    var cmd = new SQLiteCommand("INSERT INTO MessagesTable (Sender, Message, Timestamp) VALUES (@sender, @message, @timestamp)", conn);
                    cmd.Parameters.AddWithValue("@sender", messageSender);
                    cmd.Parameters.AddWithValue("@message", message);
                    cmd.Parameters.AddWithValue("@timestamp", timestamp);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Messages saved to database.");
            }
        }

        // Export messages to a CSV report
        private void btnReportMessages_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "MessagesReport.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        // Write headers
                        for (int i = 0; i < dataGridViewMessages.Columns.Count; i++)
                        {
                            sw.Write(dataGridViewMessages.Columns[i].HeaderText);
                            if (i < dataGridViewMessages.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Write rows
                        foreach (DataGridViewRow row in dataGridViewMessages.Rows)
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

        private void b_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AndroidDataViewer
{
    public partial class AppListForm : Form
    {
        public AppListForm()
        {
            InitializeComponent();
        }

        private void btnLoadInstalledApps_Click(object sender, EventArgs e)
        {
            string output = RunAdbCommand("shell pm list packages");

            var table = new DataTable();
            table.Columns.Add("Package Name");

            foreach (var line in output.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                // Output format: "package:com.example.app"
                if (line.StartsWith("package:"))
                {
                    table.Rows.Add(line.Replace("package:", "").Trim());
                }
            }

            dataGridViewInstalledApps.DataSource = table;
        }

        private void btnSaveInstalledApps_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "InstalledApps.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        foreach (DataGridViewRow row in dataGridViewInstalledApps.Rows)
                        {
                            if (row.Cells[0].Value != null)
                                sw.WriteLine(row.Cells[0].Value.ToString());
                        }
                    }

                    MessageBox.Show("Installed apps saved to CSV.");
                }
            }
        }

        private string RunAdbCommand(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = $"/C adb {command}";
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;  // Capture errors too
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            using (Process process = Process.Start(psi))
            {
                // Read both standard output and error output
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show($"Error executing ADB command: {error}");
                }

                return output;
            }
        }

        private void AppListForm_Load(object sender, EventArgs e)
        {

        }
    }
}

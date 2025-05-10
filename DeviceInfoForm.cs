using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AndroidDataViewer
{
    public partial class DeviceInfoForm : Form
    {
        public DeviceInfoForm()
        {
            InitializeComponent();
            // Hook up the Load event here (if it's not already in the Designer.cs)
            this.Load += new System.EventHandler(this.DeviceInfoForm_Load);
        }

        // Event handler for form load
        private void DeviceInfoForm_Load(object sender, EventArgs e)
        {
            // You can put any code you want to run when the form loads
            Console.WriteLine("Device Info Form Loaded");

            // Optionally, you can load the device info automatically when the form is loaded:
            btnLoadDeviceInfo.PerformClick();
        }

        private void btnLoadDeviceInfo_Click(object sender, EventArgs e)
        {
            // Get device info using ADB commands
            string model = RunAdbCommand("shell getprop ro.product.model");
            string androidVersion = RunAdbCommand("shell getprop ro.build.version.release");
            string batteryStatus = RunAdbCommand("shell dumpsys battery");
            string imei = RunAdbCommand("shell service call iphonesubinfo 1");
            string installedApps = RunAdbCommand("shell pm list packages");

            // Display device information in DataGridView
            var table = new DataTable();
            table.Columns.Add("Property");
            table.Columns.Add("Value");

            table.Rows.Add("Device Model", model.Trim());
            table.Rows.Add("Android Version", androidVersion.Trim());
            table.Rows.Add("Battery Status", batteryStatus.Trim());
            table.Rows.Add("IMEI", imei.Trim());
            table.Rows.Add("Installed Apps", installedApps.Trim());

            dataGridViewDeviceInfo.DataSource = table;
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

        private void btnSaveDeviceInfo_Click(object sender, EventArgs e)
        {
            // Save the device info to a file (CSV or DB)
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "DeviceInfoReport.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        // Write headers
                        foreach (DataGridViewColumn col in dataGridViewDeviceInfo.Columns)
                        {
                            sw.Write(col.HeaderText + ",");
                        }
                        sw.WriteLine();

                        // Write rows
                        foreach (DataGridViewRow row in dataGridViewDeviceInfo.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                sw.Write(cell.Value?.ToString() + ",");
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Device Info saved to CSV.");
                }
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Add report generation logic here (e.g., display in PDF, etc.)
            MessageBox.Show("Report generation logic not yet implemented.");
        }
    }
}

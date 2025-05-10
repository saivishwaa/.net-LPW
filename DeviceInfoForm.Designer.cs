namespace AndroidDataViewer
{
    partial class DeviceInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDeviceInfo = new System.Windows.Forms.DataGridView();
            this.btnLoadDeviceInfo = new System.Windows.Forms.Button();
            this.btnSaveDeviceInfo = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeviceInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDeviceInfo
            // 
            this.dataGridViewDeviceInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDeviceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeviceInfo.Location = new System.Drawing.Point(39, 89);
            this.dataGridViewDeviceInfo.Name = "dataGridViewDeviceInfo";
            this.dataGridViewDeviceInfo.Size = new System.Drawing.Size(1173, 349);
            this.dataGridViewDeviceInfo.TabIndex = 0;
            // 
            // btnLoadDeviceInfo
            // 
            this.btnLoadDeviceInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadDeviceInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadDeviceInfo.Location = new System.Drawing.Point(64, 12);
            this.btnLoadDeviceInfo.Name = "btnLoadDeviceInfo";
            this.btnLoadDeviceInfo.Size = new System.Drawing.Size(136, 61);
            this.btnLoadDeviceInfo.TabIndex = 3;
            this.btnLoadDeviceInfo.Text = "LOAD DATA";
            this.btnLoadDeviceInfo.UseVisualStyleBackColor = false;
            this.btnLoadDeviceInfo.Click += new System.EventHandler(this.btnLoadDeviceInfo_Click);
            // 
            // btnSaveDeviceInfo
            // 
            this.btnSaveDeviceInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveDeviceInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveDeviceInfo.Location = new System.Drawing.Point(490, 17);
            this.btnSaveDeviceInfo.Name = "btnSaveDeviceInfo";
            this.btnSaveDeviceInfo.Size = new System.Drawing.Size(201, 51);
            this.btnSaveDeviceInfo.TabIndex = 4;
            this.btnSaveDeviceInfo.Text = "SAVE TO DATABASE";
            this.btnSaveDeviceInfo.UseVisualStyleBackColor = false;
            this.btnSaveDeviceInfo.Click += new System.EventHandler(this.btnSaveDeviceInfo_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerateReport.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerateReport.Location = new System.Drawing.Point(918, 22);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(188, 51);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "GENERATE REPORT";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // DeviceInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1254, 450);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnSaveDeviceInfo);
            this.Controls.Add(this.btnLoadDeviceInfo);
            this.Controls.Add(this.dataGridViewDeviceInfo);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "DeviceInfoForm";
            this.Text = "DeviceInfoForm";
            this.Load += new System.EventHandler(this.DeviceInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeviceInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDeviceInfo;
        private System.Windows.Forms.Button btnLoadDeviceInfo;
        private System.Windows.Forms.Button btnSaveDeviceInfo;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}
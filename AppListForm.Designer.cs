namespace AndroidDataViewer
{
    partial class AppListForm
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
            this.dataGridViewInstalledApps = new System.Windows.Forms.DataGridView();
            this.btnLoadInstalledApps = new System.Windows.Forms.Button();
            this.btnSaveInstalledApps = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstalledApps)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInstalledApps
            // 
            this.dataGridViewInstalledApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstalledApps.Location = new System.Drawing.Point(40, 89);
            this.dataGridViewInstalledApps.Name = "dataGridViewInstalledApps";
            this.dataGridViewInstalledApps.Size = new System.Drawing.Size(1039, 349);
            this.dataGridViewInstalledApps.TabIndex = 0;
            // 
            // btnLoadInstalledApps
            // 
            this.btnLoadInstalledApps.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadInstalledApps.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadInstalledApps.Location = new System.Drawing.Point(129, 14);
            this.btnLoadInstalledApps.Name = "btnLoadInstalledApps";
            this.btnLoadInstalledApps.Size = new System.Drawing.Size(141, 48);
            this.btnLoadInstalledApps.TabIndex = 1;
            this.btnLoadInstalledApps.Text = "LOAD";
            this.btnLoadInstalledApps.UseVisualStyleBackColor = false;
            this.btnLoadInstalledApps.Click += new System.EventHandler(this.btnLoadInstalledApps_Click);
            // 
            // btnSaveInstalledApps
            // 
            this.btnSaveInstalledApps.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveInstalledApps.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveInstalledApps.Location = new System.Drawing.Point(624, 16);
            this.btnSaveInstalledApps.Name = "btnSaveInstalledApps";
            this.btnSaveInstalledApps.Size = new System.Drawing.Size(122, 46);
            this.btnSaveInstalledApps.TabIndex = 2;
            this.btnSaveInstalledApps.Text = "SAVE";
            this.btnSaveInstalledApps.UseVisualStyleBackColor = false;
            this.btnSaveInstalledApps.Click += new System.EventHandler(this.btnSaveInstalledApps_Click);
            // 
            // AppListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1141, 450);
            this.Controls.Add(this.btnSaveInstalledApps);
            this.Controls.Add(this.btnLoadInstalledApps);
            this.Controls.Add(this.dataGridViewInstalledApps);
            this.Name = "AppListForm";
            this.Text = "AppListForm";
            this.Load += new System.EventHandler(this.AppListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstalledApps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInstalledApps;
        private System.Windows.Forms.Button btnLoadInstalledApps;
        private System.Windows.Forms.Button btnSaveInstalledApps;
    }
}
namespace AndroidDataViewer
{
    partial class b
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
            this.dataGridViewMessages = new System.Windows.Forms.DataGridView();
            this.btnLoadMessages = new System.Windows.Forms.Button();
            this.btnSaveMessages = new System.Windows.Forms.Button();
            this.btnReportMessages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMessages
            // 
            this.dataGridViewMessages.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMessages.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewMessages.Name = "dataGridViewMessages";
            this.dataGridViewMessages.Size = new System.Drawing.Size(1168, 331);
            this.dataGridViewMessages.TabIndex = 5;
            // 
            // btnLoadMessages
            // 
            this.btnLoadMessages.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadMessages.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadMessages.Location = new System.Drawing.Point(62, 12);
            this.btnLoadMessages.Name = "btnLoadMessages";
            this.btnLoadMessages.Size = new System.Drawing.Size(139, 63);
            this.btnLoadMessages.TabIndex = 6;
            this.btnLoadMessages.Text = "LOAD MESSAGES";
            this.btnLoadMessages.UseVisualStyleBackColor = false;
            this.btnLoadMessages.Click += new System.EventHandler(this.btnLoadMessages_Click);
            // 
            // btnSaveMessages
            // 
            this.btnSaveMessages.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveMessages.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveMessages.Location = new System.Drawing.Point(476, 12);
            this.btnSaveMessages.Name = "btnSaveMessages";
            this.btnSaveMessages.Size = new System.Drawing.Size(225, 63);
            this.btnSaveMessages.TabIndex = 7;
            this.btnSaveMessages.Text = "SAVE TO DATABASE";
            this.btnSaveMessages.UseVisualStyleBackColor = false;
            this.btnSaveMessages.Click += new System.EventHandler(this.btnSaveMessages_Click);
            // 
            // btnReportMessages
            // 
            this.btnReportMessages.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReportMessages.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReportMessages.Location = new System.Drawing.Point(924, 12);
            this.btnReportMessages.Name = "btnReportMessages";
            this.btnReportMessages.Size = new System.Drawing.Size(227, 63);
            this.btnReportMessages.TabIndex = 8;
            this.btnReportMessages.Text = "GENERATE REPORT";
            this.btnReportMessages.UseVisualStyleBackColor = false;
            this.btnReportMessages.Click += new System.EventHandler(this.btnReportMessages_Click);
            // 
            // b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1211, 450);
            this.Controls.Add(this.btnReportMessages);
            this.Controls.Add(this.btnSaveMessages);
            this.Controls.Add(this.btnLoadMessages);
            this.Controls.Add(this.dataGridViewMessages);
            this.Name = "b";
            this.Text = "MessagesForm";
            this.Load += new System.EventHandler(this.b_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMessages;
        private System.Windows.Forms.Button btnLoadMessages;
        private System.Windows.Forms.Button btnSaveMessages;
        private System.Windows.Forms.Button btnReportMessages;
    }
}
namespace AndroidDataViewer
{
    partial class ContactsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1244, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoad.Location = new System.Drawing.Point(558, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(131, 66);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "LOAD DATA";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(39, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 66);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE TO DATABASE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReport.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReport.Location = new System.Drawing.Point(999, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(221, 66);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "GENERATE REPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1262, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ContactsForm";
            this.Text = "ContactsForm";
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReport;
    }
}
namespace project
{
    partial class FormInhoadonhientai
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvChitiethoadonhientai = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvChitiethoadonhientai
            // 
            this.rpvChitiethoadonhientai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvChitiethoadonhientai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            this.rpvChitiethoadonhientai.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvChitiethoadonhientai.LocalReport.ReportEmbeddedResource = "project.ReportHoadonhientai.rdlc";
            this.rpvChitiethoadonhientai.Location = new System.Drawing.Point(0, 0);
            this.rpvChitiethoadonhientai.Name = "rpvChitiethoadonhientai";
            this.rpvChitiethoadonhientai.ServerReport.BearerToken = null;
            this.rpvChitiethoadonhientai.Size = new System.Drawing.Size(711, 445);
            this.rpvChitiethoadonhientai.TabIndex = 0;
            // 
            // FormInhoadonhientai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 445);
            this.Controls.Add(this.rpvChitiethoadonhientai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInhoadonhientai";
            this.Text = "Chi Tiết Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInhoadonhientai_FormClosing);
            this.Load += new System.EventHandler(this.FormInhoadonhientai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvChitiethoadonhientai;
    }
}
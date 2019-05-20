namespace project
{
    partial class FormInnhanvien
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
            this.rpvNhanvien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vwHienthinhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vwHienthinhanvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvNhanvien
            // 
            reportDataSource1.Name = "NhanVien";
            reportDataSource1.Value = this.vwHienthinhanvienBindingSource;
            this.rpvNhanvien.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvNhanvien.LocalReport.ReportEmbeddedResource = "project.ReportNhanVien.rdlc";
            this.rpvNhanvien.Location = new System.Drawing.Point(0, 0);
            this.rpvNhanvien.Name = "rpvNhanvien";
            this.rpvNhanvien.ServerReport.BearerToken = null;
            this.rpvNhanvien.Size = new System.Drawing.Size(888, 509);
            this.rpvNhanvien.TabIndex = 0;
            // 
            // vwHienthinhanvienBindingSource
            // 
            this.vwHienthinhanvienBindingSource.DataSource = typeof(project.Entities.vw_Hienthinhanvien);
            // 
            // FormInnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 509);
            this.Controls.Add(this.rpvNhanvien);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInnhanvien";
            this.Text = "Danh Sách Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInnhanvien_FormClosing);
            this.Load += new System.EventHandler(this.FormInnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwHienthinhanvienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvNhanvien;
        private System.Windows.Forms.BindingSource vwHienthinhanvienBindingSource;
    }
}
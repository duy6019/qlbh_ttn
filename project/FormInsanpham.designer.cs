namespace project
{
    partial class FormInsanpham
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
            this.rpvSanpham = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vwHienthisanphamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vwHienthisanphamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvSanpham
            // 
            this.rpvSanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SanPham";
            reportDataSource1.Value = this.vwHienthisanphamBindingSource;
            this.rpvSanpham.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvSanpham.LocalReport.ReportEmbeddedResource = "project.ReportSanpham.rdlc";
            this.rpvSanpham.Location = new System.Drawing.Point(0, 0);
            this.rpvSanpham.Name = "rpvSanpham";
            this.rpvSanpham.ServerReport.BearerToken = null;
            this.rpvSanpham.Size = new System.Drawing.Size(930, 486);
            this.rpvSanpham.TabIndex = 0;
            this.rpvSanpham.Load += new System.EventHandler(this.rpvSanpham_Load);
            // 
            // vwHienthisanphamBindingSource
            // 
            this.vwHienthisanphamBindingSource.DataSource = typeof(project.Entities.vw_Hienthisanpham);
            // 
            // FormInsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 486);
            this.Controls.Add(this.rpvSanpham);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInsanpham";
            this.Text = "Danh Sách Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInsanpham_FormClosing);
            this.Load += new System.EventHandler(this.FormInsanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwHienthisanphamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvSanpham;
        private System.Windows.Forms.BindingSource vwHienthisanphamBindingSource;
    }
}
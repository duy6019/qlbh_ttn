namespace project
{
    partial class FormThongkehoadon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvThongkehoadon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpTungay = new System.Windows.Forms.DateTimePicker();
            this.btnThongke = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDenngay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvThongkehoadon
            // 
            this.rpvThongkehoadon.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "DataSet1";
            this.rpvThongkehoadon.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvThongkehoadon.LocalReport.ReportEmbeddedResource = "project.ReportThongkehoadon.rdlc";
            this.rpvThongkehoadon.Location = new System.Drawing.Point(0, 122);
            this.rpvThongkehoadon.Name = "rpvThongkehoadon";
            this.rpvThongkehoadon.ServerReport.BearerToken = null;
            this.rpvThongkehoadon.Size = new System.Drawing.Size(767, 297);
            this.rpvThongkehoadon.TabIndex = 0;
            // 
            // dtpTungay
            // 
            this.dtpTungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTungay.Location = new System.Drawing.Point(133, 78);
            this.dtpTungay.Name = "dtpTungay";
            this.dtpTungay.Size = new System.Drawing.Size(162, 22);
            this.dtpTungay.TabIndex = 1;
            // 
            // btnThongke
            // 
            this.btnThongke.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnThongke.Location = new System.Drawing.Point(532, 77);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(88, 23);
            this.btnThongke.TabIndex = 2;
            this.btnThongke.Text = "Thống Kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(107, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(151, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Hóa Đơn";
            // 
            // dtpDenngay
            // 
            this.dtpDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenngay.Location = new System.Drawing.Point(368, 78);
            this.dtpDenngay.Name = "dtpDenngay";
            this.dtpDenngay.Size = new System.Drawing.Size(158, 22);
            this.dtpDenngay.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đến Ngày";
            // 
            // FormThongkehoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 419);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDenngay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.dtpTungay);
            this.Controls.Add(this.rpvThongkehoadon);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormThongkehoadon";
            this.Text = "Thống Kê Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormThongkehoadon_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvThongkehoadon;
        private System.Windows.Forms.DateTimePicker dtpTungay;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDenngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
namespace project
{
    partial class FormNhanvienchuacotaikhoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ColumManhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumPhongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumChucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Nhân Viên Chưa Có Tài Khoản Đăng Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhanvien);
            this.groupBox2.Location = new System.Drawing.Point(14, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhân Viên";
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.AllowUserToAddRows = false;
            this.dgvNhanvien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumManhanvien,
            this.ColumTennhanvien,
            this.ColumPhongban,
            this.ColumChucvu});
            this.dgvNhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanvien.Location = new System.Drawing.Point(3, 18);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.ReadOnly = true;
            this.dgvNhanvien.Size = new System.Drawing.Size(503, 176);
            this.dgvNhanvien.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(538, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ColumManhanvien
            // 
            this.ColumManhanvien.HeaderText = "Mã Nhân Viên";
            this.ColumManhanvien.Name = "ColumManhanvien";
            this.ColumManhanvien.ReadOnly = true;
            // 
            // ColumTennhanvien
            // 
            this.ColumTennhanvien.HeaderText = "Tên Nhân Viên";
            this.ColumTennhanvien.Name = "ColumTennhanvien";
            this.ColumTennhanvien.ReadOnly = true;
            this.ColumTennhanvien.Width = 150;
            // 
            // ColumPhongban
            // 
            this.ColumPhongban.HeaderText = "Phòng Ban";
            this.ColumPhongban.Name = "ColumPhongban";
            this.ColumPhongban.ReadOnly = true;
            this.ColumPhongban.Width = 160;
            // 
            // ColumChucvu
            // 
            this.ColumChucvu.HeaderText = "Chức Vụ";
            this.ColumChucvu.Name = "ColumChucvu";
            this.ColumChucvu.ReadOnly = true;
            // 
            // FormNhanvienchuacotaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 322);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormNhanvienchuacotaikhoan";
            this.Text = "Người Dùng Mới";
            this.Load += new System.EventHandler(this.FormNhanvienchuacotaikhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumManhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumPhongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumChucvu;
    }
}
namespace project
{
    partial class FormQuanlynguoidung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanlynguoidung));
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDangnhap = new System.Windows.Forms.DataGridView();
            this.ColumManhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumQuyenhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumMatkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnManhanvien = new System.Windows.Forms.Button();
            this.txtQuyenhan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(463, 108);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(98, 22);
            this.txtMatkhau.TabIndex = 17;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(361, 108);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(96, 22);
            this.txtTendangnhap.TabIndex = 16;
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(139, 108);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(90, 22);
            this.txtManhanvien.TabIndex = 15;
            this.txtManhanvien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManhanvien_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên Đăng Nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mật Khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã Nhân Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(56, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 50);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(156, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quản Lý Người Dùng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(5, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 248);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công Cụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sửa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thêm";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.Location = new System.Drawing.Point(18, 163);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 49);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.Location = new System.Drawing.Point(18, 92);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 50);
            this.btnSua.TabIndex = 2;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Location = new System.Drawing.Point(18, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 50);
            this.btnThem.TabIndex = 0;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dgvDangnhap);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(109, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 202);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đăng Nhập";
            // 
            // dgvDangnhap
            // 
            this.dgvDangnhap.AllowUserToAddRows = false;
            this.dgvDangnhap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDangnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumManhanvien,
            this.ColumTennhanvien,
            this.ColumQuyenhan,
            this.ColumTendangnhap,
            this.ColumMatkhau});
            this.dgvDangnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDangnhap.Location = new System.Drawing.Point(3, 18);
            this.dgvDangnhap.Name = "dgvDangnhap";
            this.dgvDangnhap.Size = new System.Drawing.Size(468, 181);
            this.dgvDangnhap.TabIndex = 0;
            this.dgvDangnhap.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDangnhap_DataBindingComplete);
            // 
            // ColumManhanvien
            // 
            this.ColumManhanvien.DataPropertyName = "Manhanvien";
            this.ColumManhanvien.HeaderText = "Mã Nhân Viên";
            this.ColumManhanvien.Name = "ColumManhanvien";
            // 
            // ColumTennhanvien
            // 
            this.ColumTennhanvien.DataPropertyName = "Tennhanvien";
            this.ColumTennhanvien.HeaderText = "Tên Nhân Viên";
            this.ColumTennhanvien.Name = "ColumTennhanvien";
            this.ColumTennhanvien.Width = 120;
            // 
            // ColumQuyenhan
            // 
            this.ColumQuyenhan.DataPropertyName = "Quyenhan";
            this.ColumQuyenhan.HeaderText = "Quyền Hạn";
            this.ColumQuyenhan.Name = "ColumQuyenhan";
            // 
            // ColumTendangnhap
            // 
            this.ColumTendangnhap.DataPropertyName = "Tendangnhap";
            this.ColumTendangnhap.HeaderText = "Tên Đăng Nhập";
            this.ColumTendangnhap.Name = "ColumTendangnhap";
            // 
            // ColumMatkhau
            // 
            this.ColumMatkhau.DataPropertyName = "Matkhau";
            this.ColumMatkhau.HeaderText = "Mật Khẩu";
            this.ColumMatkhau.Name = "ColumMatkhau";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.PaleGreen;
            this.statusStrip1.Location = new System.Drawing.Point(0, 353);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(606, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnManhanvien
            // 
            this.btnManhanvien.BackColor = System.Drawing.Color.Ivory;
            this.btnManhanvien.Location = new System.Drawing.Point(226, 107);
            this.btnManhanvien.Name = "btnManhanvien";
            this.btnManhanvien.Size = new System.Drawing.Size(27, 23);
            this.btnManhanvien.TabIndex = 19;
            this.btnManhanvien.Text = "...";
            this.btnManhanvien.UseVisualStyleBackColor = false;
            this.btnManhanvien.Click += new System.EventHandler(this.btnManhanvien_Click);
            // 
            // txtQuyenhan
            // 
            this.txtQuyenhan.Location = new System.Drawing.Point(259, 108);
            this.txtQuyenhan.Name = "txtQuyenhan";
            this.txtQuyenhan.Size = new System.Drawing.Size(96, 22);
            this.txtQuyenhan.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Quyền Hạn";
            // 
            // FormQuanlynguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(606, 375);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuyenhan);
            this.Controls.Add(this.btnManhanvien);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTendangnhap);
            this.Controls.Add(this.txtManhanvien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormQuanlynguoidung";
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.FormQuanlynguoidung_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDangnhap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumManhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumQuyenhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumMatkhau;
        private System.Windows.Forms.Button btnManhanvien;
        private System.Windows.Forms.TextBox txtQuyenhan;
        private System.Windows.Forms.Label label8;
    }
}
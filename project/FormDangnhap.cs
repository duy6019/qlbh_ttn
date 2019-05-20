using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class FormDangnhap : Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }

        private void FormDangnhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangnhap;
        }
        string Ten, Matkhau;
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            Dangnhap();
        }

        private void Dangnhap()
        {
            string manhanvien = "?";
            string quyen = "";
            Ten = txttendangnhap.Text;
            Matkhau = txtmatkhau.Text;
            string sql = @"select * from DANGNHAP";
            DataTable dt = DataProvider.LoadCSDL(sql);
            int dem = dt.Rows.Count;
            bool dangnhap = false;
            for (int i = 0; i < dem; i++)
            {
                if (Ten == dt.Rows[i][2].ToString() && Matkhau == dt.Rows[i][3].ToString())
                {
                    manhanvien = dt.Rows[i][0].ToString();
                    quyen = dt.Rows[i][1].ToString();
                    dangnhap = true;
                    break;
                }
            }
            if (dangnhap == true)
            {
                FormTrangChu frm = new FormTrangChu();
                //this.Hide();
                //FormTrangChu.Manhanvien = manhanvien;
                //FormTrangChu.quyenhan = quyen;
                frm.Closed += (s, args) => this.Close();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Chính Xác", "Thất Bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

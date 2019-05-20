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
    public partial class FormHoadon : Form
    {
        public FormHoadon()
        {
            InitializeComponent();
        }

        private void FormHoadon_Load(object sender, EventArgs e)
        {
            Loadhoadon();
        }
        void Loadhoadon()
        {
            string sqlhoadon = @"select hd.Mahoadon,kh.Tenkhachhang,nv.Tennhanvien,hd.Ngayban
                                 from HOADON hd, KHACHHANG kh, NHANVIEN nv where hd.Makhachhang = kh.Makhachhang and hd.Manhanvien = nv.Manhanvien";
            DataTable dthoadon = DataProvider.LoadCSDL(sqlhoadon);
            dgvHoadon.DataSource = dthoadon;
            dgvHoadon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnChitiethoadon_Click(object sender, EventArgs e)
        {
            if (txtMahoadon.Text != "")
            {
                string sqlhoadon = @"select hd.Mahoadon from HOADON hd";
                DataTable dthoadon = DataProvider.LoadCSDL(sqlhoadon);
                int demhoadon = dthoadon.Rows.Count;
                int kiemtrahoadon = 0;
                for (int i = 0; i < demhoadon; i++)
                {
                    if (txtMahoadon.Text == dthoadon.Rows[i][0].ToString())
                    {
                        kiemtrahoadon = 1;
                        break;
                    }
                }
                if (kiemtrahoadon == 1)
                {
                    FormChitiethoadon frm = new FormChitiethoadon();
                    frm.Mahoadon = txtMahoadon.Text;
                    this.Hide();
                    frm.Closed += (s, args) => this.Close();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không Tìm Thấy Hóa Đơn Có Mã " + txtMahoadon.Text);
                }
            }
        }

        private void dgvHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoadon.Rows.Count > 0)
            {
                int chisodongdangchon = dgvHoadon.CurrentCell.RowIndex;
                txtMahoadon.Text = dgvHoadon.Rows[chisodongdangchon].Cells["ColumMahoadon"].Value.ToString();
            }
        }
    }
}

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
    public partial class FormChitiethoadon : Form
    {
        public FormChitiethoadon()
        {
            InitializeComponent();
        }
        public string Mahoadon;
        string Ngayban = "";
        private void FormChitiethoadon_Load(object sender, EventArgs e)
        {
            Loadchitiethoadon();
        }
        void Loadchitiethoadon()
        {
            string sqlchitiethoadon = @"select hd.Masanpham,sp.Tensanpham,sp.Giaban,hd.Soluongban,hd.Thanhtien
                                        from CHITIETHOADON hd,SANPHAM sp where hd.Masanpham = sp.Masanpham and hd.Mahoadon = '"+int.Parse(Mahoadon)+"'";
            DataTable dtchitiethoadon = DataProvider.LoadCSDL(sqlchitiethoadon);
            dgvSanphamban.DataSource = dtchitiethoadon;
            int demsanpham = dgvSanphamban.Rows.Count;
            float tongtien = 0;
            for (int i = 0; i < demsanpham; i++)
            {
                tongtien += float.Parse(dgvSanphamban.Rows[i].Cells["ColumThanhtien"].Value.ToString());
            }
            lblTongtienthanhtoan.Text = tongtien.ToString() + " VNĐ";
            dgvSanphamban.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            string sqlhoadon = @"select hd.Mahoadon,kh.Tenkhachhang,nv.Tennhanvien,hd.Ngayban
                                 from HOADON hd, KHACHHANG kh, NHANVIEN nv where hd.Makhachhang = kh.Makhachhang and hd.Manhanvien = nv.Manhanvien and hd.Mahoadon = '"+int.Parse(Mahoadon)+"'";
            DataTable dthoadon = DataProvider.LoadCSDL(sqlhoadon);
            txtMahoadon.Text = dthoadon.Rows[0][0].ToString();
            txtTenkhachhang.Text = dthoadon.Rows[0][1].ToString();
            txtNhanvien.Text = dthoadon.Rows[0][2].ToString();
            string ngaynban = dthoadon.Rows[0][3].ToString();
            int cat = 0;
            for (int i = 0; i < ngaynban.Length; i++)
            {
                if (ngaynban[i] == ' ')
                {
                    cat = i;
                    break;
                }
            }
            Ngayban = ngaynban.Substring(0, cat).Trim();
            txtNgayban.Text = ngaynban.Substring(0, cat).Trim();
            
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            FormInhoadon frm = new FormInhoadon();
            frm.MAHOADON = Mahoadon;
            frm.Tenkhachhang = txtTenkhachhang.Text;
            frm.Tennhanvien = txtNhanvien.Text;
            frm.Ngayban = Ngayban;
            frm.Tienthanhtoan = lblTongtienthanhtoan.Text;
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

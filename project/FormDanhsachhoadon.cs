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
    public partial class FormDanhsachhoadon : Form
    {
        public FormDanhsachhoadon()
        {
            InitializeComponent();
        }

        private void FormDanhsachhoadon_Load(object sender, EventArgs e)
        {
            string sqlhoadon = @"select hd.Mahoadon as 'Mã Hóa Đơn', kh.Tenkhachhang as 'Tên Khách Hàng',nv.Tennhanvien as 'Tên Nhân Viên', hd.Ngayban as 'Ngày Bán'
                                 from HOADON hd, KHACHHANG kh, NHANVIEN nv
                                 where hd.Manhanvien = nv.Manhanvien and hd.Makhachhang = kh.Makhachhang";
            DataTable dthoadon = DataProvider.LoadCSDL(sqlhoadon);
            dgvHoadon.DataSource = dthoadon;
            dgvHoadon.Columns[1].Width = 200;
            dgvHoadon.Columns[2].Width = 200;
            dgvHoadon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lblTonghoadon.Text = dthoadon.Rows.Count.ToString();
        }
    }
}

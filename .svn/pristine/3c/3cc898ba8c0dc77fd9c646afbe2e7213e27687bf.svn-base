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
    public partial class FormKhachhang : Form
    {
        public FormKhachhang()
        {
            InitializeComponent();
        }
        string makhachhang = "";
        string tenkhachhang = "";
        string gioitinh = "";
        string ngaysinh = "";
        string diachi = "";
        string sodienthoai = "";
        string tongtien = "";
        private void FormKhachhang_Load(object sender, EventArgs e)
        {
            Loadkhachhang();
        }
        void Loadkhachhang()
        {
            string sqlkhachhang = @"select * from KHACHHANG";
            DataTable dtkhachhang = DataProvider.LoadCSDL(sqlkhachhang);
            dgvKhachhang.DataSource = dtkhachhang;
            dgvKhachhang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lblTongkhachhang.Text = dtkhachhang.Rows.Count.ToString();
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachhang.Rows.Count > 0)
            {
                int chisodongdangchon = dgvKhachhang.CurrentCell.RowIndex;
                txtkhachhang.Text = dgvKhachhang.Rows[chisodongdangchon].Cells["ColumMakhachhang"].Value.ToString();
            }
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            if (txtkhachhang.Text != "")
            {
                string sqlkhachhang = @"select * from KHACHHANG";
                DataTable dtkhachahng = DataProvider.LoadCSDL(sqlkhachhang);
                int demkhachhang = dtkhachahng.Rows.Count;
                int kiemtrakhachang = 0;
                for (int i = 0; i < demkhachhang; i++)
                {
                    if (txtkhachhang.Text == dtkhachahng.Rows[i][0].ToString())
                    {
                        kiemtrakhachang = 1;
                        makhachhang = dtkhachahng.Rows[i][0].ToString();
                        tenkhachhang = dtkhachahng.Rows[i][1].ToString();
                        gioitinh = dtkhachahng.Rows[i][2].ToString();
                        ngaysinh = dtkhachahng.Rows[i][3].ToString();
                        for (int j = 0; j < ngaysinh.Length; j++)
                        {
                            if (ngaysinh[j] == ' ')
                            {
                                ngaysinh = ngaysinh.Substring(0, j);
                                break;
                            }
                        }
                        diachi = dtkhachahng.Rows[i][4].ToString();
                        sodienthoai = dtkhachahng.Rows[i][5].ToString();
                        string sqlchitiethoadon = @"	select hd.Makhachhang, ct.Masanpham,sp.Tensanpham, sp.Giaban,ct.Soluongban,ct.Thanhtien
	                                                    from HOADON hd,SANPHAM sp,CHITIETHOADON ct
	                                                    where hd.Mahoadon = ct.Mahoadon and sp.Masanpham = ct.Masanpham and hd.Makhachhang = '"+int.Parse(txtkhachhang.Text)+"'";
                        DataTable dtchitiethoadon = DataProvider.LoadCSDL(sqlchitiethoadon);
                        int demchitiethoadon = dtchitiethoadon.Rows.Count;
                        float tongtien2 = 0;
                        for (int j = 0; j < demchitiethoadon; j++)
                        {
                            tongtien2 += float.Parse(dtchitiethoadon.Rows[j][5].ToString());
                        }
                        tongtien = tongtien2.ToString() + " VNĐ";
                        break;
                    }
                }
                if (kiemtrakhachang == 1)
                {
                    FormChitietkhachhang frm = new FormChitietkhachhang();
                    frm.Makhachhang = makhachhang;
                    frm.Tenkhachhang = tenkhachhang;
                    frm.Gioitinh = gioitinh;
                    frm.Ngaysinh = ngaysinh;
                    frm.Diachi = diachi;
                    frm.Sodienthoai = sodienthoai;
                    frm.Tongtien = tongtien;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không Tồn Tại Khách Hàng Có Mã Số " + txtkhachhang.Text);
                }
            }
        }
    }
}

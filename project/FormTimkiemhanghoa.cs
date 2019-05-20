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
    public partial class FormTimkiemhanghoa : Form
    {
        public FormTimkiemhanghoa()
        {
            InitializeComponent();
        }
        public string Matimkiem, Tentimkiem;
        public int kieutimkiem;
        private void FormTimkiemhanghoa_Load(object sender, EventArgs e)
        {
            string sqlsanpham = @"select sp.Masanpham, sp.Tensanpham, lsp.Tenloai, ncc.Tennhacungcap, sp.Gianhap,sp.Giaban, sp.Donvi,sp.Soluong
                                  from SANPHAM sp, LOAISANPHAM lsp, NHACUNGCAP ncc
                                  where sp.Maloai = lsp.Maloai and sp.Manhacungcap = ncc.Manhacungcap";
            DataTable dtsanpham = DataProvider.LoadCSDL(sqlsanpham);
            int demsanpham = dtsanpham.Rows.Count;

            string sqlchitiethoadon = @"select ct.Mahoadon,ct.Masanpham,sp.Gianhap,sp.Giaban,ct.Soluongban,ct.Thanhtien from CHITIETHOADON ct, SANPHAM sp where sp.Masanpham = ct.Masanpham";
            DataTable dtchitiethoadon = DataProvider.LoadCSDL(sqlchitiethoadon);
            int demhoadon = dtchitiethoadon.Rows.Count;
            if (kieutimkiem == 1)
            {
                for (int i = 0; i < demsanpham; i++)
                {
                    if (Matimkiem == dtsanpham.Rows[i][0].ToString())
                    {
                        txtMasanpham.Text = dtsanpham.Rows[i][0].ToString();
                        txtTensanpham.Text = dtsanpham.Rows[i][1].ToString();
                        txtDonvi.Text = dtsanpham.Rows[i][6].ToString();
                        txtNhacungcap.Text = dtsanpham.Rows[i][3].ToString();
                        txtLoaisanpham.Text = dtsanpham.Rows[i][2].ToString();
                        txtGianhap.Text = dtsanpham.Rows[i][4].ToString();
                        txtGiaban.Text = dtsanpham.Rows[i][5].ToString();
                        txtSoluongton.Text = dtsanpham.Rows[i][7].ToString();
                        int soluongban = 0;
                        float doanhthu = 0;
                        float loinhuan = 0;
                        for (int j = 0; j < demhoadon; j++)
                        {
                            if (Matimkiem == dtchitiethoadon.Rows[j][1].ToString())
                            {
                                soluongban += int.Parse(dtchitiethoadon.Rows[j][4].ToString());
                                doanhthu += float.Parse(dtchitiethoadon.Rows[j][5].ToString());
                                loinhuan += (float.Parse(dtchitiethoadon.Rows[j][3].ToString()) - float.Parse(dtchitiethoadon.Rows[j][2].ToString())) * float.Parse(dtchitiethoadon.Rows[j][4].ToString());
                            }
                        }
                        txtSoluongdaban.Text = soluongban.ToString();
                        txtDoanhthu.Text = doanhthu.ToString();
                        txtLoinhuan.Text = loinhuan.ToString();
                        break;
                    }
                }
            }
            else if (kieutimkiem == 2)
            {
                for (int i = 0; i < demsanpham; i++)
                {
                    if (Tentimkiem.Trim().ToLower() == dtsanpham.Rows[i][1].ToString().ToLower())
                    {
                        txtMasanpham.Text = dtsanpham.Rows[i][0].ToString();
                        txtTensanpham.Text = dtsanpham.Rows[i][1].ToString();
                        txtDonvi.Text = dtsanpham.Rows[i][6].ToString();
                        txtNhacungcap.Text = dtsanpham.Rows[i][3].ToString();
                        txtLoaisanpham.Text = dtsanpham.Rows[i][2].ToString();
                        txtGianhap.Text = dtsanpham.Rows[i][4].ToString();
                        txtGiaban.Text = dtsanpham.Rows[i][5].ToString();
                        txtSoluongton.Text = dtsanpham.Rows[i][7].ToString();
                        int soluongban = 0;
                        float doanhthu = 0;
                        float loinhuan = 0;
                        for (int j = 0; j < demhoadon; j++)
                        {
                            if (txtMasanpham.Text == dtchitiethoadon.Rows[j][1].ToString())
                            {
                                soluongban += int.Parse(dtchitiethoadon.Rows[j][4].ToString());
                                doanhthu += float.Parse(dtchitiethoadon.Rows[j][5].ToString());
                                loinhuan += (float.Parse(dtchitiethoadon.Rows[j][3].ToString()) - float.Parse(dtchitiethoadon.Rows[j][2].ToString())) * float.Parse(dtchitiethoadon.Rows[j][4].ToString());
                            }
                        }
                        txtSoluongdaban.Text = soluongban.ToString();
                        txtDoanhthu.Text = doanhthu.ToString();
                        txtLoinhuan.Text = loinhuan.ToString();
                        break;
                    }
                }
            }
        }
    }
}

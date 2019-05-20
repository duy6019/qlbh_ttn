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
    public partial class FormHanghoa : Form
    {
        public FormHanghoa()
        {
            InitializeComponent();
        }
        int demsanpham = 0;
        private void FormHanghoa_Load(object sender, EventArgs e)
        {
            Loadsanpham();
            dgvSanpham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lbTongsosanpham.Text = demsanpham.ToString();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
           
        }
        void Loadsanpham()
        {
            string sqlhanghoa = @"select sp.Masanpham as 'Mã Sản Phẩm', sp.Tensanpham as 'Tên Sản Phẩm', lsp.Tenloai as 'Loại Sản Phẩm', ncc.Tennhacungcap as 'Nhà Cung Cấp', sp.Gianhap as 'Giá Nhập',sp.Giaban as 'Giá Bán', sp.Donvi as 'Đơn Vị Tính',sp.Soluong as 'Số Lượng Tồn'
                                  from SANPHAM sp, LOAISANPHAM lsp, NHACUNGCAP ncc
                                  where sp.Maloai = lsp.Maloai and sp.Manhacungcap = ncc.Manhacungcap";
            DataTable dthanghoa = DataProvider.LoadCSDL(sqlhanghoa);
            dgvSanpham.DataSource = dthanghoa;
            demsanpham = dthanghoa.Rows.Count;

            string sqlnhacungcap = @"select * from NHACUNGCAP";
            DataTable dtnhacungcap = DataProvider.LoadCSDL(sqlnhacungcap);
            cmbLoctheonhacungcap.DataSource = dtnhacungcap;
            cmbLoctheonhacungcap.DisplayMember = "Tennhacungcap";
            cmbLoctheonhacungcap.ValueMember = "Manhacungcap";
            string sqlnhacungcap2 = @"select ncc.Manhacungcap, ncc.Tennhacungcap from NHACUNGCAP ncc";
            DataTable dtnhacungcap2 = DataProvider.LoadCSDL(sqlnhacungcap2);
            cmbNhacungcap.DataSource = dtnhacungcap2;
            cmbNhacungcap.DisplayMember = "Tennhacungcap";
            cmbNhacungcap.ValueMember = "Manhacungcap";

            string sqlloaisanpham = @"select * from LOAISANPHAM";
            DataTable dtloaisanpham = DataProvider.LoadCSDL(sqlloaisanpham);
            cmbLoctheoloaisanpham.DataSource = dtloaisanpham;
            cmbLoctheoloaisanpham.DisplayMember = "Tenloai";
            cmbLoctheoloaisanpham.ValueMember = "Maloai";

            string sqlloaisanpham2 = @"select * from LOAISANPHAM";
            DataTable dtloaisanpham2 = DataProvider.LoadCSDL(sqlloaisanpham2);
            cmbLoaisanpham.DataSource = dtloaisanpham2;
            cmbLoaisanpham.DisplayMember = "Tenloai";
            cmbLoaisanpham.ValueMember = "Maloai";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool kiemtranhaplieu = Kiemtranhaplieusanpham();
            bool kiemtranghiepvu = true;
            if (kiemtranhaplieu == true)
            {
                string sqlsanpham = @"select * from SANPHAM";
                DataTable dtsanpham = DataProvider.LoadCSDL(sqlsanpham);
                int demsanpham = dtsanpham.Rows.Count;
                for (int i = 0; i < demsanpham; i++)
                {
                    if (txtMasanpham.Text == dtsanpham.Rows[i][0].ToString())
                    {
                        MessageBox.Show("Mã Sản Phẩm Đã Bị Trùng");
                        kiemtranghiepvu = false;
                        break;
                    }
                }                
                if (kiemtranghiepvu == true)
                {
                    bool kiemtranghiepvu2 = Kiemtratinhdungdancuadulieu();
                    if (kiemtranghiepvu2 == true)
                    {
                        string sqlnhacungcap = @"select * from NHACUNGCAP";
                        DataTable dtnhacungcap = DataProvider.LoadCSDL(sqlnhacungcap);
                        int demnhacungcap = dtnhacungcap.Rows.Count;
                        int kiemtranhacungcap = 1;
                        for (int i = 0; i < demnhacungcap; i++)
                        {
                            if (txtNhacungcap.Text.Trim().ToLower() == dtnhacungcap.Rows[i][1].ToString().Trim().ToLower())
                            {
                                kiemtranhacungcap = 0;
                                break;
                            }
                        }
                        bool kiemtrathemnhacungcap = true;
                        if (kiemtranhacungcap == 1)
                        {
                            try
                            {
                                string sqlthemnhacungcap = @"insert into NHACUNGCAP(Manhacungcap, Tennhacungcap) 
                                                             values('" + (demnhacungcap + 1) + "', N'" + txtNhacungcap.Text + "')";
                                int ketquathemnhacungcap = DataProvider.change(sqlthemnhacungcap);
                                if (kiemtranhacungcap < 0)
                                {
                                    MessageBox.Show("Thêm Nhà Cung Cấp Thất Bại");
                                    kiemtrathemnhacungcap = false;
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Thêm Nhà Cung Cấp Thất Bại");
                                kiemtrathemnhacungcap = false;
                            }
                        }
                        if (kiemtrathemnhacungcap == true)
                        {
                            string sqlloaisanpham = @"select * from LOAISANPHAM";
                            DataTable dtloaisanpham = DataProvider.LoadCSDL(sqlloaisanpham);
                            int demloaisanpham = dtloaisanpham.Rows.Count;
                            int kiemtraloaisanpham = 1;
                            for (int i = 0; i < demloaisanpham; i++)
                            {
                                if (txtLoaisanpham.Text.Trim().ToLower() == dtloaisanpham.Rows[i][1].ToString().ToLower())
                                {
                                    kiemtraloaisanpham = 0;
                                    break;
                                }
                            }
                            bool kiemtrathemloaisanpham = true;
                            if (kiemtraloaisanpham == 1)
                            {
                                try
                                {
                                    string sqlthemloaisanpham = @"insert into LOAISANPHAM(Maloai,Tenloai) 
                                                              values('" + (demloaisanpham + 1) + "', N'" + txtLoaisanpham.Text + "')";
                                    int ketquanthemloaisanpham = DataProvider.change(sqlthemloaisanpham);
                                    if (ketquanthemloaisanpham < 0)
                                    {
                                        MessageBox.Show("Thêm Loại Sản Phẩm Thất Bại");
                                        kiemtrathemloaisanpham = false;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Thêm Loại Sản Phẩm Thất Bại");
                                    kiemtrathemloaisanpham = false;
                                }
                            }
                            if (kiemtrathemloaisanpham == true)
                            {
                                if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thêm Sản Phẩm Này Vào Kho Hàng?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    string sqlloaisanpham2 = @"select * from LOAISANPHAM";
                                    DataTable dtloaisanpham2 = DataProvider.LoadCSDL(sqlloaisanpham2);
                                    int demloaisanpham2 = dtloaisanpham2.Rows.Count;
                                    string maloai = "";
                                    for (int i = 0; i < demloaisanpham2; i++)
                                    {
                                        if (txtLoaisanpham.Text.Trim().ToLower() == dtloaisanpham2.Rows[i][1].ToString().ToLower())
                                        {
                                            maloai = dtloaisanpham2.Rows[i][0].ToString();
                                            break;
                                        }
                                    }
                                    string sqlnhacungcap2 = @"select * from NHACUNGCAP";
                                    DataTable dtnhacungcap2 = DataProvider.LoadCSDL(sqlnhacungcap2);
                                    int demnhacungcap2 = dtnhacungcap2.Rows.Count;
                                    string manhacungcap = "";
                                    for (int i = 0; i < demnhacungcap2; i++)
                                    {
                                        if (txtNhacungcap.Text.Trim().ToLower() == dtnhacungcap2.Rows[i][1].ToString().ToLower())
                                        {
                                            manhacungcap = dtnhacungcap2.Rows[i][0].ToString();
                                            break;
                                        }
                                    }
                                    // thêm
                                    try
                                    {
                                        string sqlthemsanpham = @"insert into SANPHAM(Masanpham,Tensanpham,Maloai,Manhacungcap,Gianhap,Giaban,Soluong,Donvi) 
                                                                  values('" + int.Parse(txtMasanpham.Text) + "', N'" + txtTensanpham.Text + "', '" + int.Parse(maloai) + "', '" + int.Parse(manhacungcap) + "', '" + float.Parse(txtGianhap.Text) + "', '" + float.Parse(txtGiaban.Text) + "', '" + int.Parse(txtSoluongton.Text) + "', N'" + txtDonvi.Text.ToString() + "')";
                                        int ketquathemsanpham = DataProvider.change(sqlthemsanpham);
                                        if (ketquathemsanpham > 0)
                                        {
                                            Loadsanpham();
                                            Hoantac();
                                            MessageBox.Show("Thêm Sản Phẩm Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Thêm Sản Phẩm Thất Bại", "Thất Bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Thêm Sản Phẩm Thất Bại", "Thất Bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }

        private bool Kiemtratinhdungdancuadulieu()
        {
            bool kiemtranghiepvu2 = true;
            try
            {
                float gianhap = float.Parse(txtGianhap.Text);
                if (float.Parse(txtGianhap.Text) <= 0)
                {
                    MessageBox.Show("Giá Nhập Không Hợp Lệ");
                    kiemtranghiepvu2 = false;
                    txtGianhap.Clear();
                    txtGianhap.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Giá Nhập Không Hợp Lệ");
                kiemtranghiepvu2 = false;
                txtGianhap.Clear();
                txtGianhap.Focus();
            }
            try
            {
                float giaban = float.Parse(txtGiaban.Text);
                if (float.Parse(txtGiaban.Text) <= 0)
                {
                    MessageBox.Show("Giá Bán Không Hợp Lệ");
                    kiemtranghiepvu2 = false;
                    txtGiaban.Clear();
                    txtGiaban.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Giá Bán Không Hợp Lệ");
                kiemtranghiepvu2 = false;
                txtGiaban.Clear();
                txtGiaban.Focus();
            }
            if (int.Parse(txtSoluongton.Text) < 0)
            {
                MessageBox.Show("Số Lượng Sản Phẩm Không Hợp Lệ");
                kiemtranghiepvu2 = false;
                txtSoluongton.Clear();
                txtSoluongton.Focus();
            }
            return kiemtranghiepvu2;
        }

        private bool Kiemtranhaplieusanpham()
        {
            bool kiemtranhaplieu = true;
            if (txtMasanpham.Text == "")
            {
                MessageBox.Show("Chưa Nhập Mã Sản Phẩm");
                kiemtranhaplieu = false;
                txtMasanpham.Focus();
            }
            else if (txtTensanpham.Text == "")
            {
                MessageBox.Show("Chưa Nhập Tên Sản Phẩm");
                kiemtranhaplieu = false;
                txtTensanpham.Focus();
            }
            //else if (txtDonvi.Text == "")
            //{
            //    MessageBox.Show("Chưa Nhập Đơn Vị Tính");
            //    kiemtranhaplieu = false;
            //    txtDonvi.Focus();
            //}
            else if (txtNhacungcap.Text == "")
            {
                MessageBox.Show("Chưa Nhập Nhà Cung Cấp");
                kiemtranhaplieu = false;
                txtNhacungcap.Focus();
            }
            else if (txtLoaisanpham.Text == "")
            {
                MessageBox.Show("Chưa Nhập Loại Sản Phẩm");
                kiemtranhaplieu = false;
                txtLoaisanpham.Focus();
            }
            else if (txtGianhap.Text == "")
            {
                MessageBox.Show("Chưa Nhập Giá Nhập Cho Sản Phẩm");
                kiemtranhaplieu = false;
                txtGianhap.Focus();
            }
            else if (txtGiaban.Text == "")
            {
                MessageBox.Show("Chưa Nhập Giá Bán Cho Sản Phẩm");
                kiemtranhaplieu = false;
                txtGiaban.Focus();
            }
            else if (txtSoluongton.Text == "")
            {
                MessageBox.Show("Chưa Nhập Số Lượng Cho Sản Phẩm");
                kiemtranhaplieu = false;
                txtSoluongton.Focus();
            }
            return kiemtranhaplieu;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanpham.Rows.Count > 0)
            {
                int chisodongdangchon = dgvSanpham.CurrentCell.RowIndex;
                if (MessageBox.Show("Bạn có chắc chắn muốn thay đổi thông tin của mặt hàng có tên " + dgvSanpham.Rows[chisodongdangchon].Cells[1].Value.ToString() + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool kiemtranhaplieu = Kiemtranhaplieusanpham();
                    if (kiemtranhaplieu)
                    {
                        bool kiemtranghiepvu = Kiemtratinhdungdancuadulieu();
                        if (kiemtranghiepvu)
                        {
                            try
                            {
                                string sqlsuasanpham = @"update SANPHAM 
                                                     set Tensanpham = N'" + txtTensanpham.Text + "', Maloai = '" + int.Parse(cmbLoaisanpham.SelectedValue.ToString()) + "', Manhacungcap = '" + int.Parse(cmbNhacungcap.SelectedValue.ToString()) + "', Gianhap = '" + float.Parse(txtGianhap.Text) + "', Giaban = '" + float.Parse(txtGiaban.Text) + "', Soluong = '" + int.Parse(txtSoluongton.Text) + "', Donvi = N'" + txtDonvi.Text + "' where SANPHAM.Masanpham = '" + int.Parse(txtMasanpham.Text) + "'";
                                int ketquasua = DataProvider.change(sqlsuasanpham);
                                if (ketquasua > 0)
                                {
                                    //Loadsanpham();
                                    Hoantac();
                                    MessageBox.Show("Thay Đổi Thông Tin Sản Phẩm Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Thay Đổi Thông Tin Sản Phẩm Thất Bại", "Thất Bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Thay Đổi Thông Tin Sản Phẩm Thất Bại", "Thất Bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int chisodongdangchon = dgvSanpham.CurrentCell.RowIndex;
            string sqlchitiethoadon = @"select * from CHITIETHOADON";
            DataTable dtchitiethoadon = DataProvider.LoadCSDL(sqlchitiethoadon);
            int demhoadon = dtchitiethoadon.Rows.Count;
            bool kiemtrahoadon = true;
            string mahoadon = "";
            for (int i = 0; i < demhoadon; i++)
            {
                if (dgvSanpham.Rows[chisodongdangchon].Cells[0].Value.ToString() == dtchitiethoadon.Rows[i][1].ToString())
                {
                    kiemtrahoadon = false;
                    mahoadon = dtchitiethoadon.Rows[i][0].ToString();
                    break;
                }
            }
            if (kiemtrahoadon == false)
            {
                MessageBox.Show("Mặt Hàng Không Thể Xóa Khi Dữ Liệu Bị Ràng Buộc Bởi Hóa Đơn Có Mã " + mahoadon + ".", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Xác nhận xóa mặt hàng có tên " + dgvSanpham.Rows[chisodongdangchon].Cells[1].Value.ToString() + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string sqlxoasanpham = @"delete from SANPHAM where SANPHAM.Masanpham = '"+int.Parse(txtMasanpham.Text)+"'";
                        int ketquaxoa = DataProvider.change(sqlxoasanpham);
                        if (ketquaxoa > 0)
                        {
                            Loadsanpham();
                            Hoantac();
                            MessageBox.Show("Xóa Sản Phẩm Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa Sản Phẩm Thất Bại", "Thất Bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Xóa Sản Phẩm Thất Bại", "Thất Bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHoantac_Click(object sender, EventArgs e)
        {
            string sqlhanghoa = @"select sp.Masanpham as 'Mã Sản Phẩm', sp.Tensanpham as 'Tên Sản Phẩm', lsp.Tenloai as 'Loại Sản Phẩm', ncc.Tennhacungcap as 'Nhà Cung Cấp', sp.Gianhap as 'Giá Nhập',sp.Giaban as 'Giá Bán', sp.Donvi as 'Đơn Vị Tính',sp.Soluong as 'Số Lượng Tồn'
                                  from SANPHAM sp, LOAISANPHAM lsp, NHACUNGCAP ncc
                                  where sp.Maloai = lsp.Maloai and sp.Manhacungcap = ncc.Manhacungcap";
            DataTable dthanghoa = DataProvider.LoadCSDL(sqlhanghoa);
            dgvSanpham.DataSource = dthanghoa;
            demsanpham = dthanghoa.Rows.Count;
            Hoantac();
        }
        void Hoantac()
        {
            txtMasanpham.Text = "";
            txtTensanpham.Text = "";
            txtDonvi.Text = "";
            txtNhacungcap.Text = "";
            txtLoaisanpham.Text = "";
            txtGianhap.Text = "";
            txtGiaban.Text = "";
            txtSoluongton.Text = "";
            txtMasanpham.Enabled = true;
            btnMasanpham.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void btnInhanghoa_Click(object sender, EventArgs e)
        {
            FormInsanpham frm = new FormInsanpham();
            frm.ShowDialog();
        }

        private void btnMasanpham_Click(object sender, EventArgs e)
        {
            string sqlsanpham = @"select * from SANPHAM";
            DataTable dtsanpham = DataProvider.LoadCSDL(sqlsanpham);
            int demsanpham = dtsanpham.Rows.Count;
            if (demsanpham == 0)
            {
                txtMasanpham.Text = "1";
            }
            else if (demsanpham == 1)
            {
                txtMasanpham.Text = "2";
            }
            else
            {
                bool kiemtrama = true;
                for (int i = 0; i < demsanpham - 1; i++)
                {
                    if ((int.Parse(dtsanpham.Rows[i + 1][0].ToString()) - int.Parse(dtsanpham.Rows[i][0].ToString())) >= 2)
                    {
                        txtMasanpham.Text = (int.Parse(dtsanpham.Rows[i][0].ToString()) + 1).ToString();
                        kiemtrama = false;
                        break;
                    }
                }
                if (kiemtrama == true)
                {
                    txtMasanpham.Text = (demsanpham + 1).ToString();
                }
            }
        }

        private void cmbNhacungcap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlnhacungcap = @"select * from NHACUNGCAP";
            DataTable dtnhacungcap = DataProvider.LoadCSDL(sqlnhacungcap);
            int demnhacungcap = dtnhacungcap.Rows.Count;
            for (int i = 0; i < demnhacungcap; i++)
            {
                if (dtnhacungcap.Rows[i][0].ToString() == cmbNhacungcap.SelectedValue.ToString())
                {
                    txtNhacungcap.Text = dtnhacungcap.Rows[i][1].ToString();
                    break;
                }
            }
        }

        private void cmbLoaisanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlloaisanpham = @"select * from LOAISANPHAM";
            DataTable dtloaisanpham = DataProvider.LoadCSDL(sqlloaisanpham);
            int demloaisanpham = dtloaisanpham.Rows.Count;
            for (int i = 0; i < demloaisanpham; i++)
            {
                if (dtloaisanpham.Rows[i][0].ToString() == cmbLoaisanpham.SelectedValue.ToString())
                {
                    txtLoaisanpham.Text = dtloaisanpham.Rows[i][1].ToString();
                    break;
                }
            }
        }

        private void txtMasanpham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSoluongton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanpham.Rows.Count > 0)
            {
                txtMasanpham.Enabled = false;
                btnMasanpham.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                int chisodongdangchon = dgvSanpham.CurrentCell.RowIndex;
                txtMasanpham.Text = dgvSanpham.Rows[chisodongdangchon].Cells[0].Value.ToString();
                txtTensanpham.Text = dgvSanpham.Rows[chisodongdangchon].Cells[1].Value.ToString();
                txtDonvi.Text = dgvSanpham.Rows[chisodongdangchon].Cells[6].Value.ToString();
                txtNhacungcap.Text = dgvSanpham.Rows[chisodongdangchon].Cells[3].Value.ToString();
                txtLoaisanpham.Text = dgvSanpham.Rows[chisodongdangchon].Cells[2].Value.ToString();
                txtGianhap.Text = dgvSanpham.Rows[chisodongdangchon].Cells[4].Value.ToString();
                txtGiaban.Text = dgvSanpham.Rows[chisodongdangchon].Cells[5].Value.ToString();
                txtSoluongton.Text = dgvSanpham.Rows[chisodongdangchon].Cells[7].Value.ToString();
                string sqlnhacungcap = @"select * from NHACUNGCAP";
                DataTable dtnhacungcap = DataProvider.LoadCSDL(sqlnhacungcap);
                int demnhacungcap = dtnhacungcap.Rows.Count;
                for (int i = 0; i < demnhacungcap; i++)
                {
                    if (dgvSanpham.Rows[chisodongdangchon].Cells[3].Value.ToString() == dtnhacungcap.Rows[i][1].ToString())
                    {
                        cmbNhacungcap.SelectedIndex = i;
                        break;
                    }
                }
                string sqlloaisanpham = @"select * from LOAISANPHAM";
                DataTable dtloaisanpham = DataProvider.LoadCSDL(sqlloaisanpham);
                int demloaisanpham = dtloaisanpham.Rows.Count;
                for (int i = 0; i < demloaisanpham; i++)
                {
                    if (dgvSanpham.Rows[chisodongdangchon].Cells[2].Value.ToString() == dtloaisanpham.Rows[i][1].ToString())
                    {
                        cmbLoaisanpham.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text != "")
            {
                FormTimkiemhanghoa frm = new FormTimkiemhanghoa();
                if (Timkiemtheoma(txtTimkiem.Text))
                {
                    frm.kieutimkiem = 1;
                    frm.Matimkiem = txtTimkiem.Text;
                    frm.ShowDialog();
                }
                else if (Timkiemtheoten(txtTimkiem.Text))
                {
                    frm.kieutimkiem = 2;
                    frm.Tentimkiem = txtTimkiem.Text;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không Tồn Tại Mặt Hàng Có Thông Tin Này.");
                }
            }
        }
        bool Timkiemtheoma(string matimkiem)
        {
            string sqlsanpham = @"select * from SANPHAM";
            DataTable dtsanpham = DataProvider.LoadCSDL(sqlsanpham);
            int demsanpham = dtsanpham.Rows.Count;
            for (int i = 0; i < demsanpham; i++)
            {
                if (matimkiem.Trim() == dtsanpham.Rows[i][0].ToString())
                {
                    return true;
                }
            }
            return false;
        }

        bool Timkiemtheoten(string tentimkiem)
        {

            string sqlsanpham = @"select * from SANPHAM";
            DataTable dtsanpham = DataProvider.LoadCSDL(sqlsanpham);
            int demsanpham = dtsanpham.Rows.Count;
            for (int i = 0; i < demsanpham; i++)
            {
                if (tentimkiem.Trim().ToLower() == dtsanpham.Rows[i][1].ToString().Trim().ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private void cmbLoctheoloaisanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(cmbLoctheoloaisanpham.SelectedValue.ToString());
            if (cmbLoctheoloaisanpham.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string sqlsanpham = @"select * from SANPHAM";
                DataTable dtsanpham = DataProvider.LoadCSDL(sqlsanpham);
                int demsanpham = dtsanpham.Rows.Count;
                string sqlloaisanphamcungloai = @"select sp.Masanpham as 'Mã Sản Phẩm', sp.Tensanpham as 'Tên Sản Phẩm', lsp.Tenloai as 'Loại Sản Phẩm', ncc.Tennhacungcap as 'Nhà Cung Cấp', sp.Gianhap as 'Giá Nhập',sp.Giaban as 'Giá Bán', sp.Donvi as 'Đơn Vị Tính',sp.Soluong as 'Số Lượng Tồn'
                                                 from SANPHAM sp, LOAISANPHAM lsp, NHACUNGCAP ncc
                                                 where sp.Maloai = lsp.Maloai and sp.Manhacungcap = ncc.Manhacungcap and lsp.Maloai = '" + int.Parse(cmbLoctheoloaisanpham.SelectedValue.ToString()) + "'";
                DataTable dtsanphamcungloai = DataProvider.LoadCSDL(sqlloaisanphamcungloai);
                dgvSanpham.DataSource = null;
                dgvSanpham.DataSource = dtsanphamcungloai;
            }
        }

        private void cmbLoctheonhacungcap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoctheonhacungcap.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string sqlsanpham = @"select * from SANPHAM";
                DataTable dtsanpham = DataProvider.LoadCSDL(sqlsanpham);
                int demsanpham = dtsanpham.Rows.Count;
                string sqlsanphamcungnhacungcap = @"select sp.Masanpham as 'Mã Sản Phẩm', sp.Tensanpham as 'Tên Sản Phẩm', lsp.Tenloai as 'Loại Sản Phẩm', ncc.Tennhacungcap as 'Nhà Cung Cấp', sp.Gianhap as 'Giá Nhập',sp.Giaban as 'Giá Bán', sp.Donvi as 'Đơn Vị Tính',sp.Soluong as 'Số Lượng Tồn'
                                                 from SANPHAM sp, LOAISANPHAM lsp, NHACUNGCAP ncc
                                                 where sp.Maloai = lsp.Maloai and sp.Manhacungcap = ncc.Manhacungcap and ncc.Manhacungcap = '" + int.Parse(cmbLoctheonhacungcap.SelectedValue.ToString()) + "'";
                DataTable dtsanphamcungnhacungcap = DataProvider.LoadCSDL(sqlsanphamcungnhacungcap);
                dgvSanpham.DataSource = null;
                dgvSanpham.DataSource = dtsanphamcungnhacungcap;
                Locsanpham();
            }
        }
        void Locsanpham()
        {
            if (cmbNhacungcap.SelectedValue.ToString() != "System.Data.DataRowView" && cmbLoaisanpham.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string sqlsanpham = @"select * from SANPHAM";
                DataTable dtsanpham = DataProvider.LoadCSDL(sqlsanpham);
                int demsanpham = dtsanpham.Rows.Count;
                string sqlsanphamcungnhacungcap = @"select sp.Masanpham as 'Mã Sản Phẩm', sp.Tensanpham as 'Tên Sản Phẩm', lsp.Tenloai as 'Loại Sản Phẩm', ncc.Tennhacungcap as 'Nhà Cung Cấp', sp.Gianhap as 'Giá Nhập',sp.Giaban as 'Giá Bán', sp.Donvi as 'Đơn Vị Tính',sp.Soluong as 'Số Lượng Tồn'
                                                 from SANPHAM sp, LOAISANPHAM lsp, NHACUNGCAP ncc
                                                 where sp.Maloai = lsp.Maloai and sp.Manhacungcap = ncc.Manhacungcap and ncc.Manhacungcap = '" + int.Parse(cmbLoctheonhacungcap.SelectedValue.ToString()) + "' and lsp.Maloai = '" + int.Parse(cmbLoctheoloaisanpham.SelectedValue.ToString()) + "'";
                DataTable dtsanphamcungnhacungcap = DataProvider.LoadCSDL(sqlsanphamcungnhacungcap);
                dgvSanpham.DataSource = null;
                dgvSanpham.DataSource = dtsanphamcungnhacungcap;
            }
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTrangChu frm = new FormTrangChu();
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

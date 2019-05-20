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
    public partial class FormBanhang : Form
    {
        public FormBanhang()
        {
            InitializeComponent();
        }

        private void FormBanhang_Load(object sender, EventArgs e)
        {
            Loadsanpham();
            Loadnhanvien();
            dgvSanpham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMathangban.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtpNgayban.Format = DateTimePickerFormat.Custom;
            dtpNgayban.CustomFormat = "MM/dd/yyyy";

            dtpNgaysinh.Format = DateTimePickerFormat.Custom;
            dtpNgaysinh.CustomFormat = "MM/dd/yyyy";

            cmbGioitinh.SelectedIndex = 0;
            rdbTimkiemtheoma.Checked = true;
          //  MessageBox.Show(cmbGioitinh.SelectedItem.ToString());

        }
        void Loadsanpham()
        {
            string sqlsanpham = @"select sp.Masanpham as 'Mã Sản Phẩm', sp.Tensanpham as 'Tên Sản Phẩm', sp.Giaban as 'Giá Bán', sp.Soluong as 'Số Lượng', sp.Donvi as 'Đơn Vị Tính'
                                  from SANPHAM sp";
            DataTable dtsanpham = DataProvider.LoadCSDL(sqlsanpham);
            dgvSanpham.DataSource = dtsanpham;
            dgvSanpham.Columns[1].Width = 125;
        }
        void Loadnhanvien()
        {
            string sqlnhanvien = @"select * from NHANVIEN";
            DataTable dtnhanvien = DataProvider.LoadCSDL(sqlnhanvien);
            cmbTennhanvien.DataSource = dtnhanvien;
            cmbTennhanvien.DisplayMember = "Tennhanvien";
            cmbTennhanvien.ValueMember = "Manhanvien";
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (dgvSanpham.Rows.Count > 0)
            {
                int chisodongdangchon = dgvSanpham.CurrentCell.RowIndex;
                string sqlsanpham = @"select sp.Masanpham, sp.Tensanpham, sp.Giaban, sp.Soluong from SANPHAM sp";
                DataTable dtsanpham = DataProvider.LoadCSDL(sqlsanpham);
                int demsanpham = dtsanpham.Rows.Count;
                for (int i = 0; i < demsanpham; i++)
                {
                    if (dgvSanpham.Rows[chisodongdangchon].Cells[0].Value.ToString() == dtsanpham.Rows[i][0].ToString())
                    {
                        int kiemtratrungma = 1;
                        for (int j = 0; j < dgvMathangban.Rows.Count; j++)
                        {
                            
                            if (dgvSanpham.Rows[chisodongdangchon].Cells[0].Value.ToString() == dgvMathangban.Rows[j].Cells["ColumMasanpham"].Value.ToString())
                            {
                                kiemtratrungma = 0;
                                break;
                            }
                        }
                        if (kiemtratrungma == 1)
                        {
                            dgvMathangban.Rows.Add(dtsanpham.Rows[i][0].ToString(), dtsanpham.Rows[i][1].ToString(), dtsanpham.Rows[i][2].ToString(), dtsanpham.Rows[i][3].ToString());
                            break;
                        }
                    }
                }
            }
        }

        private void btnTinhtoan_Click(object sender, EventArgs e)
        {
            if (dgvMathangban.Rows.Count > 0)
            {
                bool kiemtranhaplieu = true;
                int dem = dgvMathangban.Rows.Count;
                for (int i = 0; i < dem; i++)
                {
                    if (dgvMathangban.Rows[i].Cells["ColumSoluongban"].Value == null)
                    {
                        MessageBox.Show("Chưa nhập số lượng bán cho mặt hàng có tên " + dgvMathangban.Rows[i].Cells["ColumTensanpham"].Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        kiemtranhaplieu = false;
                        break;
                    }
                }
                bool kiemtranhaplieu2 = true;
                if (kiemtranhaplieu == true)
                {
                    for (int i = 0; i < dem; i++)
                    {
                        try
                        {
                            int soluongban = int.Parse(dgvMathangban.Rows[i].Cells["ColumSoluongban"].Value.ToString());
                            if (soluongban > int.Parse(dgvMathangban.Rows[i].Cells["ColumSoluongton"].Value.ToString()) || soluongban <= 0)
                            {
                                MessageBox.Show("Số lượng bán của mặt hàng " + dgvMathangban.Rows[i].Cells["ColumTensanpham"].Value.ToString() + " không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                kiemtranhaplieu2 = false;
                                break;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Số lượng bán của mặt hàng " + dgvMathangban.Rows[i].Cells["ColumTensanpham"].Value.ToString() + " không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            kiemtranhaplieu2 = false;
                            break;
                        }
                    }
                    if (kiemtranhaplieu2 == true)
                    {
                        float tongtien = 0;
                        for (int i = 0; i < dgvMathangban.Rows.Count; i++)
                        {
                            dgvMathangban.Rows[i].Cells["ColumThanhtien"].Value = (int.Parse(dgvMathangban.Rows[i].Cells["ColumSoluongban"].Value.ToString()) * float.Parse(dgvMathangban.Rows[i].Cells["ColumGiaban"].Value.ToString())).ToString();
                            tongtien += float.Parse(dgvMathangban.Rows[i].Cells["ColumThanhtien"].Value.ToString());
                        }
                        txtTongtienthanhtoan.Text = tongtien.ToString();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMathangban.Rows.Count > 0)
            {
                int chisodongdangchon = dgvMathangban.CurrentCell.RowIndex;
                dgvMathangban.Rows.RemoveAt(chisodongdangchon);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvMathangban.Rows.Count > 0)
            {
                dgvMathangban.Rows.Clear();
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (dgvMathangban.Rows.Count > 0)
            {
                bool kiemtranhaplieu = true;
                if (txtMahoadon.Text == "")
                {
                    MessageBox.Show("Chưa Nhập Mã Hóa Đơn");
                    kiemtranhaplieu = false;
                    txtMahoadon.Focus();
                }
                else if (txtMakhachhang.Text == "")
                {
                    MessageBox.Show("Chưa Nhập Mã Khách Hàng");
                    kiemtranhaplieu = false;
                    txtMakhachhang.Focus();
                }
                else if (txtTenkhachhang.Text == "")
                {
                    MessageBox.Show("Chưa Nhập Tên Khách Hàng");
                    kiemtranhaplieu = false;
                    txtTenkhachhang.Focus();
                }
                else if (txtDiachi.Text == "")
                {
                    MessageBox.Show("Chưa Nhập Địa Chỉ Khách Hàng");
                    kiemtranhaplieu = false;
                    txtDiachi.Focus();
                }
                else if (txtSodienthoai.Text == "")
                {
                    MessageBox.Show("Chưa Nhập Số Điện Thoại");
                    kiemtranhaplieu = false;
                    txtSodienthoai.Focus();
                }
                else if (txtTienkhachdua.Text == "")
                {
                    MessageBox.Show("Chưa Nhập Tiền Khách Đưa");
                    kiemtranhaplieu = false;
                    txtTienkhachdua.Focus();
                }
                bool kiemtranghiepvu = true;
                if (kiemtranhaplieu == true)
                {
                    string sqlhoadon = @"select * from HOADON";
                    DataTable dthoadon = DataProvider.LoadCSDL(sqlhoadon);
                    int demhoadon = dthoadon.Rows.Count;
                    for (int i = 0; i < demhoadon; i++)
                    {
                        if (txtMahoadon.Text == dthoadon.Rows[i][0].ToString())
                        {
                            MessageBox.Show("Mã Hóa Đơn Đã Bị Trùng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            kiemtranghiepvu = false;
                            break;
                        }
                    }
                    string sqlkhachhang = @"select * from KHACHHANG";
                    DataTable dtkhachhang = DataProvider.LoadCSDL(sqlkhachhang);
                    int demkhachhang = dtkhachhang.Rows.Count;
                    for (int i = 0; i < demkhachhang; i++)
                    {
                        if (txtMakhachhang.Text == dtkhachhang.Rows[i][0].ToString())
                        {
                            MessageBox.Show("Mã Khách Hàng Đã Bị Trùng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            kiemtranghiepvu = false;
                            break;
                        }
                    }
                    if (kiemtranghiepvu == true)
                    {
                        if (float.Parse(txtTienkhachdua.Text) < float.Parse(txtTongtienthanhtoan.Text))
                        {
                            MessageBox.Show("Khách Đưa Thiếu Tiền. Số Tiền Thiếu Là " + (float.Parse(txtTongtienthanhtoan.Text) - float.Parse(txtTienkhachdua.Text)).ToString());
                            txtTienkhachdua.Focus();
                        }
                        else
                        {
                            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thanh Toán Các Mặt Hàng Này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                bool themkhachhang = true;
                                try
                                {
                                    string sqlthemkhachhang = @"insert into KHACHHANG(Makhachhang, Tenkhachhang, Gioitinh,Ngaysinh,Diachi,Sodienthoai) 
                                                        values('" + int.Parse(txtMakhachhang.Text) + "', N'" + txtTenkhachhang.Text + "', N'" + cmbGioitinh.SelectedItem.ToString() + "', '" + dtpNgaysinh.Value + "', N'" + txtDiachi.Text + "', '" + txtSodienthoai.Text + "')";
                                    int ketquathemkhachang = DataProvider.change(sqlthemkhachhang);
                                    if (ketquathemkhachang < 0)
                                    {
                                        MessageBox.Show("Thêm Khách Hàng Thất Bại");
                                        themkhachhang = false;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Thêm Khách Hàng Thất Bại");
                                    themkhachhang = false;
                                }
                                bool themhoadon = true;
                                if (themkhachhang == true)
                                {
                                    try
                                    {
                                        string sqlthemhoadon = @"insert into HOADON(Mahoadon,Makhachhang,Manhanvien,Ngayban) 
                                                             values('" + int.Parse(txtMahoadon.Text) + "', '" + int.Parse(txtMakhachhang.Text) + "', '" + int.Parse(cmbTennhanvien.SelectedValue.ToString()) + "', '" + dtpNgayban.Value + "')";
                                        int ketquathemhoadon = DataProvider.change(sqlthemhoadon);
                                        if (ketquathemhoadon < 0)
                                        {
                                            MessageBox.Show("Thêm Hóa Đơn Thất Bại");
                                            themhoadon = false;

                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Thêm Hóa Đơn Thất Bại");
                                        themhoadon = false;
                                    }
                                    if (themhoadon == true)
                                    {
                                        bool kiemtracuoicung = true;
                                        for (int i = 0; i < dgvMathangban.Rows.Count; i++)
                                        {
                                            try
                                            {
                                                string sqlthemchitiethoadon = @"insert into CHITIETHOADON(Mahoadon,Masanpham,Soluongban,Thanhtien)
                                                                        values('" + int.Parse(txtMahoadon.Text) + "', '" + int.Parse(dgvMathangban.Rows[i].Cells["ColumMasanpham"].Value.ToString()) + "', '" + int.Parse(dgvMathangban.Rows[i].Cells["ColumSoluongban"].Value.ToString()) + "', '" + float.Parse(dgvMathangban.Rows[i].Cells["ColumThanhtien"].Value.ToString()) + "')";
                                                int kequathemchitiethoadon = DataProvider.change(sqlthemchitiethoadon);
                                                if (kequathemchitiethoadon < 0)
                                                {
                                                    MessageBox.Show("Thêm Chi Tiết Hóa Đơn Thất Bại");
                                                    kiemtracuoicung = false;
                                                    break;
                                                }
                                            }
                                            catch
                                            {
                                                MessageBox.Show("Thêm Chi Tiết Hóa Đơn Thất Bại");
                                                kiemtracuoicung = false;
                                                break;
                                            }
                                        }
                                        if (kiemtracuoicung == true)
                                        {
                                            Loadsanpham();
                                            txtTienthua.Text = (float.Parse(txtTienkhachdua.Text) - float.Parse(txtTongtienthanhtoan.Text)).ToString();
                                            MessageBox.Show("Thanh Toán Thành Công. Tiền Thừa Trả Lại Khách " + txtTienthua.Text + " VNĐ", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            for (int i = 0; i < dgvMathangban.Rows.Count; i++)
                                            {
                                                string sqlcapnhatsoluongton = @"update SANPHAM
                                                                                set Soluong = '" + (int.Parse(dgvMathangban.Rows[i].Cells["ColumSoluongton"].Value.ToString()) - int.Parse(dgvMathangban.Rows[i].Cells["ColumSoluongban"].Value.ToString())) + "' where SANPHAM.Masanpham ='" + int.Parse(dgvMathangban.Rows[i].Cells["ColumMasanpham"].Value.ToString()) + "' ";
                                                int kequa = DataProvider.change(sqlcapnhatsoluongton);
                                                if (kequa > 0 && (int.Parse(dgvMathangban.Rows[i].Cells["ColumSoluongton"].Value.ToString()) - int.Parse(dgvMathangban.Rows[i].Cells["ColumSoluongban"].Value.ToString()) < 10))
                                                {
                                                    MessageBox.Show("Số lượng mặt hàng " + dgvMathangban.Rows[i].Cells["ColumTensanpham"].Value.ToString() + " sắp hết. Xin nhập thêm hàng về");
                                                }
                                            }
                                            dgvMathangban.Rows.Clear();
                                            Hoantac();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Thanh Toán Thất Bại", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thanh Toán Thất Bại", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Thanh Toán Thất Bại", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
        }
        void Hoantac()
        {
            txtMahoadon.Text = "";
            txtMakhachhang.Text = "";
            txtTenkhachhang.Text = "";
            txtDiachi.Text = "";
            txtSodienthoai.Text = "";
            txtTienkhachdua.Text = "";
        }
        private void txtMahoadon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtMakhachhang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTienkhachdua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnMahoadon_Click(object sender, EventArgs e)
        {
            string sqlhoadon = @"select * from HOADON";
            DataTable dthoadon = DataProvider.LoadCSDL(sqlhoadon);
            int demhoadon = dthoadon.Rows.Count;
            if (demhoadon == 0)
            {
                txtMahoadon.Text = "1"; 
            }
            else if (demhoadon == 1)
            {
                txtMahoadon.Text = "2";
            }
            else
            {
                int kiemtrama = 1;
                for (int i = 0; i < demhoadon - 1; i++)
                {
                    if ((int.Parse(dthoadon.Rows[i + 1][0].ToString()) - int.Parse(dthoadon.Rows[i][0].ToString())) >= 2)
                    {
                        txtMahoadon.Text = (int.Parse(dthoadon.Rows[i][0].ToString()) + 1).ToString();
                        kiemtrama = 0;
                        break;
                    }
                }
                if (kiemtrama == 1)
                {
                    txtMahoadon.Text = (demhoadon + 1).ToString();
                }
            }
        }

        private void btnMakhachhang_Click(object sender, EventArgs e)
        {
            string sqlkhachhang = @"select * from KHACHHANG";
            DataTable dtkhachhang = DataProvider.LoadCSDL(sqlkhachhang);
            int demkhachhang = dtkhachhang.Rows.Count;
            if (demkhachhang == 0)
            {
                txtMakhachhang.Text = "1";
            }
            else if (demkhachhang == 1)
            {
                txtMakhachhang.Text = "2";
            }
            else
            {
                int kiemtrama = 1;
                for (int i = 0; i < demkhachhang - 1; i++)
                {
                    if ((int.Parse(dtkhachhang.Rows[i + 1][0].ToString()) - int.Parse(dtkhachhang.Rows[i][0].ToString())) >= 2)
                    {
                        txtMakhachhang.Text = (int.Parse(dtkhachhang.Rows[i][0].ToString()) + 1).ToString();
                        kiemtrama = 0;
                        break;
                    }
                }
                if (kiemtrama == 1)
                {
                    txtMakhachhang.Text = (demkhachhang + 1).ToString();
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            int demsanpham = dgvSanpham.Rows.Count;
            if (rdbTimkiemtheoma.Checked == true)
            {
                for (int i = 0; i < demsanpham; i++)
                {
                    if (txtDulieutimkiem.Text.Trim() == dgvSanpham.Rows[i].Cells[0].Value.ToString().Trim())
                    {
                        dgvSanpham.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        break;
                    }
                }
            }
            else if (rdbTimkiemtheoten.Checked == true)
            {
                for (int i = 0; i < demsanpham; i++)
                {
                    if (txtDulieutimkiem.Text.ToLower().Trim() == dgvSanpham.Rows[i].Cells[1].Value.ToString().ToLower())
                    {
                        dgvSanpham.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        break;
                    }
                }
            }
        }

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chisodongdangchon = dgvSanpham.CurrentCell.RowIndex;
            dgvSanpham.Rows[chisodongdangchon].DefaultCellStyle.BackColor = Color.White;
        }

        private void btnDanhsachhoadon_Click(object sender, EventArgs e)
        {
            FormDanhsachhoadon frm = new FormDanhsachhoadon();
            frm.ShowDialog();
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            string sqlhoadon = @"select hd.Mahoadon,kh.Tenkhachhang,nv.Tennhanvien, hd.Ngayban, sp.Tensanpham,ct.Thanhtien,kh.Makhachhang
                                 from HOADON hd,KHACHHANG kh,NHANVIEN nv,  CHITIETHOADON ct, SANPHAM sp
                                 where hd.Makhachhang = kh.Makhachhang and nv.Manhanvien = hd.Manhanvien and ct.Mahoadon = hd.Mahoadon and sp.Masanpham = ct.Masanpham";
            DataTable dthoadon = DataProvider.LoadCSDL(sqlhoadon);
            int demhoadon = dthoadon.Rows.Count;
            string mahoadon = "";
            string Mahoadon = "";
            string Tenkhachhang = "";
            string Tennhanvien = "";
            string Ngayban = "";
            float Tongtien = 0;
            for (int i = demhoadon - 1; i >= 0; i--)
            {
                mahoadon = dthoadon.Rows[i][0].ToString();
                Mahoadon = mahoadon;
                Tenkhachhang = dthoadon.Rows[i][1].ToString();
                Tennhanvien = dthoadon.Rows[i][2].ToString();
                Ngayban = dthoadon.Rows[i][3].ToString();

                for (int j = 0; j < Ngayban.Length; j++)
                {
                    if (Ngayban[j] == ' ')
                    {
                        Ngayban = Ngayban.Substring(0, j).Trim();
                        break;
                    }
                }
                break;
            }
            for (int i = demhoadon - 1; i >= 0; i--)
            {
                if (dthoadon.Rows[i][0].ToString() == mahoadon)
                {
                    Tongtien += float.Parse(dthoadon.Rows[i][5].ToString());
                }
                else
                {
                    break;
                }
            }
            FormInhoadonhientai frm = new FormInhoadonhientai();
            frm.Mahoadon = Mahoadon;
            frm.Tenkhachhang = Tenkhachhang;
            frm.Tennhanvien = Tennhanvien;
            frm.Ngayban = Ngayban;
            frm.Tongtien = Tongtien.ToString() + " VNĐ";
            frm.ShowDialog();
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            FormTrangChu frm = new FormTrangChu();
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

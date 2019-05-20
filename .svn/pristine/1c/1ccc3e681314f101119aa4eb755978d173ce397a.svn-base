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
    public partial class FormQuanlynguoidung : Form
    {
        public FormQuanlynguoidung()
        {
            InitializeComponent();
        }

        private void FormQuanlynguoidung_Load(object sender, EventArgs e)
        {
            Loadnguoidung();
            dgvDangnhap.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           // dgvDangnhap.CurrentCell.Selected = false;
           // MessageBox.Show(dgvDangnhap.CurrentCell.RowIndex.ToString());
        }
        void Loadnguoidung()
        {
            string sqlnguoidung = @"select nd.Manhanvien,nv.Tennhanvien,nd.Quyenhan,nd.Tendangnhap,nd.Matkhau
                                   from DANGNHAP nd, NHANVIEN nv where nv.Manhanvien = nd.Manhanvien";
            DataTable dtnguoidung = DataProvider.LoadCSDL(sqlnguoidung);
            dgvDangnhap.DataSource = dtnguoidung;
            txtManhanvien.Text = "";
            txtQuyenhan.Text = "";
            txtTendangnhap.Text = "";
            txtMatkhau.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool kiemtranhaplieu = true;
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Chưa Nhập Mã Nhân Viên");
                kiemtranhaplieu = false;
                txtManhanvien.Focus();
            }
            else if (txtQuyenhan.Text == "")
            {
                MessageBox.Show("Chưa Nhập Quyền Hạn");
                kiemtranhaplieu = false;
                txtQuyenhan.Focus();
            }
            else if (txtTendangnhap.Text == "")
            {
                MessageBox.Show("Chưa Nhập Tên Đăng Nhập");
                kiemtranhaplieu = false;
                txtTendangnhap.Focus();
            }
            else if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Chưa Nhập Mật Khẩu");
                kiemtranhaplieu = false;
                txtMatkhau.Focus();
            }
            if (kiemtranhaplieu == true)
            {
                bool kiemtratontaima = false;
                string sqlnhanvien = @"select * from NHANVIEN";
                DataTable dtnhanvien = DataProvider.LoadCSDL(sqlnhanvien);
                int demnhanvien = dtnhanvien.Rows.Count;
                for (int i = 0; i < demnhanvien; i++)
                {
                    if (txtManhanvien.Text == dtnhanvien.Rows[i][0].ToString())
                    {
                        kiemtratontaima = true;
                        break;
                    }
                }
                if (kiemtratontaima == false)
                {
                    MessageBox.Show("Không Tồn Tại Nhân Viên Có Mã Số " + txtManhanvien.Text + " Để Cấp Tài Khoản Đăng Nhập!", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    bool kiemtratontaitaikhoan = true;
                    string sqldangnhap = @"select * from DANGNHAP";
                    DataTable dtdangnhap = DataProvider.LoadCSDL(sqldangnhap);
                    int demdangnhap = dtdangnhap.Rows.Count;
                    for (int i = 0; i < demdangnhap; i++)
                    {
                        if (txtManhanvien.Text == dtdangnhap.Rows[i][0].ToString())
                        {
                            MessageBox.Show("Nhân Viên Mang Mã Số " + dtdangnhap.Rows[i][0].ToString() + " Đã Có Tài Khoản Đăng Nhập!. Vui Lòng Kiểm Tra Lại.", "Lỗi Tài Khoản", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            kiemtratontaitaikhoan = false;
                            break;
                        }                        
                    }
                    if (kiemtratontaitaikhoan == true)
                    {
                        if (MessageBox.Show("Xác Nhận Thêm Tài Khoản Người Dùng Mới?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                string sqlthemtaikhoan = @"insert into DANGNHAP(Manhanvien,Quyenhan,Tendangnhap,Matkhau)
                                                        values('" + int.Parse(txtManhanvien.Text) + "', N'" + txtQuyenhan.Text + "', '" + txtTendangnhap.Text + "', '" + txtMatkhau.Text + "')";
                                int ketquathem = DataProvider.change(sqlthemtaikhoan);
                                if (ketquathem > 0)
                                {
                                    Loadnguoidung();
                                    MessageBox.Show("Thêm Mới Tài Khoản Thành Công", "Thêm Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Thêm Tài Khoản Thất Bại", "Thất Bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Thêm Tài Khoản Thất Bại", "Thất Bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDangnhap.Rows.Count > 0)
            {
                int chisodongdangchon = dgvDangnhap.CurrentCell.RowIndex;
                bool kiemtrangiepvu = true;
                string sql = @"select dn.Manhanvien,nv.Tennhanvien,dn.Tendangnhap, dn.Quyenhan,dn.Matkhau from DANGNHAP dn, NHANVIEN nv where nv.Manhanvien = dn.Manhanvien";
                DataTable dt = DataProvider.LoadCSDL(sql);
                int dem = dt.Rows.Count;
                for (int i = 0; i < dem; i++)
                {
                    if (dgvDangnhap.Rows[chisodongdangchon].Cells["ColumTennhanvien"].Value.ToString() == dt.Rows[i][1].ToString())
                    {
                        if (dgvDangnhap.Rows[chisodongdangchon].Cells["ColumManhanvien"].Value.ToString() != dt.Rows[i][0].ToString())
                        {
                            kiemtrangiepvu = false;
                            break;
                        }
                    }
                }
                if (kiemtrangiepvu == false)
                {
                    MessageBox.Show("Mã Nhân Viên Hoặc Tên Nhân Viên Không Được Phép Thay Đổi !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Loadnguoidung();
                }
                else
                {
                    bool kiemtranghiepvu2 = true;
                    if (dgvDangnhap.Rows[chisodongdangchon].Cells["ColumQuyenhan"].Value == null)
                    {
                        MessageBox.Show("Chưa Nhập Quyền Hạn");
                        kiemtranghiepvu2 = false;
                    }
                    else if (dgvDangnhap.Rows[chisodongdangchon].Cells["ColumTendangnhap"].Value == null)
                    {
                        MessageBox.Show("Chưa Nhập Tên Đăng Nhập");
                        kiemtranghiepvu2 = false;
                    }
                    else if (dgvDangnhap.Rows[chisodongdangchon].Cells["ColumMatkhau"].Value == null)
                    {
                        MessageBox.Show("Chưa Nhập Mật Khẩu");
                        kiemtranghiepvu2 = false;
                    }
                    if (kiemtranghiepvu2 == true)
                    {
                        if (MessageBox.Show("Xác Nhận Cập Nhật Lại Thông Tin Đăng Nhập Cho Nhân Viên Có Tên " + dgvDangnhap.Rows[chisodongdangchon].Cells["ColumTennhanvien"].Value.ToString() + " ?", "Cập Nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                string sqlsua = @"update DANGNHAP set Quyenhan = N'" + dgvDangnhap.Rows[chisodongdangchon].Cells["ColumQuyenhan"].Value.ToString() + "',Tendangnhap = N'" + dgvDangnhap.Rows[chisodongdangchon].Cells["ColumTendangnhap"].Value.ToString() + "',Matkhau =  '" + dgvDangnhap.Rows[chisodongdangchon].Cells["ColumMatkhau"].Value.ToString() + "' where DANGNHAP.Manhanvien = '" + int.Parse(dgvDangnhap.Rows[chisodongdangchon].Cells["ColumManhanvien"].Value.ToString()) + "'";
                                int ketquasua = DataProvider.change(sqlsua);
                                if (ketquasua > 0)
                                {
                                    Loadnguoidung();
                                    MessageBox.Show("Cập Nhật Thông Tin Đăng Nhập Thành Công", "Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Cập Nhật Thất Bại");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Cập Nhật Thất Bại");
                            }
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDangnhap.Rows.Count > 0)
            {
                int chisodongdangchon = dgvDangnhap.CurrentCell.RowIndex;
                if (MessageBox.Show("Xác Nhận Xóa Thông Tin Tài Khoản Người Dùng Có Tên " + dgvDangnhap.Rows[chisodongdangchon].Cells["ColumTennhanvien"].Value.ToString() + "?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string sqlxoataikhoan = @"delete from DANGNHAP where DANGNHAP.Manhanvien = '"+int.Parse(dgvDangnhap.Rows[chisodongdangchon].Cells["ColumManhanvien"].Value.ToString())+"'";
                        int ketquaxoa = DataProvider.change(sqlxoataikhoan);
                        if (ketquaxoa > 0)
                        {
                            Loadnguoidung();
                            MessageBox.Show("Xóa Tài Khoản Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa Tài Khoản Thất Bại", "Thất Bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Xóa Tài Khoản Thất Bại", "Thất Bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtManhanvien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnManhanvien_Click(object sender, EventArgs e)
        {
            string sqlnhanvien = @"select nv.Manhanvien from NHANVIEN nv";
            DataTable dtnhanvien = DataProvider.LoadCSDL(sqlnhanvien);
            int demnhanvien = dtnhanvien.Rows.Count;
            List<string> lstnhanvien = new List<string>();
            for (int i = 0; i < demnhanvien; i++)
            {
                lstnhanvien.Add(dtnhanvien.Rows[i][0].ToString());
            }

            string sqlnguoidung = @"select dn.Manhanvien from DANGNHAP dn";
            DataTable dtdangnhap = DataProvider.LoadCSDL(sqlnguoidung);
            int demnguoidung = dtdangnhap.Rows.Count;
            for (int i = 0; i < demnguoidung; i++)
            {
                for (int j = 0; j < lstnhanvien.Count; j++)
                {
                    if (dtdangnhap.Rows[i][0].ToString() == lstnhanvien[j])
                    {
                        lstnhanvien.RemoveAt(j);
                        break;
                    }
                }
            }
            if (lstnhanvien.Count == 0)
            {
                MessageBox.Show("Tất Cả Các Nhân Viên Đều Đã Có Tài Khoản Đăng Nhập. Bạn Sẽ Không Thể Thêm Được Tài Khoản Đăng Nhập Mới !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FormNhanvienchuacotaikhoan frm = new FormNhanvienchuacotaikhoan();
                frm.lstnhanvien = lstnhanvien;
                frm.ShowDialog();
            }
        }

        private void dgvDangnhap_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDangnhap.ClearSelection();
        }
    }
}

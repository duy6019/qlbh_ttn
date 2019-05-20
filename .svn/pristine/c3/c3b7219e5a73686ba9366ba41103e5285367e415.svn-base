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
    public partial class FormLoaisanpham : Form
    {
        public FormLoaisanpham()
        {
            InitializeComponent();
        }

        private void FormLoaisanpham_Load(object sender, EventArgs e)
        {
            Loadloaisanpham();
            dgvLoaisanpham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        void Loadloaisanpham()
        {
            string sqlloaisanpham = @"select * from LOAISANPHAM";
            DataTable dtloaisanpham = DataProvider.LoadCSDL(sqlloaisanpham);
            dgvLoaisanpham.DataSource = dtloaisanpham;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvLoaisanpham.Rows.Count > 0)
            {
                string sql = @"select * from LOAISANPHAM";
                DataTable dt = DataProvider.LoadCSDL(sql);
                bool kiemtranhaplieu = true;
                int sodong = dgvLoaisanpham.Rows.Count - 1;
                // MessageBox.Show(sodong.ToString());
                int chisodongdangchon = dgvLoaisanpham.CurrentCell.RowIndex;
                if (chisodongdangchon >= dt.Rows.Count)
                {
                    if (dgvLoaisanpham.Rows[sodong - 1].Cells["ColumMaloai"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Mã Loại");
                        kiemtranhaplieu = false;
                    }
                    else if (dgvLoaisanpham.Rows[sodong - 1].Cells["ColumTenloai"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Tên Loại");
                        kiemtranhaplieu = false;
                    }
                    int kiemtramaloai = 1;
                    if (kiemtranhaplieu == true)
                    {
                        for (int i = 0; i < sodong - 1; i++)
                        {
                            if (dgvLoaisanpham.Rows[i].Cells["ColumMaloai"].Value.ToString() == dgvLoaisanpham.Rows[sodong - 1].Cells["ColumMaloai"].Value.ToString())
                            {
                                MessageBox.Show("Mã Loại Đã Bị Trùng");
                                kiemtramaloai = 0;
                                break;
                            }
                        }
                        try
                        {
                            int maloai = int.Parse(dgvLoaisanpham.Rows[sodong - 1].Cells["ColumMaloai"].Value.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("Mã Loại Không Hợp Lệ");
                            kiemtramaloai = 0;
                        }
                        if (kiemtramaloai == 1)
                        {
                            if (MessageBox.Show("Xác Nhận Thêm Loại Sản Phẩm?", "Thêm Loại Sản Phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {
                                    string sqlthemloaisanpham = @"insert into LOAISANPHAM(Maloai, Tenloai)
                                               values('" + int.Parse(dgvLoaisanpham.Rows[sodong - 1].Cells["ColumMaloai"].Value.ToString()) + "', N'" + dgvLoaisanpham.Rows[sodong - 1].Cells["ColumTenloai"].Value.ToString() + "')";
                                    int ketqua = DataProvider.change(sqlthemloaisanpham);
                                    if (ketqua > 0)
                                    {
                                        Loadloaisanpham();
                                        MessageBox.Show("Thêm Loại Sản Phẩm Thành Công", "Thêm Loại Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm Loại Sản Phẩm Thất Bại");
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Thêm Loại Sản Phẩm Thất Bại");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLoaisanpham.Rows.Count > 0)
            {
                int chisodongdangchon = dgvLoaisanpham.CurrentCell.RowIndex;
                bool kiemtrangiepvu = true;
                string sqlloaisanpham = @"select * from LOAISANPHAM";
                DataTable dtloaisanpham = DataProvider.LoadCSDL(sqlloaisanpham);
                int demphongban = dtloaisanpham.Rows.Count;
                for (int i = 0; i < demphongban; i++)
                {
                    if (dgvLoaisanpham.Rows[chisodongdangchon].Cells["ColumTenloai"].Value.ToString() == dtloaisanpham.Rows[i][1].ToString())
                    {
                        if (dgvLoaisanpham.Rows[chisodongdangchon].Cells["ColumMaloai"].Value.ToString() != dtloaisanpham.Rows[i][0].ToString())
                        {
                            kiemtrangiepvu = false;
                            break;
                        }
                    }
                }
                if (kiemtrangiepvu == false)
                {
                    MessageBox.Show("Mã Loại Sản Phẩm Không Được Phép Thay Đổi !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Loadloaisanpham();
                }
                else
                {
                    bool kiemtranghiepvu2 = true;
                    if (dgvLoaisanpham.Rows[chisodongdangchon].Cells["ColumTenloai"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Tên Loại Sản Phẩm");
                        kiemtranghiepvu2 = false;
                    }
                    if (kiemtranghiepvu2 == true)
                    {
                        if (MessageBox.Show("Xác Nhận Cập Nhật Lại Thông Tin Loại Sản Phẩm Này ?", "Cập Nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                string sqlsua = @"update LOAISANPHAM set Tenloai = N'" + dgvLoaisanpham.Rows[chisodongdangchon].Cells["ColumTenloai"].Value.ToString() + "' where LOAISANPHAM.Maloai = '" + int.Parse(dgvLoaisanpham.Rows[chisodongdangchon].Cells["ColumMaloai"].Value.ToString()) + "'";
                                int ketquasua = DataProvider.change(sqlsua);
                                if (ketquasua > 0)
                                {
                                    Loadloaisanpham();
                                    MessageBox.Show("Cập Nhật Thông Tin Loại Sản Phẩm Thành Công", "Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Cập Nhật Thông Loại Sản Phẩm Thất Bại");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Cập Nhật Thông Tin Loại Sản Phẩm Thất Bại");
                            }
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLoaisanpham.Rows.Count > 0)
            {
                int chisodongdangchon = dgvLoaisanpham.CurrentCell.RowIndex;
                string sql = @"select sp.Masanpham,sp.Maloai from SANPHAM sp";
                DataTable dt = DataProvider.LoadCSDL(sql);
                int demsanpham = dt.Rows.Count;
                int kiemtramaloaisanpham = 1;
                string maso = "";
                for (int i = 0; i < demsanpham; i++)
                {
                    if (dgvLoaisanpham.Rows[chisodongdangchon].Cells["ColumMaloai"].Value.ToString() == dt.Rows[i][1].ToString())
                    {
                        kiemtramaloaisanpham = 0;
                        maso = dt.Rows[i][0].ToString();
                        break;
                    }
                }
                if (kiemtramaloaisanpham == 0)
                {
                    MessageBox.Show("Đang Tồn Tại Sản Phẩm Có Mã Số " + maso + " Thuộc Loại Sản Phẩm Này. Chỉ Có Thể Xóa Loại Sản Phẩm Nếu Không Tồn Tại Sản Phẩm Thuộc Loại Sản Phẩm Đó!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Xóa Loại Sản Phẩm Có Mã Số " + dgvLoaisanpham.Rows[chisodongdangchon].Cells["ColumMaloai"].Value.ToString() + " Ra Khỏi Danh Sách Loại Sản Phẩm Không ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            string sqlxoaloaisanpham = @"delete from LOAISANPHAM where LOAISANPHAM.Maloai = '" + int.Parse(dgvLoaisanpham.Rows[chisodongdangchon].Cells["ColumMaloai"].Value.ToString()) + "'";
                            int ketqua = DataProvider.change(sqlxoaloaisanpham);
                            if (ketqua > 0)
                            {
                                Loadloaisanpham();
                                MessageBox.Show("Xóa Loại Sản Phẩm Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Xóa Loại Sản Phẩm Thất Bại");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Xóa Loại Sản Phẩm Thất Bại");
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

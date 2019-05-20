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
    public partial class FormNhacungcap : Form
    {
        public FormNhacungcap()
        {
            InitializeComponent();
        }

        private void FormNhacungcap_Load(object sender, EventArgs e)
        {
            Loadnhacungcap();
            dgvNhacungcap.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        void Loadnhacungcap()
        {
            string sqlnhacungcap = @"select * from NHACUNGCAP";
            DataTable dtnhacungcap = DataProvider.LoadCSDL(sqlnhacungcap);
            dgvNhacungcap.DataSource = dtnhacungcap;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvNhacungcap.Rows.Count > 0)
            {
                string sql = @"select * from NHACUNGCAP";
                DataTable dt = DataProvider.LoadCSDL(sql);
                bool kiemtranhaplieu = true;
                int sodong = dgvNhacungcap.Rows.Count - 1;
                // MessageBox.Show(sodong.ToString());
                int chisodongdangchon = dgvNhacungcap.CurrentCell.RowIndex;
                if (chisodongdangchon >= dt.Rows.Count)
                {
                    if (dgvNhacungcap.Rows[sodong - 1].Cells["ColumManhacungcap"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Mã Nhà Cung Cấp");
                        kiemtranhaplieu = false;
                    }
                    else if (dgvNhacungcap.Rows[sodong - 1].Cells["ColumTennhacungcap"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Tên Nhà Cung Cấp");
                        kiemtranhaplieu = false;
                    }
                    else if (dgvNhacungcap.Rows[sodong - 1].Cells["ColumDiachinhacungcap"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Địa Chỉ Nhà Cung Cấp");
                        kiemtranhaplieu = false;
                    }
                    else if (dgvNhacungcap.Rows[sodong - 1].Cells["ColumSodienthoai"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Số Điện Thoại Nhà Cung Cấp");
                        kiemtranhaplieu = false;
                    }
                    int kiemtramanhacungcap = 1;
                    if (kiemtranhaplieu == true)
                    {
                        for (int i = 0; i < sodong - 1; i++)
                        {
                            if (dgvNhacungcap.Rows[i].Cells["ColumManhacungcap"].Value.ToString() == dgvNhacungcap.Rows[sodong - 1].Cells["ColumManhacungcap"].Value.ToString())
                            {
                                MessageBox.Show("Mã Nhà Cung Cấp Đã Bị Trùng");
                                kiemtramanhacungcap = 0;
                                break;
                            }
                        }

                        try
                        {
                            int manhacungcap = int.Parse(dgvNhacungcap.Rows[sodong - 1].Cells["ColumManhacungcap"].Value.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("Mã Nhà Cung Cấp Không Hợp Lệ");
                            kiemtramanhacungcap = 0;
                        }

                        try
                        {
                            int sodienthoai = int.Parse(dgvNhacungcap.Rows[sodong - 1].Cells["ColumSodienthoai"].Value.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("Số Điện Thoại Nhà Cung Cấp Không Hợp Lệ");
                            kiemtramanhacungcap = 0;
                        }
                        if (kiemtramanhacungcap == 1)
                        {
                            if (MessageBox.Show("Xác Nhận Thêm Nhà Cung Cấp?", "Thêm Nhà Cung Cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {
                                    string sqlthemnhacungcap = @"insert into NHACUNGCAP(Manhacungcap, Tennhacungcap, Diachinhacungcap,Sodienthoainhacungcap)
                                               values('" + int.Parse(dgvNhacungcap.Rows[sodong - 1].Cells["ColumManhacungcap"].Value.ToString()) + "', N'" + dgvNhacungcap.Rows[sodong - 1].Cells["ColumTennhacungcap"].Value.ToString() + "', N'" + dgvNhacungcap.Rows[sodong - 1].Cells["ColumDiachinhacungcap"].Value.ToString() + "', '" + dgvNhacungcap.Rows[sodong - 1].Cells["ColumSodienthoai"].Value.ToString() + "')";
                                    int ketqua = DataProvider.change(sqlthemnhacungcap);
                                    if (ketqua > 0)
                                    {
                                        Loadnhacungcap();
                                        MessageBox.Show("Thêm Nhà Cung Cấp Thành Công", "Thêm Nhà Cung Cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm Nhà Cung Cấp Thất Bại");
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Thêm Nhà Cung Cấp Thất Bại");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhacungcap.Rows.Count > 0)
            {
                int chisodongdangchon = dgvNhacungcap.CurrentCell.RowIndex;
                bool kiemtrangiepvu = true;
                string sqlnhacungcap = @"select * from NHACUNGCAP";
                DataTable dtnhacungcap = DataProvider.LoadCSDL(sqlnhacungcap);
                int demnhacungcap = dtnhacungcap.Rows.Count;
                for (int i = 0; i < demnhacungcap; i++)
                {
                    if (dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumTennhacungcap"].Value.ToString() == dtnhacungcap.Rows[i][1].ToString())
                    {
                        if (dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumManhacungcap"].Value.ToString() != dtnhacungcap.Rows[i][0].ToString())
                        {
                            kiemtrangiepvu = false;
                            break;
                        }
                    }
                }
                if (kiemtrangiepvu == false)
                {
                    MessageBox.Show("Mã Nhà Cung Cấp Không Được Phép Thay Đổi !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Loadnhacungcap();
                }
                else
                {
                    bool kiemtranghiepvu2 = true;
                    if (dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumTennhacungcap"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Tên Nhà Cung Cấp");
                        kiemtranghiepvu2 = false;
                    }
                    else if (dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumDiachinhacungcap"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Địa Chỉ Nhà Cung Cấp");
                        kiemtranghiepvu2 = false;
                    }
                    else if (dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumSodienthoai"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Số Điện Thoại Nhà Cung Cấp");
                        kiemtranghiepvu2 = false;
                    }
                    else
                    {
                        try
                        {
                            int sodienthoai = int.Parse(dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumSodienthoai"].Value.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("Số Điện Thoại Nhà Cung Cấp Không Hợp Lệ");
                            kiemtranghiepvu2 = false;
                        }
                    }
                    if (kiemtranghiepvu2 == true)
                    {
                        if (MessageBox.Show("Xác Nhận Cập Nhật Lại Thông Tin Cho Nhà Cung Cấp Này ?", "Cập Nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                string sqlsua = @"update NHACUNGCAP set Tennhacungcap = N'" + dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumTennhacungcap"].Value.ToString() + "', Diachinhacungcap = N'" + dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumDiachinhacungcap"].Value.ToString() + "', Sodienthoainhacungcap = '" + dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumSodienthoai"].Value.ToString() + "' where NHACUNGCAP.Manhacungcap = '" + int.Parse(dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumManhacungcap"].Value.ToString()) + "'";
                                int ketquasua = DataProvider.change(sqlsua);
                                if (ketquasua > 0)
                                {
                                    Loadnhacungcap();
                                    MessageBox.Show("Cập Nhật Thông Tin Nhà Cung Cấp Thành Công", "Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Cập Nhật Thông Nhà Cung Cấp Thất Bại");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Cập Nhật Thông Tin Nhà Cung Cấp Thất Bại");
                            }
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhacungcap.Rows.Count > 0)
            {
                int chisodongdangchon = dgvNhacungcap.CurrentCell.RowIndex;
                string sql = @"select sp.Masanpham,sp.Manhacungcap from SANPHAM sp";
                DataTable dt = DataProvider.LoadCSDL(sql);
                int demsanpham = dt.Rows.Count;
                int kiemtramanhacungcap = 1;
                string maso = "";
                for (int i = 0; i < demsanpham; i++)
                {
                    if (dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumManhacungcap"].Value.ToString() == dt.Rows[i][1].ToString())
                    {
                        kiemtramanhacungcap = 0;
                        maso = dt.Rows[i][0].ToString();
                        break;
                    }
                }
                if (kiemtramanhacungcap == 0)
                {
                    MessageBox.Show("Đang Tồn Tại Sản Phẩm Có Mã Số " + maso + " Thuộc Nhà Cung Cấp Này. Chỉ Có Thể Xóa Loại Sản Phẩm Nếu Không Tồn Tại Sản Phẩm Thuộc Nhà Cung Cấp Đó!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Xóa Nhà Cung Cấp Có Mã Số " + dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumManhacungcap"].Value.ToString() + " Ra Khỏi Danh Sách Nhà Cung Cấp Không ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            string sqlxoanhacungcap = @"delete from NHACUNGCAP where NHACUNGCAP.Manhacungcap = '" + int.Parse(dgvNhacungcap.Rows[chisodongdangchon].Cells["ColumManhacungcap"].Value.ToString()) + "'";
                            int ketqua = DataProvider.change(sqlxoanhacungcap);
                            if (ketqua > 0)
                            {
                                Loadnhacungcap();
                                MessageBox.Show("Xóa Nhà Cung Cấp Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Xóa Nhà Cung Cấp Thất Bại");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Xóa Nhà Cung Cấp Thất Bại");
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

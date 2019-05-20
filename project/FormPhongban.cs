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
    public partial class FormPhongban : Form
    {
        public FormPhongban()
        {
            InitializeComponent();
        }

        private void FormPhongban_Load(object sender, EventArgs e)
        {
            Loadphongban();
            dgvPhongban.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        void Loadphongban()
        {
            string sqlphongban = @"select * from PHONGBAN";
            DataTable dtphongban = DataProvider.LoadCSDL(sqlphongban);
            dgvPhongban.DataSource = dtphongban;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvPhongban.Rows.Count > 0)
            {
                string sql = @"select * from PHONGBAN";
                DataTable dt = DataProvider.LoadCSDL(sql);

                bool kiemtranhaplieu = true;
                int sodong = dgvPhongban.Rows.Count - 1;
                // MessageBox.Show(sodong.ToString());
                int chisodongdangchon = dgvPhongban.CurrentCell.RowIndex;
                if (chisodongdangchon >= dt.Rows.Count)
                {
                    if (dgvPhongban.Rows[sodong - 1].Cells["ColumMaphongban"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Mã Phòng Ban");
                        kiemtranhaplieu = false;
                    }
                    else if (dgvPhongban.Rows[sodong - 1].Cells["ColumTenphongban"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Tên Phòng Ban");
                        kiemtranhaplieu = false;
                    }
                    else if (dgvPhongban.Rows[sodong - 1].Cells["ColumDiachi"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Địa Chỉ");
                        kiemtranhaplieu = false;
                    }
                    else if (dgvPhongban.Rows[sodong - 1].Cells["ColumSodienthoai"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Số Điện Thoại");
                        kiemtranhaplieu = false;
                    }
                    int kiemtramaphongban = 1;
                    if (kiemtranhaplieu == true)
                    {
                        for (int i = 0; i < sodong - 1; i++)
                        {
                            if (dgvPhongban.Rows[i].Cells["ColumMaphongban"].Value.ToString() == dgvPhongban.Rows[sodong - 1].Cells["ColumMaphongban"].Value.ToString())
                            {
                                MessageBox.Show("Mã Phòng Ban Đã Bị Trùng");
                                kiemtramaphongban = 0;
                                break;
                            }
                        }
                        try
                        {
                            int maphongban = int.Parse(dgvPhongban.Rows[sodong - 1].Cells["ColumMaphongban"].Value.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("Mã Phòng Ban Không Hợp Lệ");
                            kiemtramaphongban = 0;
                        }
                        try
                        {
                            float sodienthoai = float.Parse(dgvPhongban.Rows[sodong - 1].Cells["ColumSodienthoai"].Value.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("Số Điện Thoại Không Hợp Lệ");
                            kiemtramaphongban = 0;
                        }
                        if (kiemtramaphongban == 1)
                        {
                            if (MessageBox.Show("Xác Nhận Thêm Phòng Ban?", "Thêm Phòng Ban", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {
                                    string sqlthemphongban = @"insert into PHONGBAN(Maphongban, Tenphongban, Diachi, Sodienthoai)
                                               values('" + int.Parse(dgvPhongban.Rows[sodong - 1].Cells["ColumMaphongban"].Value.ToString()) + "', N'" + dgvPhongban.Rows[sodong - 1].Cells["ColumTenphongban"].Value.ToString() + "', N'" + dgvPhongban.Rows[sodong - 1].Cells["ColumDiachi"].Value.ToString() + "', '" + dgvPhongban.Rows[sodong - 1].Cells["ColumSodienthoai"].Value.ToString() + "')";
                                    int ketqua = DataProvider.change(sqlthemphongban);
                                    if (ketqua > 0)
                                    {
                                        Loadphongban();
                                        MessageBox.Show("Thêm Phòng Ban Thành Công", "Thêm Phòng Ban", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm Phòng Ban Thất Bại");
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Thêm Phòng Ban Thất Bại");
                                }
                            }
                        }

                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPhongban.Rows.Count > 0)
            {
                int chisodongdangchon = dgvPhongban.CurrentCell.RowIndex;
                bool kiemtrangiepvu = true;
                string sql = @"select * from PHONGBAN";
                DataTable dt = DataProvider.LoadCSDL(sql);
                int demphongban = dt.Rows.Count;
                for (int i = 0; i < demphongban; i++)
                {
                    if (dgvPhongban.Rows[chisodongdangchon].Cells["ColumTenphongban"].Value.ToString() == dt.Rows[i][1].ToString())
                    {
                        if (dgvPhongban.Rows[chisodongdangchon].Cells["ColumMaphongban"].Value.ToString() != dt.Rows[i][0].ToString())
                        {
                            kiemtrangiepvu = false;
                            break;
                        }
                    }
                }
                if (kiemtrangiepvu == false)
                {
                    MessageBox.Show("Mã Phòng Ban Không Được Phép Thay Đổi !", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Loadphongban();
                }
                else
                {
                    bool kiemtranghiepvu2 = true;
                    if (dgvPhongban.Rows[chisodongdangchon].Cells["ColumTenphongban"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Tên Phòng Ban");
                        kiemtranghiepvu2 = false;
                    }
                    else if (dgvPhongban.Rows[chisodongdangchon].Cells["ColumDiachi"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Địa Chỉ");
                        kiemtranghiepvu2 = false;
                    }
                    else if (dgvPhongban.Rows[chisodongdangchon].Cells["ColumSodienthoai"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa Nhập Số Điện Thoại");
                        kiemtranghiepvu2 = false;
                    }
                    else
                    {
                        try
                        {
                            float sodienthoai = float.Parse(dgvPhongban.Rows[chisodongdangchon].Cells["ColumSodienthoai"].Value.ToString());
                        }
                        catch
                        {
                            MessageBox.Show("Số Điện Thoại Không Hợp Lệ");
                            kiemtranghiepvu2 = false;
                        }
                    }
                    if (kiemtranghiepvu2 == true)
                    {
                        if (MessageBox.Show("Xác Nhận Cập Nhật Lại Thông Tin Phòng Ban Này ?", "Cập Nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                string sqlsua = @"update PHONGBAN set Tenphongban = N'" + dgvPhongban.Rows[chisodongdangchon].Cells["ColumTenphongban"].Value.ToString() + "',Diachi =  N'" + dgvPhongban.Rows[chisodongdangchon].Cells["ColumDiachi"].Value.ToString() + "', Sodienthoai = '" + dgvPhongban.Rows[chisodongdangchon].Cells["ColumSodienthoai"].Value.ToString() + "' where PHONGBAN.Maphongban = '" + int.Parse(dgvPhongban.Rows[chisodongdangchon].Cells["ColumMaphongban"].Value.ToString()) + "'";
                                int ketquasua = DataProvider.change(sqlsua);
                                if (ketquasua > 0)
                                {
                                    Loadphongban();
                                    MessageBox.Show("Cập Nhật Phòng Ban Thành Công", "Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Cập Nhật Phòng Ban Thất Bại");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Cập Nhật Phòng Ban Thất Bại");
                            }
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhongban.Rows.Count > 0)
            {
                int chisodongdangchon = dgvPhongban.CurrentCell.RowIndex;
                string sqlnhanvien = @"select nv.Manhanvien,nv.Maphongban from NHANVIEN nv";
                DataTable dtnhanvien = DataProvider.LoadCSDL(sqlnhanvien);
                int demnhanvien = dtnhanvien.Rows.Count;
                int kiemtranhanvienphongban = 1;
                string maso = "";
                for (int i = 0; i < demnhanvien; i++)
                {
                    if (dgvPhongban.Rows[chisodongdangchon].Cells["ColumMaphongban"].Value.ToString() == dtnhanvien.Rows[i][1].ToString())
                    {
                        kiemtranhanvienphongban = 0;
                        maso = dtnhanvien.Rows[i][0].ToString();
                        break;
                    }
                }
                if (kiemtranhanvienphongban == 0)
                {
                    MessageBox.Show("Đang Tồn Tại Nhân Viên Có Mã Số " + maso + " Thuộc Phòng Ban Này. Chỉ Có Thể Xóa Phòng Ban Không Tồn Tại Nhân Viên!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Xóa Phòng Ban Có Mã Số " + dgvPhongban.Rows[chisodongdangchon].Cells["ColumMaphongban"].Value.ToString() + " Ra Khỏi Danh Sách Phòng Ban Không ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            string sqlxoaphongban = @"delete from PHONGBAN where PHONGBAN.Maphongban = '" + int.Parse(dgvPhongban.Rows[chisodongdangchon].Cells["ColumMaphongban"].Value.ToString()) + "'";
                            int ketqua = DataProvider.change(sqlxoaphongban);
                            if (ketqua > 0)
                            {
                                Loadphongban();
                                MessageBox.Show("Xóa Phòng Ban Thành Công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Xóa Phòng Ban Thất Bại");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Xóa Phòng Ban Thất Bại");
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

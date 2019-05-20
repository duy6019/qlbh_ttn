using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace project
{
    public partial class FormThongkedoanhthutungmathang : Form
    {
        public FormThongkedoanhthutungmathang()
        {
            InitializeComponent();
        }

        private void FormThongkedoanhthutungmathang_Load(object sender, EventArgs e)
        {
            string sqlsanpham = @"select sp.Masanpham, sp.Tensanpham, sp.Giaban from SANPHAM sp";
            System.Data.DataTable dtsanpham = DataProvider.LoadCSDL(sqlsanpham);
            dgvDoanhthu.DataSource = dtsanpham;
            dgvDoanhthu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Xulydoanhthu();
        }
        void Xulydoanhthu()
        {
            string sqlhoadon = @"select ct.Mahoadon,ct.Masanpham, sp.Gianhap, sp.Giaban, ct.Soluongban, ct.Thanhtien
                                from CHITIETHOADON ct, SANPHAM sp where sp.Masanpham = ct.Masanpham";
            System.Data.DataTable dthoadon = DataProvider.LoadCSDL(sqlhoadon);
            int demhoadon = dthoadon.Rows.Count;
            string sqlsanpham = @"select * from SANPHAM";
            System.Data.DataTable dtsanpham = DataProvider.LoadCSDL(sqlsanpham);
            int demsanpham = dtsanpham.Rows.Count;
            for (int i = 0; i < demsanpham; i++)
            {
                int soluongban = 0;
                float thanhtien = 0;
                float doanhthu = 0;
                for (int j = 0; j < demhoadon; j++)
                {
                    if (dtsanpham.Rows[i][0].ToString() == dthoadon.Rows[j][1].ToString())
                    {
                        soluongban += int.Parse(dthoadon.Rows[j][4].ToString());
                        thanhtien += float.Parse(dthoadon.Rows[j][5].ToString());
                        doanhthu += (float.Parse(dthoadon.Rows[j][3].ToString()) - float.Parse(dthoadon.Rows[j][2].ToString())) * float.Parse(dthoadon.Rows[j][4].ToString());
                    }
                }

                dgvDoanhthu.Rows[i].Cells["ColumSoluongban"].Value = soluongban.ToString();
                dgvDoanhthu.Rows[i].Cells["ColumThanhtien"].Value = thanhtien.ToString();
                dgvDoanhthu.Rows[i].Cells["ColumDoanhthu"].Value = doanhthu.ToString();
            }
        }
        private void Xuatexcel(DataGridView g, string duongdan, string teptin)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 20;
            obj.Cells[1, 1] = g.Columns[3].HeaderText;
            obj.Cells[1, 2] = g.Columns[4].HeaderText;
            obj.Cells[1, 3] = g.Columns[5].HeaderText;
            obj.Cells[1, 4] = g.Columns[0].HeaderText;
            obj.Cells[1, 5] = g.Columns[1].HeaderText;
            obj.Cells[1, 6] = g.Columns[2].HeaderText;
            int chiso = 0;
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (j == 0)
                    {
                        chiso = 3;
                    }
                    else if (j == 1)
                    {
                        chiso = 4;
                    }
                    else if (j == 2)
                    {
                        chiso = 5;
                    }
                    else if (j == 3)
                    {
                        chiso = 0;
                    }
                    else if (j == 4)
                    {
                        chiso = 1;
                    }
                    else if (j == 5)
                    {
                        chiso = 2;
                    }
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[chiso].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan + teptin + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void xuấtFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xuatexcel(dgvDoanhthu, @"D:\", "Thongkedoanhthu");
            MessageBox.Show("Xuất Dữ Liệu Thành Công.Kiểm tra dữ liệu xuất ở ổ D", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

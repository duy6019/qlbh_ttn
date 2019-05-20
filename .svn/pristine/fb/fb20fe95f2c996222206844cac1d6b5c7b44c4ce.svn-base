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
    public partial class FormNhanvienchuacotaikhoan : Form
    {
        public FormNhanvienchuacotaikhoan()
        {
            InitializeComponent();
        }
        public List<string> lstnhanvien;
        private void FormNhanvienchuacotaikhoan_Load(object sender, EventArgs e)
        {
            string sqlnhanvien = @"select nv.Manhanvien,nv.Tennhanvien, pb.Tenphongban, cv.Tenchucvu
                                   from NHANVIEN nv,PHONGBAN pb,CHUCVU cv where nv.Maphongban = pb.Maphongban and nv.Machucvu = cv.Machucvu";
            DataTable dtnhanvien = DataProvider.LoadCSDL(sqlnhanvien);
            int demlstnhanvien = lstnhanvien.Count;
            int demnhanvien = dtnhanvien.Rows.Count;
            for (int i = 0; i < demnhanvien; i++)
            {
                for (int j = 0; j < demlstnhanvien; j++)
                {
                    if (dtnhanvien.Rows[i][0].ToString() == lstnhanvien[j])
                    {
                        dgvNhanvien.Rows.Add(dtnhanvien.Rows[i][0].ToString(), dtnhanvien.Rows[i][1].ToString(), dtnhanvien.Rows[i][2].ToString(), dtnhanvien.Rows[i][3].ToString());
                        break;
                    }
                }
            }
            dgvNhanvien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}

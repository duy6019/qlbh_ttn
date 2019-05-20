using project.Entities;
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
    public partial class FormInnhanvien : Form
    {
        public FormInnhanvien()
        {
            InitializeComponent();
        }

        private void FormInnhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpvNhanvien.LocalReport.ReleaseSandboxAppDomain();
        }
        private void FormInnhanvien_Load(object sender, EventArgs e)
        {
            using (QuanLyBanHangSieuThiFullEntities db = new QuanLyBanHangSieuThiFullEntities())
            {
                vwHienthinhanvienBindingSource.DataSource = db.vw_Hienthinhanvien.ToList();
                rpvNhanvien.RefreshReport();
            }
        }
    }
}

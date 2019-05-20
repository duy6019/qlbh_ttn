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
    public partial class FormInsanpham : Form
    {
        public FormInsanpham()
        {
            InitializeComponent();
        }


        private void rpvSanpham_Load(object sender, EventArgs e)
        {
            using(QuanLyBanHangSieuThiFullEntities db = new QuanLyBanHangSieuThiFullEntities())
            {
                vwHienthisanphamBindingSource.DataSource = db.vw_Hienthisanpham.ToList();
                rpvSanpham.RefreshReport();
            }
        }

        private void FormInsanpham_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpvSanpham.LocalReport.ReleaseSandboxAppDomain();
        }

        private void FormInsanpham_Load(object sender, EventArgs e)
        {

        }
    }
}

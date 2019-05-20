using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using project.Entities;

namespace project
{
    public partial class FormThongkenhanvien : Form
    {
        public FormThongkenhanvien()
        {
            InitializeComponent();
        }
        void Xuly(int maphongban)
        {
            ReportParameter rp = new ReportParameter("Maphongban",maphongban.ToString());
            rpvThongkenhanvien.LocalReport.SetParameters(rp);
        }

        private void cmbPhongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            Xuly(int.Parse(cmbPhongban.SelectedValue.ToString()));
            rpvThongkenhanvien.RefreshReport();
        }

        private void FormThongkenhanvien_Load(object sender, EventArgs e)
        {
            using(QuanLyBanHangSieuThiFullEntities db  =new QuanLyBanHangSieuThiFullEntities())
            {
                pHONGBANBindingSource.DataSource = db.PHONGBANs.ToList();
                Xuly(int.Parse(cmbPhongban.SelectedValue.ToString()));
                ReportDataSource rps = new ReportDataSource("Thongkenhanvien", db.vw_Hienthinhanvien2.ToList());
                rpvThongkenhanvien.LocalReport.DataSources.Clear();
                rpvThongkenhanvien.LocalReport.DataSources.Add(rps);
                rpvThongkenhanvien.RefreshReport();
            }
        }


        private void FormThongkenhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpvThongkenhanvien.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}

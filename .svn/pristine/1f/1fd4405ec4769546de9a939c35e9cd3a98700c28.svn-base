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
    public partial class FormInhoadonhientai : Form
    {
        public FormInhoadonhientai()
        {
            InitializeComponent();
        }
        public string Mahoadon, Tenkhachhang, Tennhanvien, Ngayban, Tongtien ;
        private void FormInhoadonhientai_Load(object sender, EventArgs e)
        {
            using (QuanLyBanHangSieuThiFullEntities db = new QuanLyBanHangSieuThiFullEntities())
            {
                ReportParameter[] rp = new ReportParameter[5];
                rp[0] = new ReportParameter("Mahoadon",Mahoadon);
                rp[1] = new ReportParameter("Tenkhachhang", Tenkhachhang);
                rp[2] = new ReportParameter("Tennhanvien", Tennhanvien);
                rp[3] = new ReportParameter("Ngayban", Ngayban);
                rp[4] = new ReportParameter("Tongtien", Tongtien);
                rpvChitiethoadonhientai.LocalReport.SetParameters(rp);
                ReportDataSource rps = new ReportDataSource("Hoadonhientai", db.vw_Hienthichitiethoadon2.ToList());
                rpvChitiethoadonhientai.LocalReport.DataSources.Clear();
                rpvChitiethoadonhientai.LocalReport.DataSources.Add(rps);
                this.rpvChitiethoadonhientai.RefreshReport();

            }
        }
        private void FormInhoadonhientai_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpvChitiethoadonhientai.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}

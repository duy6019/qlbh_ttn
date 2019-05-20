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
    public partial class FormInhoadon : Form
    {
        public FormInhoadon()
        {
            InitializeComponent();
        }
        public string MAHOADON, Tennhanvien, Tenkhachhang, Ngayban, Tienthanhtoan;

        private void FormInhoadon_Load(object sender, EventArgs e)
        {
            using (QuanLyBanHangSieuThiFullEntities db = new QuanLyBanHangSieuThiFullEntities())
            {
                ReportParameter[] rp = new ReportParameter[5];
                rp[0] = new ReportParameter("Mahoadon", MAHOADON);
                rp[1] = new ReportParameter("Tenkhachhang", Tenkhachhang);
                rp[2] = new ReportParameter("Tennhanvien", Tennhanvien);
                rp[3] = new ReportParameter("Ngayban", Ngayban);
                rp[4] = new ReportParameter("Tienthanhtoan", Tienthanhtoan);
                rpvHoadon.LocalReport.SetParameters(rp);
                ReportDataSource rps = new ReportDataSource("Hoadon", db.vw_Hienthichitiethoadon2.ToList());
                rpvHoadon.LocalReport.DataSources.Clear();
                rpvHoadon.LocalReport.DataSources.Add(rps);
                this.rpvHoadon.RefreshReport();

            }
        }

        private void FormInhoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpvHoadon.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}

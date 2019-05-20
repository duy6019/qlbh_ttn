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
    public partial class FormThongkehoadon : Form
    {
        public FormThongkehoadon()
        {
            InitializeComponent();
        }

       
        void Xuly(DateTime tungay, DateTime denngay)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("Tungay");
            rp[0].Values.Add(tungay.ToString());
            rp[1] = new ReportParameter("Denngay");
            rp[1].Values.Add(denngay.ToString());
            rpvThongkehoadon.LocalReport.SetParameters(rp);
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            using (QuanLyBanHangSieuThiFullEntities db = new QuanLyBanHangSieuThiFullEntities())
            {
                
                Xuly(dtpTungay.Value, dtpDenngay.Value);

                ReportDataSource rps = new ReportDataSource("Danhsachhoadon", db.vw_Hienthihoadon.ToList());
                rpvThongkehoadon.LocalReport.DataSources.Clear();
                rpvThongkehoadon.LocalReport.DataSources.Add(rps);

                rpvThongkehoadon.RefreshReport();
            }
        }

        private void FormThongkehoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpvThongkehoadon.LocalReport.ReleaseSandboxAppDomain();
        }

    }
}

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
    public partial class FormThongkehanghoa : Form
    {
        public FormThongkehanghoa()
        {
            InitializeComponent();
        }

        private void FormThongkehanghoa_Load(object sender, EventArgs e)
        {
            
            using (QuanLyBanHangSieuThiFullEntities db = new QuanLyBanHangSieuThiFullEntities())
            {
                lOAISANPHAMBindingSource.DataSource = db.LOAISANPHAMs.ToList();
                Xulylocloaisanpham(int.Parse(cmbLoaisanpham.SelectedValue.ToString()));
                ReportDataSource rps = new ReportDataSource("Thongkehanghoa", db.vw_Hienthisanpham2.ToList());
                rpvHanghoa.LocalReport.DataSources.Clear();
                rpvHanghoa.LocalReport.DataSources.Add(rps);
                rpvHanghoa.RefreshReport();
            }
        }
        void Xulylocloaisanpham(int maloaisanpham)
        {
            ReportParameter rp = new ReportParameter("Maloaisanpham",maloaisanpham.ToString());
            rpvHanghoa.LocalReport.SetParameters(rp);
        }

        private void FormThongkehanghoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpvHanghoa.LocalReport.ReleaseSandboxAppDomain();
        }

        private void cmbLoaisanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            Xulylocloaisanpham(int.Parse(cmbLoaisanpham.SelectedValue.ToString()));
            rpvHanghoa.RefreshReport();
        }
    }
}

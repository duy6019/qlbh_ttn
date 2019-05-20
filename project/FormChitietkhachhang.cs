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
    public partial class FormChitietkhachhang : Form
    {
        public FormChitietkhachhang()
        {
            InitializeComponent();
        }
        public string Makhachhang, Tenkhachhang, Gioitinh, Ngaysinh, Diachi, Sodienthoai, Tongtien;
        private void FormChitietkhachhang_Load(object sender, EventArgs e)
        {
            using (QuanLyBanHangSieuThiFullEntities db = new QuanLyBanHangSieuThiFullEntities()) {
                ReportParameter[] rp = new ReportParameter[7];
                rp[0] = new ReportParameter("Makhachhang", Makhachhang);
                rp[1] = new ReportParameter("Tenkhachhang", Tenkhachhang);
                rp[2] = new ReportParameter("Gioitinh", Gioitinh);
                rp[3] = new ReportParameter("Ngaysinh", Ngaysinh);
                rp[4] = new ReportParameter("Diachi", Diachi);
                rp[5] = new ReportParameter("Sodienthoai", Sodienthoai);
                rp[6] = new ReportParameter("Tongtien", Tongtien);
                rpvKhachhang.LocalReport.SetParameters(rp);
                KhachHangRepos kh = new KhachHangRepos();
                List < KhachHangViewModel > data = kh.GetAll();
                ReportDataSource rps = new ReportDataSource("Khachhang",data);
                rpvKhachhang.LocalReport.DataSources.Clear();
                rpvKhachhang.LocalReport.DataSources.Add(rps);
                rpvKhachhang.Refresh();
                rpvKhachhang.RefreshReport();
            } 
        }
        private void FormChitietkhachhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            rpvKhachhang.LocalReport.ReleaseSandboxAppDomain();
        }

    }
}

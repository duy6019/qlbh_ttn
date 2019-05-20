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
    public partial class FormTroGiup : Form
    {
        public FormTroGiup()
        {
            InitializeComponent();
        }

        private void FormTroGiup_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void FormTroGiup_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}

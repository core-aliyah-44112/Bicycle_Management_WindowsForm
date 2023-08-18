using Do_An_BaoCao.DAO;
using Do_An_BaoCao.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_BaoCao.frm
{
    public partial class frmInDSNV : Form
    {
        public frmInDSNV()
        {
            InitializeComponent();
        }

        private void frmInDSNV_Load(object sender, EventArgs e)
        {
            NhanVienDAO khDAO = new NhanVienDAO();
            List<NV_BD_PB> listXe = khDAO.getList();
            this.reportViewer1.LocalReport.ReportPath = "BCNhanVien.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", listXe);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}

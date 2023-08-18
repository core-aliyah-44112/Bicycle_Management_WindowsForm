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
    public partial class frmInDSBaoDuong : Form
    {
        public frmInDSBaoDuong()
        {
            InitializeComponent();
        }

        private void frmInDSBaoDuong_Load(object sender, EventArgs e)
        {
            BaoDuongDAO khDAO = new BaoDuongDAO();
            List<BD_NV_PB_XD> listXe = khDAO.getList();
            this.reportViewerBaoDuong.LocalReport.ReportPath = "BCBaoDuong.rdlc";
            var reportDataSource = new ReportDataSource("DataSetBaoDuong", listXe);
            this.reportViewerBaoDuong.LocalReport.DataSources.Clear();
            this.reportViewerBaoDuong.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewerBaoDuong.RefreshReport();
        }
    }
}

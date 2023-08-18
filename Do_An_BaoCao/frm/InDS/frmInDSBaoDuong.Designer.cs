
namespace Do_An_BaoCao.frm
{
    partial class frmInDSBaoDuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BaoDuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerBaoDuong = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BaoDuongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BaoDuongBindingSource
            // 
            this.BaoDuongBindingSource.DataSource = typeof(Do_An_BaoCao.Models.BaoDuong);
            // 
            // reportViewerBaoDuong
            // 
            this.reportViewerBaoDuong.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetBaoDuong";
            reportDataSource1.Value = this.BaoDuongBindingSource;
            this.reportViewerBaoDuong.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBaoDuong.LocalReport.ReportEmbeddedResource = "Do_An_BaoCao.report.BCBaoDuong.rdlc";
            this.reportViewerBaoDuong.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBaoDuong.Name = "reportViewerBaoDuong";
            this.reportViewerBaoDuong.ServerReport.BearerToken = null;
            this.reportViewerBaoDuong.Size = new System.Drawing.Size(800, 450);
            this.reportViewerBaoDuong.TabIndex = 0;
            // 
            // frmInDSBaoDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerBaoDuong);
            this.Name = "frmInDSBaoDuong";
            this.Load += new System.EventHandler(this.frmInDSBaoDuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoDuongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBaoDuong;
        private System.Windows.Forms.BindingSource BaoDuongBindingSource;
    }
}
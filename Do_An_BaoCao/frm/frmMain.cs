using Do_An_BaoCao.Labrary;
using Do_An_BaoCao.Models;
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
    public partial class frmMain : Form
    {
        public static TabControl tabcontrol = null;
        public static ThanhVien thanhvien = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (thanhvien == null)
            {
                Form frm = new frmDangNhap();
                frm.ShowDialog();

            }
            toolStripStatusTenDangNhap.Text = thanhvien.HoTen;
            tabcontrol = tabControlMain;

        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Liên hệ";
            tab.Name = "tbLienHe";
            tab.ImageIndex = 4;
            Form frm = new frmLienHe();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbLienHe"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbLienHe"];
        }

        private void ThuêxeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Thuê xe";
            tab.Name = "tbThueXe";
            tab.ImageIndex = 4;
            Form frm = new frmThueXe();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbThueXe"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbThueXe"];
        }

        private void XeDapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InbaocaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Quản lý xe";
            tab.Name = "tbXeDap";
            tab.ImageIndex = 4;
            Form frm = new frmXedap();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbXeDap"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbXeDap"];
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Phòng ban";
            tab.Name = "tbPhongBan";
            tab.ImageIndex = 4;
            Form frm = new frmPhongBan();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbPhongBan"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbPhongBan"];
        }

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Nhân viên";
            tab.Name = "tbNhanVien";
            tab.ImageIndex = 4;
            Form frm = new frmNhanVien();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbNhanVien"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbNhanVien"];
        }

        private void thôngTinToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Khách hàng";
            tab.Name = "tbKhachHang";
            tab.ImageIndex = 4;
            Form frm = new frmKhachHang();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbKhachHang"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbKhachHang"];
        }

        private void qLHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Hoá đơn";
            tab.Name = "tbHoaDon";
            tab.ImageIndex = 4;
            Form frm = new frmHoaDon();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbHoaDon"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbHoaDon"];
        }

        private void chiTiếtBảoDưỡngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Bảo dưỡng";
            tab.Name = "tbBaoDuong";
            tab.ImageIndex = 4;
            Form frm = new frmBaoDuong();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbBaoDuong"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbBaoDuong"];
        }

        private void cáchCàiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Cài đặt";
            tab.Name = "tbCachCaiDat";
            tab.ImageIndex = 4;
            Form frm = new frmCachCaiDat();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbCachCaiDat"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbCachCaiDat"];
        }

        private void tinTứcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tinTứcDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Tin tức";
            tab.Name = "tbTinTuc";
            tab.ImageIndex = 4;
            Form frm = new frmTinTuc();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbTinTuc"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbTinTuc"];
        }

        private void giớiThiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Giới thiệu";
            tab.Name = "tbGioiThieu";
            tab.ImageIndex = 4;
            Form frm = new frmGioiThieu();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbGioiThieu"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbGioiThieu"];
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Thông Tin Nhân Viên";
            tab.Name = "tbThongTinNV";
            tab.ImageIndex = 4;
            Form frm = new frmThongTinNV();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbThongTinNV"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbThongTinNV"];
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TabPage tab = new TabPage();
            tab.Text = "Đổi mật khẩu";
            tab.Name = "tbDoiMK";
            tab.ImageIndex = 4;
            Form frm = new frmDoiMK();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbDoiMK"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbDoiMK"];
        }

        private void inDanhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Báo cáo bảo dưởng";
            tab.Name = "tbBCBaoDuong";
            tab.ImageIndex = 4;
            Form frm = new frmInDSBaoDuong();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbBCBaoDuong"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbBCBaoDuong"];
        }

        private void inThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TabPage tab = new TabPage();
            tab.Text = "Danh sách khách hàng";
            tab.Name = "tbBCKhachHang";
            tab.ImageIndex = 4;
            Form frm = new frmInDSKhachHang();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbBCKhachHang"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbBCKhachHang"];

        }

        private void inBáoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Danh sách Nhân viên";
            tab.Name = "tbBCNhanVien";
            tab.ImageIndex = 4;
            Form frm = new frmInDSNV();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbBCNhanVien"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbBCNhanVien"];
        }

        private void inDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Danh sách Hoá Đơn";
            tab.Name = "tbBCHoaDon";
            tab.ImageIndex = 4;
            Form frm = new frmInHoaDon();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbBCHoaDon"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbBCHoaDon"];
        }

        private void inBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Danh sách Phòng Ban";
            tab.Name = "tbBCPhongBan";
            tab.ImageIndex = 4;
            Form frm = new frmInDSPBan();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbBCPhongBan"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbBCPhongBan"];
        }

        private void tHÔNGTINXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "Danh sách XE ĐẠP";
            tab.Name = "tbBCXeDap";
            tab.ImageIndex = 4;
            Form frm = new frmInThongTinXeDap();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            if (!ExistTabPage.ETP(tabControlMain, "tbBCXeDap"))
            {
                tabControlMain.TabPages.Add(tab);
            }
            tabControlMain.SelectedTab = tabControlMain.TabPages["tbBCXeDap"];
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmMain();
            frmMain.thanhvien = null;
            frmMain.ActiveForm.Hide();
            frm.ShowDialog();
        }
    }
}

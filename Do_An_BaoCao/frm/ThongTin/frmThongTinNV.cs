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
    public partial class frmThongTinNV : Form
    {
        
        public frmThongTinNV()
        {
            InitializeComponent();
        }

        private void frmThongTinNV_Load(object sender, EventArgs e)
        {
            OnOff(false);
            ThanhVien thanhvien = frmMain.thanhvien;
            txtTenDangNhap.Text = thanhvien.TenDangNhap;
            txtHoTen.Text = thanhvien.HoTen;
            txtEmail.Text = thanhvien.Email;
            txtSDT.Text = thanhvien.DienThoai;
            txtMatKhau.Text = thanhvien.MatKhau;
            txtQuyen.Text = thanhvien.Quyen;
        }
        private void OnOff(bool value)
        {
            txtTenDangNhap.Enabled = value;
            txtHoTen.Enabled = value;
            txtEmail.Enabled = value;
            txtSDT.Enabled = value;
            txtMatKhau.Enabled = value;
            txtQuyen.Enabled = value;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain.tabcontrol.TabPages.Remove(frmMain.tabcontrol.TabPages["tbThongTinNV"]);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
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
            if (!ExistTabPage.ETP(frmMain.tabcontrol, "tbDoiMK"))
            {
                frmMain.tabcontrol.TabPages.Add(tab);
            }
            frmMain.tabcontrol.SelectedTab = frmMain.tabcontrol.TabPages["tbDoiMK"];
        }
    }
    }


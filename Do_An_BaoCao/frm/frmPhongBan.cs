using Do_An_BaoCao.DAO;
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
    public partial class frmPhongBan : Form
    {
        public string AddOrEdit;
        private PhongBanDAO pbDAO = new PhongBanDAO();
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPB.Text.Trim()))
                {
                    throw new Exception("Ghi chú không được để trống");
                }

                if (string.IsNullOrEmpty(txtGhiChu.Text.Trim()))
                {
                    throw new Exception("Ghi chú không được để trống");
                }
                int mapb = int.Parse(txtMaPB.Text.Trim());
                string tenpb = txtTenPB.Text.Trim();
                string ghichu = txtGhiChu.Text.Trim();


                PhongBan pb = new PhongBan();
                pb.MaPB = mapb;
                pb.TenPB = tenpb;
                pb.GhiChu = ghichu;
                pbDAO.Insert(pb);
                dgvDanhsach.DataSource = pbDAO.getList();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPB.Text.Trim()))
                {
                    throw new Exception("Ghi chú không được để trống");
                }
                if (string.IsNullOrEmpty(txtTenPB.Text.Trim()))
                {
                    throw new Exception("Tên Phòng ban không được để trống");
                }

                if (string.IsNullOrEmpty(txtGhiChu.Text.Trim()))
                {
                    throw new Exception("Ghi chú không được để trống");
                }
                int mapb = int.Parse(txtMaPB.Text.Trim());
                string tenpb = txtTenPB.Text.Trim();
                string ghichu = txtGhiChu.Text.Trim();


                PhongBan pb = pbDAO.getRow(mapb);
                pb.MaPB = mapb;
                pb.TenPB = tenpb;
                pb.GhiChu = ghichu;
                pbDAO.Update(pb);
                dgvDanhsach.DataSource = pbDAO.getList();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mapb = int.Parse(txtMaPB.Text.Trim());
            PhongBan pb = pbDAO.getRow(mapb);
            pbDAO.Delete(pb);
            dgvDanhsach.DataSource = pbDAO.getList();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain.tabcontrol.TabPages.Remove(frmMain.tabcontrol.TabPages["tbPhongBan"]);
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            dgvDanhsach.DataSource = pbDAO.getList();
            OnOff(true);
           
        }

      

        private void OnOff(bool value)
        {
            txtMaPB.Enabled = value;

        }
    }
}

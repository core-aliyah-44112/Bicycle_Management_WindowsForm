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
    public partial class frmNhanVien : Form
    {
        public string AddOrEdit;
        private NhanVienDAO nvDAO = new NhanVienDAO();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
                {
                    throw new Exception("Mã không để trống");
                }
                if (string.IsNullOrEmpty(txtHoTenNV.Text.Trim()))
                {
                    throw new Exception(" tên không được để trống");
                }
                if (string.IsNullOrEmpty(txtGhiChu.Text.Trim()))
                {
                    throw new Exception(" Ghi chú không được để trống");
                }

                int manv = int.Parse(txtMaNV.Text.Trim());
             
                string hotennv = txtHoTenNV.Text.Trim();
                DateTime ngaysinh = dtpNgaySinh.Value;
                string gioitinh = cbGioiTinh.Text.Trim();
                int mapb = int.Parse(cbMaPB.Text.Trim());
                string ghichu = txtGhiChu.Text.Trim();


                NhanVien nv = new NhanVien();
                nv.MaNV = manv;
                nv.HoTenNV = hotennv;
                nv.NgaySinh = ngaysinh;
                nv.GioiTinh = gioitinh;
                nv.MaPB = mapb;
                nv.GhiChu = ghichu;
                nvDAO.Insert(nv);
                dgvDanhSach.DataSource = nvDAO.getList();
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
                if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
                {
                    throw new Exception("Mã không để trống");
                }
                if (string.IsNullOrEmpty(txtHoTenNV.Text.Trim()))
                {
                    throw new Exception(" tên không được để trống");
                }
                if (string.IsNullOrEmpty(txtGhiChu.Text.Trim()))
                {
                    throw new Exception(" Ghi chú không được để trống");
                }

                int manv = int.Parse(txtMaNV.Text.Trim());

                string hotennv = txtHoTenNV.Text.Trim();
                DateTime ngaysinh = dtpNgaySinh.Value;
                string gioitinh = cbGioiTinh.Text.Trim();
                int mapb = int.Parse(cbMaPB.Text.Trim());
                string ghichu = txtGhiChu.Text.Trim();


                NhanVien nv = nvDAO.getRow(manv);
                nv.HoTenNV = hotennv;
                nv.NgaySinh = ngaysinh;
                nv.GioiTinh = gioitinh;
                nv.MaPB = mapb;
                nv.GhiChu = ghichu;
                nvDAO.Update(nv);
                dgvDanhSach.DataSource = nvDAO.getList();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo");
            }
        }
        private void OnOff(bool value)
        {
            txtMaNV.Enabled = value;

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OnOff(false);
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                int vt = e.RowIndex;
                txtMaNV.Text = dgvDanhSach.Rows[vt].Cells["MaNV"].Value.ToString();
                txtHoTenNV.Text = dgvDanhSach.Rows[vt].Cells["HoTenNV"].Value.ToString();
                cbGioiTinh.Text = dgvDanhSach.Rows[vt].Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSach.Rows[vt].Cells["NgaySinh"].Value.ToString();
                cbMaPB.Text = dgvDanhSach.Rows[vt].Cells["MaPB"].Value.ToString();
                txtGhiChu.Text = dgvDanhSach.Rows[vt].Cells["GhiChu"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(txtMaNV.Text.Trim());
            NhanVien nv = nvDAO.getRow(manv);
            nvDAO.Delete(nv);
           
            dgvDanhSach.DataSource = nvDAO.getList();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain.tabcontrol.TabPages.Remove(frmMain.tabcontrol.TabPages["tbNhanVien"]);
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = nvDAO.getList();
            OnOff(true);
        }
    }
}

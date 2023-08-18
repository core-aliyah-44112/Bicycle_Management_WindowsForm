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
    public partial class frmKhachHang : Form
    {
        public string AddOrEdit;
        private KhachHangDAO khDAO = new KhachHangDAO();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void OnOff(bool value)
        {
            txtMaKH.Enabled = value;

        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = khDAO.getList();
            OnOff(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(txtMaKH.Text.Trim());
            KhachHang kh = khDAO.getRow(makh);
            khDAO.Delete(kh);
            
            dgvDanhSach.DataSource = khDAO.getList();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain.tabcontrol.TabPages.Remove(frmMain.tabcontrol.TabPages["tbKhachHang"]);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtMaKH.Text.Trim()))
                {
                    throw new Exception(" MÃ KH không được để trống");
                }
                if (string.IsNullOrEmpty(txtHoTenKH.Text.Trim()))
                {
                    throw new Exception("Tên KH ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtSoCMND.Text.Trim()))
                {
                    throw new Exception("Số CMND ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtSoTKNH.Text.Trim()))
                {
                    throw new Exception("Số TKNH ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtSDT.Text.Trim()))
                {
                    throw new Exception("Số Đt ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    throw new Exception("Email ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
                {
                    throw new Exception("Địa chỉ ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtGhiChu.Text.Trim()))
                {
                    throw new Exception("Ghi chú ko đc để trống");
                }

                int makh = int.Parse(txtMaKH.Text.Trim());
                string hotenkh = txtHoTenKH.Text.Trim();           
                string gioitinh = cbGioiTinh.Text.Trim();
                DateTime ngaysinh = dtpNgaySinh.Value;
                int socmnd = int.Parse(txtSoCMND.Text.Trim());
                int sotknh = int.Parse(txtSoTKNH.Text.Trim());
                int sdt = int.Parse(txtSDT.Text.Trim());
                string email = txtEmail.Text.Trim();
                string diachi = txtDiaChi.Text.Trim();
                string ghichu = txtGhiChu.Text.Trim();


                KhachHang kh = new KhachHang();
                kh.MaKH = makh;
                kh.HoTenKH = hotenkh;
                kh.GioiTinh = gioitinh;
                kh.NgaySinh = ngaysinh;
                kh.CMND = socmnd;
                kh.SoTKNH = sotknh;
                kh.SDT = sdt;
                kh.Email = email;
                kh.DiaChi = diachi;
                kh.GhiChu = ghichu;
                khDAO.Insert(kh);
               
                dgvDanhSach.DataSource = khDAO.getList();
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

                if (string.IsNullOrEmpty(txtMaKH.Text.Trim()))
                {
                    throw new Exception(" MÃ KH không được để trống");
                }
                if (string.IsNullOrEmpty(txtHoTenKH.Text.Trim()))
                {
                    throw new Exception("Tên KH ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtSoCMND.Text.Trim()))
                {
                    throw new Exception("Số CMND ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtSoTKNH.Text.Trim()))
                {
                    throw new Exception("Số TKNH ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtSDT.Text.Trim()))
                {
                    throw new Exception("Số Đt ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    throw new Exception("Email ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
                {
                    throw new Exception("Địa chỉ ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtGhiChu.Text.Trim()))
                {
                    throw new Exception("Ghi chú ko đc để trống");
                }

                int makh = int.Parse(txtMaKH.Text.Trim());
                string hotenkh = txtHoTenKH.Text.Trim();
                string gioitinh = cbGioiTinh.Text.Trim();
                DateTime ngaysinh = dtpNgaySinh.Value;
                int socmnd = int.Parse(txtSoCMND.Text.Trim());
                int sotknh = int.Parse(txtSoTKNH.Text.Trim());
                int sdt = int.Parse(txtSDT.Text.Trim());
                string email = txtEmail.Text.Trim();
                string diachi = txtDiaChi.Text.Trim();
                string ghichu = txtGhiChu.Text.Trim();

                KhachHang kh = khDAO.getRow(makh);
                
                kh.MaKH = makh;
                kh.HoTenKH = hotenkh;
                kh.GioiTinh = gioitinh;
                kh.NgaySinh = ngaysinh;
                kh.CMND = socmnd;
                kh.SoTKNH = sotknh;
                kh.SDT = sdt;
                kh.Email = email;
                kh.DiaChi = diachi;
                kh.GhiChu = ghichu;
                khDAO.Update(kh);

                dgvDanhSach.DataSource = khDAO.getList();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo");
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OnOff(false);
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                int vt = e.RowIndex;
                txtMaKH.Text = dgvDanhSach.Rows[vt].Cells["MaKH"].Value.ToString();
                txtHoTenKH.Text = dgvDanhSach.Rows[vt].Cells["HoTenKH"].Value.ToString();
                cbGioiTinh.Text = dgvDanhSach.Rows[vt].Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSach.Rows[vt].Cells["NgaySinh"].Value.ToString();
                txtSoCMND.Text = dgvDanhSach.Rows[vt].Cells["CMND"].Value.ToString();
                txtSDT.Text = dgvDanhSach.Rows[vt].Cells["SDT"].Value.ToString();
                txtEmail.Text = dgvDanhSach.Rows[vt].Cells["Email"].Value.ToString();
                txtDiaChi.Text = dgvDanhSach.Rows[vt].Cells["DiaChi"].Value.ToString();
                txtGhiChu.Text = dgvDanhSach.Rows[vt].Cells["GhiChu"].Value.ToString();
            }
        }
    }
}

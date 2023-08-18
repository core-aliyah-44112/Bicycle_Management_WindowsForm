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
    public partial class frmThueXe : Form
    {
        private ThueXeDAO txDAO = new ThueXeDAO();
        private KhachHangDAO khDAO = new KhachHangDAO();
        private XeDapDAO xdDAO = new XeDapDAO();
        public frmThueXe()
        {
            InitializeComponent();
        }

        private void frmThueXe_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = txDAO.getList();
            OnOff(true);
            loadKH();
            loadXe();
        }

        private void loadXe()
        {
            cbMaXe.DataSource = xdDAO.getList();
            cbMaXe.DisplayMember = "TenXe";
            cbMaXe.ValueMember = "MaXe";
            txtTenXe.DataBindings.Add(new Binding("Text", cbMaXe.DataSource, "TenXe"));
            txtTenXe.Enabled = false;
        }

        private void loadKH()
        {
            cbMaKH.DataSource = khDAO.getList();
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.ValueMember = "MaKH";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    throw new Exception("Tên không để trống");
                }
                if (string.IsNullOrEmpty(txtSoCMND.Text.Trim()))
                {
                    throw new Exception("Số CMND ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
                {
                    throw new Exception("Địa chỉ ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtSoTKNH.Text.Trim()))
                {
                    throw new Exception("Số Tài khoản ngân hàng ko đc để trống");
                }
               
                if (string.IsNullOrEmpty(txtTenXe.Text.Trim()))
                {
                    throw new Exception("Tên xe ko được để trống");
                }
                if (string.IsNullOrEmpty(txtGia.Text.Trim()))
                {
                    throw new Exception("Giá xe ko được để trống");
                }
                
                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    throw new Exception("Email ko được để trống");
                }
                string email = txtEmail.Text.Trim();
                int makh = int.Parse(cbMaKH.SelectedValue.ToString());
                int matx = int.Parse(txtMaTX.Text.Trim());
                DateTime ngaysinh = dtpNgaySinh.Value;
                int socmnd = int.Parse(txtSoCMND.Text.Trim());
                string gioitinh= cbGioiTinh.Text.Trim();
                string diachi = txtDiaChi.Text.Trim();
                int sotknh = int.Parse(txtSoTKNH.Text.Trim());
                int maxe = int.Parse(cbMaXe.SelectedValue.ToString());
                string tenxe = txtTenXe.Text.Trim();
                string chatluong = cbChatLuong.Text.Trim();
                int gia= int.Parse(txtGia.Text.Trim());
                DateTime ngaythue = dtpNgayThue.Value;
                DateTime ngaytra = dtpNgayTra.Value;
               

                ThueXe tx = new ThueXe();
                tx.Email = email;
                tx.MaTX = matx;
                tx.MaKH = makh;
                tx.NgaySinh = ngaysinh;
                tx.CMND = socmnd;
                tx.GioiTinh = gioitinh;
                tx.DiaChi = diachi;
                tx.SoTKNH = sotknh;
                tx.MaXe = maxe;
                tx.TenXe = tenxe;
                tx.ChatLuong = chatluong;
                tx.GiaThue = gia;
                tx.NgayThue = ngaythue;
                tx.NgayTra = ngaytra;
                txDAO.Insert(tx);
                dgvDanhSach.DataSource = txDAO.getList();
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
                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    throw new Exception("Tên không để trống");
                }
                if (string.IsNullOrEmpty(txtSoCMND.Text.Trim()))
                {
                    throw new Exception("Số CMND ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
                {
                    throw new Exception("Địa chỉ ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtSoTKNH.Text.Trim()))
                {
                    throw new Exception("Số Tài khoản ngân hàng ko đc để trống");
                }

                if (string.IsNullOrEmpty(txtTenXe.Text.Trim()))
                {
                    throw new Exception("Tên xe ko được để trống");
                }
                if (string.IsNullOrEmpty(txtGia.Text.Trim()))
                {
                    throw new Exception("Giá xe ko được để trống");
                }

                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    throw new Exception("Email ko được để trống");
                }
                string email = txtEmail.Text.Trim();
                int makh = int.Parse(cbMaKH.SelectedValue.ToString());
                int matx = int.Parse(txtMaTX.Text.Trim());
                DateTime ngaysinh = dtpNgaySinh.Value;
                int socmnd = int.Parse(txtSoCMND.Text.Trim());
                string gioitinh = cbGioiTinh.Text.Trim();
                string diachi = txtDiaChi.Text.Trim();
                int sotknh = int.Parse(txtSoTKNH.Text.Trim());
                int maxe = int.Parse(cbMaXe.SelectedValue.ToString());
                string tenxe = txtTenXe.Text.Trim();
                string chatluong = cbChatLuong.Text.Trim();
                int gia = int.Parse(txtGia.Text.Trim());
                DateTime ngaythue = dtpNgayThue.Value;
                DateTime ngaytra = dtpNgayTra.Value;



                ThueXe tx = txDAO.getRow(matx);  
                tx.Email = email;
                tx.MaKH = makh;
                tx.NgaySinh = ngaysinh;
                tx.CMND = socmnd;
                tx.GioiTinh = gioitinh;
                tx.DiaChi = diachi;
                tx.SoTKNH = sotknh;
                tx.MaXe = maxe;
                tx.TenXe = tenxe;
                tx.ChatLuong = chatluong;
                tx.GiaThue = gia;
                tx.NgayThue = ngaythue;
                tx.NgayTra = ngaytra;
                txDAO.Update(tx);
                dgvDanhSach.DataSource = txDAO.getList();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maxe = int.Parse(txtMaTX.Text.Trim());
            ThueXe tx = txDAO.getRow(maxe);
            txDAO.Delete(tx);
            dgvDanhSach.DataSource = txDAO.getList();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain.tabcontrol.TabPages.Remove(frmMain.tabcontrol.TabPages["tbThueXe"]);
        }
        private void OnOff(bool value)
        {
            txtMaTX.Enabled = value;

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OnOff(false);
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                int vt = e.RowIndex;
                txtEmail.Text = dgvDanhSach.Rows[vt].Cells["Email"].Value.ToString();
                cbMaKH.Text = dgvDanhSach.Rows[vt].Cells["MaKH"].Value.ToString();
                txtMaTX.Text = dgvDanhSach.Rows[vt].Cells["MaTX"].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSach.Rows[vt].Cells["NgaySinh"].Value.ToString();
                cbGioiTinh.Text = dgvDanhSach.Rows[vt].Cells["GioiTinh"].Value.ToString();
                txtSoCMND.Text=dgvDanhSach.Rows[vt].Cells["CMND"].Value.ToString();
                txtDiaChi.Text = dgvDanhSach.Rows[vt].Cells["DiaChi"].Value.ToString();
                txtSoTKNH.Text = dgvDanhSach.Rows[vt].Cells["SoTKNH"].Value.ToString();
                txtMaTX.Text = dgvDanhSach.Rows[vt].Cells["MaTX"].Value.ToString();
                txtTenXe.Text = dgvDanhSach.Rows[vt].Cells["TenXe"].Value.ToString();
                cbChatLuong.Text = dgvDanhSach.Rows[vt].Cells["ChatLuong"].Value.ToString();
                txtGia.Text = dgvDanhSach.Rows[vt].Cells["GiaThue"].Value.ToString();
                dtpNgayThue.Text = dgvDanhSach.Rows[vt].Cells["NgayThue"].Value.ToString();
                dtpNgayTra.Text = dgvDanhSach.Rows[vt].Cells["NgayTra"].Value.ToString();

            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

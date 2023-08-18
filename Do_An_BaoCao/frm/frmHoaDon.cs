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
    public partial class frmHoaDon : Form
    {
        public string AddOrEdit;
        private HoaDonDAO hdDAO = new HoaDonDAO();
        private KhachHangDAO khDAO = new KhachHangDAO();
        private XeDapDAO xdDAO = new XeDapDAO();
        public frmHoaDon()
        {
            InitializeComponent();
        }

       

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtMaHD.Text.Trim()))
                {
                    throw new Exception(" MÃ hoá đơn không được để trống");
                }
               

               
                if (string.IsNullOrEmpty(txtTenXe.Text.Trim()))
                {
                    throw new Exception("Tên KH ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtGia.Text.Trim()))
                {
                    throw new Exception("Giá  ko đc để trống");
                }

                int mahd = int.Parse(txtMaHD.Text.Trim());
                int makh = int.Parse(cbMaKH.SelectedValue.ToString());
                string hotenkh = txtHoTenKH.Text.Trim();
                int maxe = int.Parse(cbMaXe.SelectedValue.ToString());
                string tenxe = txtTenXe.Text.Trim();
                string loaixe = cbLoaiXe.Text.Trim();
                string chatluong = cbChatLuong.Text.Trim();
                DateTime ngaythue = dtpNgayThue.Value;
                DateTime ngaytra = dtpNgayTra.Value;
                int gia = int.Parse(txtGia.Text.Trim());


                HoaDon hd = new HoaDon();
                hd.MaHD = mahd;
                hd.MaKH = makh;
                hd.TenKH = hotenkh;
                hd.MaXe = maxe;
                hd.TenXe = tenxe;
                hd.LoaiXe = loaixe;
                hd.ChatLuong = chatluong;
                hd.NgayThue = ngaythue;
                hd.NgayTra = ngaytra;
                hd.GiaThue = gia;
                hdDAO.Insert(hd);
                dgvDanhSach.DataSource = hdDAO.getList();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo");
            }
        }
        private void OnOff(bool value)
        {
            txtMaHD.Enabled = value;

        }


        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadMaXe();
            loadKH();
            dgvDanhSach.DataSource = hdDAO.getList();
            OnOff(true);

        }

        private void loadMaXe()
        {
            txtTenXe.Enabled = false;
            cbMaXe.DataSource = xdDAO.getList();
            cbMaXe.DisplayMember = "TenXe";
            cbMaXe.ValueMember = "MaXe";
            txtTenXe.DataBindings.Add(new Binding("Text", cbMaXe.DataSource, "TenXe"));
        }

        private void loadKH()
        {
            txtHoTenKH.Enabled = false;
            cbMaKH.DataSource = khDAO.getList();
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.ValueMember = "MaKH";
            txtHoTenKH.DataBindings.Add(new Binding("Text", cbMaKH.DataSource, "MaKH"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain.tabcontrol.TabPages.Remove(frmMain.tabcontrol.TabPages["tbHoaDon"]);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mahd = int.Parse(txtMaHD.Text.Trim());
            HoaDon hd = hdDAO.getRow(mahd);
            hdDAO.Delete(hd);
           
            dgvDanhSach.DataSource = hdDAO.getList();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtMaHD.Text.Trim()))
                {
                    throw new Exception(" MÃ hoá đơn không được để trống");
                }



                if (string.IsNullOrEmpty(txtTenXe.Text.Trim()))
                {
                    throw new Exception("Tên KH ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtGia.Text.Trim()))
                {
                    throw new Exception("Giá  ko đc để trống");
                }

                int mahd = int.Parse(txtMaHD.Text.Trim());
                int makh = int.Parse(cbMaKH.SelectedValue.ToString());
                string hotenkh = txtHoTenKH.Text.Trim();
                int maxe = int.Parse(cbMaXe.SelectedValue.ToString());
                string tenxe = txtTenXe.Text.Trim();
                string loaixe = cbLoaiXe.Text.Trim();
                string chatluong = cbChatLuong.Text.Trim();
                DateTime ngaythue = dtpNgayThue.Value;
                DateTime ngaytra = dtpNgayTra.Value;
                int gia = int.Parse(txtGia.Text.Trim());



                HoaDon hd = hdDAO.getRow(mahd);
                hd.MaKH = makh;
                hd.TenKH = hotenkh;
                hd.MaXe = maxe;
                hd.TenXe = tenxe;
                hd.LoaiXe = loaixe;
                hd.ChatLuong = chatluong;
                hd.NgayThue = ngaythue;
                hd.NgayTra = ngaytra;
                hd.GiaThue = gia;

                hdDAO.Update(hd);
                dgvDanhSach.DataSource = hdDAO.getList();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo");
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OnOff(false);
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                int vt = e.RowIndex;
                txtMaHD.Text = dgvDanhSach.Rows[vt].Cells["MaHD"].Value.ToString();
                cbMaKH.Text = dgvDanhSach.Rows[vt].Cells["MaKH"].Value.ToString();
                txtHoTenKH.Text = dgvDanhSach.Rows[vt].Cells["HoTenKH"].Value.ToString();
                cbMaXe.Text = dgvDanhSach.Rows[vt].Cells["MaXe"].Value.ToString();
                txtTenXe.Text = dgvDanhSach.Rows[vt].Cells["TenXe"].Value.ToString();
                cbLoaiXe.Text = dgvDanhSach.Rows[vt].Cells["LoaiXe"].Value.ToString();
                cbChatLuong.Text = dgvDanhSach.Rows[vt].Cells["ChatLuong"].Value.ToString();
                dtpNgayThue.Text = dgvDanhSach.Rows[vt].Cells["NgayThue"].Value.ToString();
                dtpNgayTra.Text = dgvDanhSach.Rows[vt].Cells["NgayTra"].Value.ToString();
                txtGia.Text = dgvDanhSach.Rows[vt].Cells["GiaThue"].Value.ToString();
            }
        }
    }
}

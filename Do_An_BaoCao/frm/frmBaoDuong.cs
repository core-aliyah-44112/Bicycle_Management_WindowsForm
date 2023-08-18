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
    public partial class frmBaoDuong : Form
    {
        public string AddOrEdit;
        private BaoDuongDAO bdDAO = new BaoDuongDAO();
        public frmBaoDuong()
        {
            InitializeComponent();
        }
        private void OnOff(bool value)
        {
            txtMaBD.Enabled = value;

        }
        private void frmBaoDuong_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = bdDAO.getList();
            OnOff(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mabd = int.Parse(txtMaBD.Text.Trim());
            BaoDuong bd = bdDAO.getRow(mabd);
            bdDAO.Delete(bd);

            dgvDanhSach.DataSource = bdDAO.getList();
            MessageBox.Show("Xóa thành công", "Thông báo");
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            /**/
            try
            {
                if (string.IsNullOrEmpty(txtMaBD.Text.Trim()))
                {
                    throw new Exception("Mã BD không để trống");
                }
                if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
                {
                    throw new Exception("Mã  NV không để trống");
                }
                if (string.IsNullOrEmpty(txtTenXe.Text.Trim()))
                {
                    throw new Exception("Tên xe không để trống");
                }

                if (string.IsNullOrEmpty(txtMaXe.Text.Trim()))
                {
                    throw new Exception("Mã xe ko được để trống");
                }

                int mabd = int.Parse(txtMaBD.Text.Trim());
                int manv = int.Parse(txtMaNV.Text.Trim());
                int mapb = int.Parse(cbMaPB.Text.Trim());

                string tenxe = txtTenXe.Text.Trim();
                int maxe = int.Parse(txtMaXe.Text.Trim());
                string loaixe = cbLoaiXe.Text.Trim();
                string chatluong = cbChatLuong.Text.Trim();

                DateTime ngaybd = dtpNgayBD.Value;

                BaoDuong bd = bdDAO.getRow(mabd); 
                bd.MaBD = mabd;
                bd.MaNV = manv;
                bd.MaPB = mapb;

                bd.TenXe = tenxe;
                bd.MaXe = maxe;
                bd.LoaiXe = loaixe;
                bd.ChatLuong = chatluong;

                bd.NgayBD = ngaybd;

                bdDAO.Update(bd);
                dgvDanhSach.DataSource = bdDAO.getList();
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
                txtMaBD.Text = dgvDanhSach.Rows[vt].Cells["MaBD"].Value.ToString();
                txtMaNV.Text = dgvDanhSach.Rows[vt].Cells["MaNV"].Value.ToString();
                cbMaPB.Text = dgvDanhSach.Rows[vt].Cells["MaPB"].Value.ToString();
                txtTenXe.Text = dgvDanhSach.Rows[vt].Cells["TenXe"].Value.ToString();
                cbLoaiXe.Text = dgvDanhSach.Rows[vt].Cells["LoaiXe"].Value.ToString();
                txtMaXe.Text = dgvDanhSach.Rows[vt].Cells["MaXe"].Value.ToString();
                cbChatLuong.Text = dgvDanhSach.Rows[vt].Cells["ChatLuong"].Value.ToString();
                dtpNgayBD.Text = dgvDanhSach.Rows[vt].Cells["NgayBD"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaBD.Text.Trim()))
                {
                    throw new Exception("Mã BD không để trống");
                }
                if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
                {
                    throw new Exception("Mã  NV không để trống");
                }
                if (string.IsNullOrEmpty(txtTenXe.Text.Trim()))
                {
                    throw new Exception("Tên xe không để trống");
                }
              
                if (string.IsNullOrEmpty(txtMaXe.Text.Trim()))
                {
                    throw new Exception("Mã xe ko được để trống");
                }

                int mabd = int.Parse(txtMaBD.Text.Trim());
                int manv = int.Parse(txtMaNV.Text.Trim());
                int mapb = int.Parse(cbMaPB.Text.Trim());

                string tenxe = txtTenXe.Text.Trim();
                int maxe = int.Parse(txtMaXe.Text.Trim());
                string loaixe = cbLoaiXe.Text.Trim();
                string chatluong = cbChatLuong.Text.Trim();

                DateTime ngaybd = dtpNgayBD.Value;


                BaoDuong bd = new BaoDuong();
                bd.MaBD = mabd;
                bd.MaNV = manv;
                bd.MaPB = mapb;
                
                bd.TenXe = tenxe;
                bd.MaXe = maxe;
                bd.LoaiXe = loaixe;
                bd.ChatLuong = chatluong;
               
                bd.NgayBD = ngaybd;
               
                bdDAO.Insert(bd);
                dgvDanhSach.DataSource = bdDAO.getList();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain.tabcontrol.TabPages.Remove(frmMain.tabcontrol.TabPages["tbBaoDuong"]);
        }
    }
}

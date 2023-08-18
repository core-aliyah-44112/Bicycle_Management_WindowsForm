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
    public partial class frmXedap : Form
    {
        public string AddOrEdit;
        private XeDapDAO xdDAO = new XeDapDAO();
        public frmXedap()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaXe.Text.Trim()))
                {
                    throw new Exception("Mã không đúng");
                }
                if (string.IsNullOrEmpty(txtTenXe.Text.Trim()))
                {
                    throw new Exception(" tên không được để trống");
                }
                if (string.IsNullOrEmpty(cbLoaiXe.Text.Trim()))
                {
                    throw new Exception("Loại xe ko đc để trống");
                }
                if (string.IsNullOrEmpty(cbMaNSX.Text.Trim()))
                {
                    throw new Exception("Mã nhà sản xuất ko đc để trống");
                }
                if (string.IsNullOrEmpty(cbChatLuong.Text.Trim()))
                {
                    throw new Exception("Chất lượng xe ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtGia.Text.Trim()))
                {
                    throw new Exception("Giá phải là số");
                }
                int maxe = int.Parse(txtMaXe.Text.Trim());

                string tenxe = txtTenXe.Text.Trim();
                string loaixe = cbLoaiXe.Text.Trim();
                string chatuong = cbChatLuong.Text.Trim();
                int mansx = int.Parse(cbMaNSX.Text.Trim());
                string giathue = txtGia.Text.Trim();


                XeDap xd = new XeDap();
                xd.MaXe = maxe;
                xd.MaNSX = mansx;
                xd.TenXe = tenxe;
                xd.LoaiXe = loaixe;
                xd.ChatLuong = chatuong;
                xdDAO.Insert(xd);
               
                dgvDanhSach.DataSource = xdDAO.getList();
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
                if (string.IsNullOrEmpty(txtMaXe.Text.Trim()))
                {
                    throw new Exception("Mã không đúng");
                }

                if (string.IsNullOrEmpty(txtTenXe.Text.Trim()))
                {
                    throw new Exception(" tên không được để trống");
                }
                if (string.IsNullOrEmpty(cbLoaiXe.Text.Trim()))
                {
                    throw new Exception("Loại xe ko đc để trống");
                }
                if (string.IsNullOrEmpty(cbMaNSX.Text.Trim()))
                {
                    throw new Exception("Mã nhà sản xuất ko đc để trống");
                }
                if (string.IsNullOrEmpty(cbChatLuong.Text.Trim()))
                {
                    throw new Exception("Chất lượng xe ko đc để trống");
                }
                if (string.IsNullOrEmpty(txtGia.Text.Trim()))
                {
                    throw new Exception("Giá phải là số");
                }
                int maxe = int.Parse(txtMaXe.Text.Trim());


                string tenxe = txtTenXe.Text.Trim();
                string loaixe = cbLoaiXe.Text.Trim();
                string chatuong = cbChatLuong.Text.Trim();
                int mansx = int.Parse(cbMaNSX.Text.Trim());


                XeDap xd = xdDAO.getRow(maxe);
                xd.MaNSX = mansx;
                xd.TenXe = tenxe;
                xd.LoaiXe = loaixe;
                xd.ChatLuong = chatuong;
                xdDAO.Update(xd);
               
                dgvDanhSach.DataSource = xdDAO.getList();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "thông báo");
            }
        }

        private void OnOff(bool value)
        {
            txtMaXe.Enabled = value;

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OnOff(false);
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                int vt = e.RowIndex;
                txtMaXe.Text = dgvDanhSach.Rows[vt].Cells["MaXe"].Value.ToString();
                txtTenXe.Text = dgvDanhSach.Rows[vt].Cells["TenXe"].Value.ToString();
                cbMaNSX.Text = dgvDanhSach.Rows[vt].Cells["MaNSX"].Value.ToString();
                cbLoaiXe.Text = dgvDanhSach.Rows[vt].Cells["LoaiXe"].Value.ToString();
                cbChatLuong.Text = dgvDanhSach.Rows[vt].Cells["ChatLuong"].Value.ToString();
                txtGia.Text = dgvDanhSach.Rows[vt].Cells["GiaThue"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maxe = int.Parse(txtMaXe.Text.Trim());
            XeDap xd = xdDAO.getRow(maxe);
            xdDAO.Delete(xd);
            
            dgvDanhSach.DataSource = xdDAO.getList();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain.tabcontrol.TabPages.Remove(frmMain.tabcontrol.TabPages["tbXeDap"]);
        }



        private void frmXedap_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = xdDAO.getList();
            OnOff(true);

        }


    }
}
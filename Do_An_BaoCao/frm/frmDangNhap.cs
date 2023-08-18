using Do_An_BaoCao.DAO;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = MaHoa.ToMD5(txtPassWord.Text.Trim());
            ThanhVienDAO thanhvienDAO = new ThanhVienDAO();
            ThanhVien tv = thanhvienDAO.getRow(username);
            if (tv == null)
            {
                lblThongBao.Text = "Tài khoản không tồn tại";
            }
            else
            {
                if (tv.MatKhau == password)
                {
                    frmMain.thanhvien = tv;
                    this.Close();
                }
                else
                {
                    lblThongBao.Text = "Mật khẩu không đúng !!!";
                }
            }
        }
    }
}

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
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //thành viên đang đăng nhập
                ThanhVien thanhvien = frmMain.thanhvien;
                string matkhaucu = MaHoa.ToMD5(txtMatKhau.Text.Trim());
                if (!thanhvien.MatKhau.Equals(matkhaucu))
                {
                    throw new Exception("Mật khẩu cũ không chính xác");
                }
                if (!txtMatKhauMoi.Text.Trim().Equals(txtMatKhauMoi.Text.Trim()))
                {
                    throw new Exception("Mật khẩu mới không khớp");
                }
                string matkhaumoi = MaHoa.ToMD5(txtMatKhauMoi.Text.Trim());
                thanhvien.MatKhau = matkhaumoi;
                ThanhVienDAO tvDAO = new ThanhVienDAO();
                tvDAO.Update(thanhvien);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain.tabcontrol.TabPages.Remove(frmMain.tabcontrol.TabPages["tbDoiMK"]);
        }
    }
}

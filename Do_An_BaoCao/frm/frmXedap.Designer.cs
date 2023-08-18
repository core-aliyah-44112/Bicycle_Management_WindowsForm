
namespace Do_An_BaoCao.frm
{
    partial class frmXedap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbChatLuong = new System.Windows.Forms.ComboBox();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.cbMaNSX = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.MaXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(896, 92);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(734, 35);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(525, 35);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(307, 35);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(103, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChatLuong);
            this.groupBox1.Controls.Add(this.cbLoaiXe);
            this.groupBox1.Controls.Add(this.cbMaNSX);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTenXe);
            this.groupBox1.Controls.Add(this.txtMaXe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 224);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbChatLuong
            // 
            this.cbChatLuong.FormattingEnabled = true;
            this.cbChatLuong.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "Trung bình"});
            this.cbChatLuong.Location = new System.Drawing.Point(538, 96);
            this.cbChatLuong.Name = "cbChatLuong";
            this.cbChatLuong.Size = new System.Drawing.Size(247, 24);
            this.cbChatLuong.TabIndex = 9;
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Items.AddRange(new object[] {
            "Xe thồ",
            "Xe đua",
            "Xe leo núi",
            "Xe trẻ em",
            "Xe TP"});
            this.cbLoaiXe.Location = new System.Drawing.Point(538, 41);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(247, 24);
            this.cbLoaiXe.TabIndex = 8;
            // 
            // cbMaNSX
            // 
            this.cbMaNSX.FormattingEnabled = true;
            this.cbMaNSX.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbMaNSX.Location = new System.Drawing.Point(103, 159);
            this.cbMaNSX.Name = "cbMaNSX";
            this.cbMaNSX.Size = new System.Drawing.Size(247, 24);
            this.cbMaNSX.TabIndex = 7;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(538, 166);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(247, 22);
            this.txtGia.TabIndex = 6;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(103, 96);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(247, 22);
            this.txtTenXe.TabIndex = 5;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(103, 29);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(247, 22);
            this.txtMaXe.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giá thuê";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã NSX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chất lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã xe";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXE,
            this.TenXe,
            this.MaNSX,
            this.LoaiXe,
            this.ChatLuong,
            this.GiaThue});
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 18);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(890, 351);
            this.dgvDanhSach.TabIndex = 22;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // MaXE
            // 
            this.MaXE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaXE.DataPropertyName = "MaXe";
            this.MaXE.HeaderText = "Mã xe";
            this.MaXE.MinimumWidth = 6;
            this.MaXE.Name = "MaXE";
            // 
            // TenXe
            // 
            this.TenXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenXe.DataPropertyName = "TenXe";
            this.TenXe.HeaderText = "Tên xe";
            this.TenXe.MinimumWidth = 6;
            this.TenXe.Name = "TenXe";
            // 
            // MaNSX
            // 
            this.MaNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNSX.DataPropertyName = "MaNSX";
            this.MaNSX.HeaderText = "Mã NSX";
            this.MaNSX.MinimumWidth = 6;
            this.MaNSX.Name = "MaNSX";
            // 
            // LoaiXe
            // 
            this.LoaiXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiXe.DataPropertyName = "LoaiXe";
            this.LoaiXe.HeaderText = "Loại Xe";
            this.LoaiXe.MinimumWidth = 6;
            this.LoaiXe.Name = "LoaiXe";
            // 
            // ChatLuong
            // 
            this.ChatLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChatLuong.DataPropertyName = "ChatLuong";
            this.ChatLuong.HeaderText = "Chất lượng";
            this.ChatLuong.MinimumWidth = 6;
            this.ChatLuong.Name = "ChatLuong";
            // 
            // GiaThue
            // 
            this.GiaThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaThue.DataPropertyName = "GiaThue";
            this.GiaThue.HeaderText = "Giá thuê";
            this.GiaThue.MinimumWidth = 6;
            this.GiaThue.Name = "GiaThue";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSach);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 377);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(896, 372);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "QUẢN LÝ XE ĐẠP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 61);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 724);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 25);
            this.panel2.TabIndex = 25;
            // 
            // frmXedap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmXedap";
            this.Load += new System.EventHandler(this.frmXedap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChatLuong;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.ComboBox cbMaNSX;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
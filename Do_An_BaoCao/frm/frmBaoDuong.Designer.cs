
namespace Do_An_BaoCao.frm
{
    partial class frmBaoDuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaBD = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.cbMaPB = new System.Windows.Forms.ComboBox();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbChatLuong = new System.Windows.Forms.ComboBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.MaBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN BẢO DƯỠNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã BD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Loại xe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã PB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chất lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(579, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày BD";
            // 
            // txtMaBD
            // 
            this.txtMaBD.Location = new System.Drawing.Point(83, 20);
            this.txtMaBD.Name = "txtMaBD";
            this.txtMaBD.Size = new System.Drawing.Size(167, 22);
            this.txtMaBD.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(83, 100);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(167, 22);
            this.txtMaNV.TabIndex = 10;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(366, 23);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(167, 22);
            this.txtTenXe.TabIndex = 11;
            // 
            // cbMaPB
            // 
            this.cbMaPB.FormattingEnabled = true;
            this.cbMaPB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbMaPB.Location = new System.Drawing.Point(83, 173);
            this.cbMaPB.Name = "cbMaPB";
            this.cbMaPB.Size = new System.Drawing.Size(167, 24);
            this.cbMaPB.TabIndex = 13;
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Items.AddRange(new object[] {
            "Xe Thồ",
            "Xe Đua",
            "Xe TP",
            "Xe Trẻ Em",
            "Xe Leo Núi"});
            this.cbLoaiXe.Location = new System.Drawing.Point(366, 105);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(167, 24);
            this.cbLoaiXe.TabIndex = 14;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(679, 103);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(167, 22);
            this.dtpNgayBD.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(704, 25);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(513, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(271, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(99, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChatLuong);
            this.groupBox1.Controls.Add(this.txtMaXe);
            this.groupBox1.Controls.Add(this.dtpNgayBD);
            this.groupBox1.Controls.Add(this.cbLoaiXe);
            this.groupBox1.Controls.Add(this.cbMaPB);
            this.groupBox1.Controls.Add(this.txtTenXe);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtMaBD);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 225);
            this.groupBox1.TabIndex = 24;
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
            this.cbChatLuong.Location = new System.Drawing.Point(679, 23);
            this.cbChatLuong.Name = "cbChatLuong";
            this.cbChatLuong.Size = new System.Drawing.Size(167, 24);
            this.cbChatLuong.TabIndex = 18;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(366, 177);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(167, 22);
            this.txtMaXe.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(36, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(865, 79);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBD,
            this.MaNV,
            this.MaXe,
            this.LoaiXe,
            this.TenXe,
            this.ChatLuong,
            this.NgayBD});
            this.dgvDanhSach.Location = new System.Drawing.Point(20, 28);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(816, 216);
            this.dgvDanhSach.TabIndex = 23;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // MaBD
            // 
            this.MaBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaBD.DataPropertyName = "MaBD";
            this.MaBD.HeaderText = "Mã BD";
            this.MaBD.MinimumWidth = 6;
            this.MaBD.Name = "MaBD";
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // MaXe
            // 
            this.MaXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.HeaderText = "Mã xe";
            this.MaXe.MinimumWidth = 6;
            this.MaXe.Name = "MaXe";
            // 
            // LoaiXe
            // 
            this.LoaiXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiXe.DataPropertyName = "LoaiXe";
            this.LoaiXe.HeaderText = "Loại xe";
            this.LoaiXe.MinimumWidth = 6;
            this.LoaiXe.Name = "LoaiXe";
            // 
            // TenXe
            // 
            this.TenXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenXe.DataPropertyName = "TenXe";
            this.TenXe.HeaderText = "Tên xe";
            this.TenXe.MinimumWidth = 6;
            this.TenXe.Name = "TenXe";
            // 
            // ChatLuong
            // 
            this.ChatLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChatLuong.DataPropertyName = "ChatLuong";
            this.ChatLuong.HeaderText = "Chất lượng";
            this.ChatLuong.MinimumWidth = 6;
            this.ChatLuong.Name = "ChatLuong";
            // 
            // NgayBD
            // 
            this.NgayBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayBD.DataPropertyName = "NgayBD";
            this.NgayBD.HeaderText = "Ngày BD";
            this.NgayBD.MinimumWidth = 6;
            this.NgayBD.Name = "NgayBD";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSach);
            this.groupBox3.Location = new System.Drawing.Point(33, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(868, 263);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // frmBaoDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 665);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoDuong";
            this.Load += new System.EventHandler(this.frmBaoDuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaBD;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.ComboBox cbMaPB;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbChatLuong;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
    }
}
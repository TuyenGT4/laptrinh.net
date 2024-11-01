namespace BaiTapQLSV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            clnMaSV = new DataGridViewTextBoxColumn();
            clnTenSV = new DataGridViewTextBoxColumn();
            clnGioiTinh = new DataGridViewTextBoxColumn();
            clnNgaySinh = new DataGridViewTextBoxColumn();
            clnDiaChi = new DataGridViewTextBoxColumn();
            clnEmaili = new DataGridViewTextBoxColumn();
            clnSoDienThoai = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            dtpNgaySinh = new DateTimePicker();
            rbtnNu = new RadioButton();
            rbtnNam = new RadioButton();
            tbSoDienThoai = new TextBox();
            tbDiaChi = new TextBox();
            tbEmail = new TextBox();
            tbMaSV = new TextBox();
            label6 = new Label();
            label1 = new Label();
            lbDiaChi = new Label();
            lblNgaySinh = new Label();
            lbGioiTinh = new Label();
            lbMaSinhVien = new Label();
            lbTen = new Label();
            tbTenSV = new TextBox();
            groupBox3 = new GroupBox();
            btnThoat = new Button();
            btnLuu = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox4 = new GroupBox();
            btnTim = new Button();
            lbTim = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1130, 295);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sinh viên hiện có";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnMaSV, clnTenSV, clnGioiTinh, clnNgaySinh, clnDiaChi, clnEmaili, clnSoDienThoai });
            dataGridView1.Location = new Point(0, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1124, 235);
            dataGridView1.TabIndex = 0;
            // 
            // clnMaSV
            // 
            clnMaSV.HeaderText = "Mã sinh viên";
            clnMaSV.MinimumWidth = 8;
            clnMaSV.Name = "clnMaSV";
            // 
            // clnTenSV
            // 
            clnTenSV.HeaderText = "Tên sinh viên";
            clnTenSV.MinimumWidth = 8;
            clnTenSV.Name = "clnTenSV";
            // 
            // clnGioiTinh
            // 
            clnGioiTinh.HeaderText = "Giới tính";
            clnGioiTinh.MinimumWidth = 8;
            clnGioiTinh.Name = "clnGioiTinh";
            // 
            // clnNgaySinh
            // 
            clnNgaySinh.HeaderText = "Ngày sinh";
            clnNgaySinh.MinimumWidth = 8;
            clnNgaySinh.Name = "clnNgaySinh";
            // 
            // clnDiaChi
            // 
            clnDiaChi.HeaderText = "Địa chỉ";
            clnDiaChi.MinimumWidth = 8;
            clnDiaChi.Name = "clnDiaChi";
            // 
            // clnEmaili
            // 
            clnEmaili.HeaderText = "Email";
            clnEmaili.MinimumWidth = 8;
            clnEmaili.Name = "clnEmaili";
            // 
            // clnSoDienThoai
            // 
            clnSoDienThoai.HeaderText = "Số điện thoại";
            clnSoDienThoai.MinimumWidth = 8;
            clnSoDienThoai.Name = "clnSoDienThoai";
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(dtpNgaySinh);
            groupBox2.Controls.Add(rbtnNu);
            groupBox2.Controls.Add(rbtnNam);
            groupBox2.Controls.Add(tbSoDienThoai);
            groupBox2.Controls.Add(tbDiaChi);
            groupBox2.Controls.Add(tbEmail);
            groupBox2.Controls.Add(tbMaSV);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lbDiaChi);
            groupBox2.Controls.Add(lblNgaySinh);
            groupBox2.Controls.Add(lbGioiTinh);
            groupBox2.Controls.Add(lbMaSinhVien);
            groupBox2.Controls.Add(lbTen);
            groupBox2.Controls.Add(tbTenSV);
            groupBox2.Location = new Point(12, 429);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1124, 213);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sinh viên";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(140, 102);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(150, 31);
            dtpNgaySinh.TabIndex = 16;
            // 
            // rbtnNu
            // 
            rbtnNu.AutoSize = true;
            rbtnNu.Location = new Point(995, 46);
            rbtnNu.Name = "rbtnNu";
            rbtnNu.Size = new Size(61, 29);
            rbtnNu.TabIndex = 15;
            rbtnNu.TabStop = true;
            rbtnNu.Text = "Nữ";
            rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            rbtnNam.AutoSize = true;
            rbtnNam.Location = new Point(914, 46);
            rbtnNam.Name = "rbtnNam";
            rbtnNam.Size = new Size(75, 29);
            rbtnNam.TabIndex = 14;
            rbtnNam.TabStop = true;
            rbtnNam.Text = "Nam";
            rbtnNam.UseVisualStyleBackColor = true;
            // 
            // tbSoDienThoai
            // 
            tbSoDienThoai.Location = new Point(551, 152);
            tbSoDienThoai.Name = "tbSoDienThoai";
            tbSoDienThoai.Size = new Size(150, 31);
            tbSoDienThoai.TabIndex = 13;
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(551, 99);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(150, 31);
            tbDiaChi.TabIndex = 12;
            tbDiaChi.TextChanged += tbDiaChi_TextChanged;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(139, 149);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(150, 31);
            tbEmail.TabIndex = 11;
            // 
            // tbMaSV
            // 
            tbMaSV.Location = new Point(140, 43);
            tbMaSV.Name = "tbMaSV";
            tbMaSV.Size = new Size(150, 31);
            tbMaSV.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(422, 155);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 8;
            label6.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 155);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 6;
            label1.Text = "Email";
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(418, 102);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(65, 25);
            lbDiaChi.TabIndex = 5;
            lbDiaChi.Text = "Địa chỉ";
            lbDiaChi.Click += lbDiaChi_Click;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(23, 102);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(91, 25);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh";
            lblNgaySinh.Click += lblNgaySinh_Click;
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.AutoSize = true;
            lbGioiTinh.Location = new Point(813, 46);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(78, 25);
            lbGioiTinh.TabIndex = 3;
            lbGioiTinh.Text = "Giới tính";
            // 
            // lbMaSinhVien
            // 
            lbMaSinhVien.AutoSize = true;
            lbMaSinhVien.Location = new Point(23, 46);
            lbMaSinhVien.Name = "lbMaSinhVien";
            lbMaSinhVien.Size = new Size(111, 25);
            lbMaSinhVien.TabIndex = 2;
            lbMaSinhVien.Text = "Mã sinh viên";
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.Location = new Point(422, 46);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(89, 25);
            lbTen.TabIndex = 1;
            lbTen.Text = "Họ và tên";
            // 
            // tbTenSV
            // 
            tbTenSV.Location = new Point(551, 43);
            tbTenSV.Name = "tbTenSV";
            tbTenSV.Size = new Size(150, 31);
            tbTenSV.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnLamMoi);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(12, 648);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1130, 109);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(941, 48);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(766, 48);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(592, 48);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(112, 34);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(418, 48);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(244, 48);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(70, 48);
            btnThem.Margin = new Padding(50);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnTim);
            groupBox4.Controls.Add(lbTim);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Location = new Point(12, 313);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1124, 110);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm sinh viên";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(713, 46);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(112, 34);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += button1_Click_1;
            // 
            // lbTim
            // 
            lbTim.AutoSize = true;
            lbTim.Location = new Point(207, 51);
            lbTim.Name = "lbTim";
            lbTim.Size = new Size(222, 25);
            lbTim.TabIndex = 1;
            lbTim.Text = "Nhập mã sinh viên cần tìm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(449, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 31);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1153, 770);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clnMaSV;
        private DataGridViewTextBoxColumn clnTenSV;
        private DataGridViewTextBoxColumn clnGioiTinh;
        private DataGridViewTextBoxColumn clnNgaySinh;
        private DataGridViewTextBoxColumn clnDiaChi;
        private DataGridViewTextBoxColumn clnEmaili;
        private DataGridViewTextBoxColumn clnSoDienThoai;
        private GroupBox groupBox2;
        private TextBox tbTenSV;
        private Label label6;
        private Label lbDiaChi;
        private Label lblNgaySinh;
        private Label lbGioiTinh;
        private Label lbMaSinhVien;
        private Label lbTen;
        private RadioButton rbtnNu;
        private RadioButton rbtnNam;
        private TextBox tbSoDienThoai;
        private TextBox tbDiaChi;
        private TextBox tbEmail;
        private TextBox tbMaSV;
        private GroupBox groupBox3;
        private Button btnThoat;
        private Button btnLuu;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private GroupBox groupBox4;
        private Button btnTim;
        private Label lbTim;
        private TextBox textBox1;
        private DateTimePicker dtpNgaySinh;
    }
}

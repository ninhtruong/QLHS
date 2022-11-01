
namespace QLHS
{
    partial class Student
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
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTBHK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTBHK2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbClassType = new System.Windows.Forms.ComboBox();
            this.lblClassType = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.lblTenHS = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblDTBHK1 = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDTBHK2 = new System.Windows.Forms.Label();
            this.lblKhoi = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.DateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtKhoi = new System.Windows.Forms.TextBox();
            this.txtDTBHK2 = new System.Windows.Forms.TextBox();
            this.txtDTBHK1 = new System.Windows.Forms.TextBox();
            this.btnThemHS = new System.Windows.Forms.Button();
            this.btnSuaHS = new System.Windows.Forms.Button();
            this.btnXoaHS = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataStudent
            // 
            this.dataStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHocSinh,
            this.TenHocSinh,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.DTBHK1,
            this.DTBHK2,
            this.Lop,
            this.Khoi});
            this.dataStudent.Location = new System.Drawing.Point(12, 278);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.RowHeadersWidth = 51;
            this.dataStudent.RowTemplate.Height = 24;
            this.dataStudent.Size = new System.Drawing.Size(1364, 483);
            this.dataStudent.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.HeaderText = "Mã Học Sinh";
            this.MaHocSinh.MinimumWidth = 6;
            this.MaHocSinh.Name = "MaHocSinh";
            // 
            // TenHocSinh
            // 
            this.TenHocSinh.HeaderText = "Tên Học Sinh";
            this.TenHocSinh.MinimumWidth = 6;
            this.TenHocSinh.Name = "TenHocSinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // DTBHK1
            // 
            this.DTBHK1.HeaderText = "Điểm TBHK1";
            this.DTBHK1.MinimumWidth = 6;
            this.DTBHK1.Name = "DTBHK1";
            // 
            // DTBHK2
            // 
            this.DTBHK2.HeaderText = "Điểm TBHK2";
            this.DTBHK2.MinimumWidth = 6;
            this.DTBHK2.Name = "DTBHK2";
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            // 
            // Khoi
            // 
            this.Khoi.HeaderText = "Khối";
            this.Khoi.MinimumWidth = 6;
            this.Khoi.Name = "Khoi";
            // 
            // cbClassType
            // 
            this.cbClassType.FormattingEnabled = true;
            this.cbClassType.Location = new System.Drawing.Point(124, 103);
            this.cbClassType.Name = "cbClassType";
            this.cbClassType.Size = new System.Drawing.Size(125, 24);
            this.cbClassType.TabIndex = 3;
            // 
            // lblClassType
            // 
            this.lblClassType.AutoSize = true;
            this.lblClassType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassType.Location = new System.Drawing.Point(12, 103);
            this.lblClassType.Name = "lblClassType";
            this.lblClassType.Size = new System.Drawing.Size(106, 20);
            this.lblClassType.TabIndex = 4;
            this.lblClassType.Text = "Chọn loại lớp";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(12, 157);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(75, 20);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Chọn lớp";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(124, 153);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(125, 24);
            this.cbClass.TabIndex = 6;
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHS.Location = new System.Drawing.Point(298, 103);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(106, 20);
            this.lblMaHS.TabIndex = 7;
            this.lblMaHS.Text = "Mã Học Sinh";
            // 
            // lblTenHS
            // 
            this.lblTenHS.AutoSize = true;
            this.lblTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHS.Location = new System.Drawing.Point(298, 161);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(111, 20);
            this.lblTenHS.TabIndex = 8;
            this.lblTenHS.Text = "Tên Học Sinh";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(592, 103);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(85, 20);
            this.lblNgaySinh.TabIndex = 9;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(947, 163);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(76, 20);
            this.lblGioiTinh.TabIndex = 10;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblDTBHK1
            // 
            this.lblDTBHK1.AutoSize = true;
            this.lblDTBHK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTBHK1.Location = new System.Drawing.Point(1179, 161);
            this.lblDTBHK1.Name = "lblDTBHK1";
            this.lblDTBHK1.Size = new System.Drawing.Size(108, 20);
            this.lblDTBHK1.TabIndex = 11;
            this.lblDTBHK1.Text = "Điểm TBHK1";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(592, 161);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(61, 20);
            this.lblDiaChi.TabIndex = 12;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblDTBHK2
            // 
            this.lblDTBHK2.AutoSize = true;
            this.lblDTBHK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTBHK2.Location = new System.Drawing.Point(1179, 103);
            this.lblDTBHK2.Name = "lblDTBHK2";
            this.lblDTBHK2.Size = new System.Drawing.Size(108, 20);
            this.lblDTBHK2.TabIndex = 13;
            this.lblDTBHK2.Text = "Điểm TBHK2";
            // 
            // lblKhoi
            // 
            this.lblKhoi.AutoSize = true;
            this.lblKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoi.Location = new System.Drawing.Point(947, 101);
            this.lblKhoi.Name = "lblKhoi";
            this.lblKhoi.Size = new System.Drawing.Size(42, 20);
            this.lblKhoi.TabIndex = 14;
            this.lblKhoi.Text = "Khối";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(410, 103);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.ReadOnly = true;
            this.txtMaHS.Size = new System.Drawing.Size(156, 22);
            this.txtMaHS.TabIndex = 15;
            // 
            // txtTenHS
            // 
            this.txtTenHS.Location = new System.Drawing.Point(410, 161);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(156, 22);
            this.txtTenHS.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(680, 161);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(239, 22);
            this.txtDiaChi.TabIndex = 18;
            // 
            // DateNgaySinh
            // 
            this.DateNgaySinh.Location = new System.Drawing.Point(680, 101);
            this.DateNgaySinh.Name = "DateNgaySinh";
            this.DateNgaySinh.Size = new System.Drawing.Size(239, 22);
            this.DateNgaySinh.TabIndex = 19;
            // 
            // txtKhoi
            // 
            this.txtKhoi.Location = new System.Drawing.Point(1029, 101);
            this.txtKhoi.Name = "txtKhoi";
            this.txtKhoi.Size = new System.Drawing.Size(131, 22);
            this.txtKhoi.TabIndex = 20;
            // 
            // txtDTBHK2
            // 
            this.txtDTBHK2.Location = new System.Drawing.Point(1293, 103);
            this.txtDTBHK2.Name = "txtDTBHK2";
            this.txtDTBHK2.Size = new System.Drawing.Size(83, 22);
            this.txtDTBHK2.TabIndex = 22;
            // 
            // txtDTBHK1
            // 
            this.txtDTBHK1.Location = new System.Drawing.Point(1293, 161);
            this.txtDTBHK1.Name = "txtDTBHK1";
            this.txtDTBHK1.Size = new System.Drawing.Size(83, 22);
            this.txtDTBHK1.TabIndex = 23;
            // 
            // btnThemHS
            // 
            this.btnThemHS.Location = new System.Drawing.Point(951, 208);
            this.btnThemHS.Name = "btnThemHS";
            this.btnThemHS.Size = new System.Drawing.Size(124, 35);
            this.btnThemHS.TabIndex = 24;
            this.btnThemHS.Text = "Thêm Học Sinh";
            this.btnThemHS.UseVisualStyleBackColor = true;
            this.btnThemHS.Click += new System.EventHandler(this.btnThemHS_Click);
            // 
            // btnSuaHS
            // 
            this.btnSuaHS.Location = new System.Drawing.Point(1102, 208);
            this.btnSuaHS.Name = "btnSuaHS";
            this.btnSuaHS.Size = new System.Drawing.Size(124, 35);
            this.btnSuaHS.TabIndex = 25;
            this.btnSuaHS.Text = "Sửa Thông Tin";
            this.btnSuaHS.UseVisualStyleBackColor = true;
            this.btnSuaHS.Click += new System.EventHandler(this.btnSuaHS_Click);
            // 
            // btnXoaHS
            // 
            this.btnXoaHS.Location = new System.Drawing.Point(1252, 208);
            this.btnXoaHS.Name = "btnXoaHS";
            this.btnXoaHS.Size = new System.Drawing.Size(124, 35);
            this.btnXoaHS.TabIndex = 26;
            this.btnXoaHS.Text = "Xóa Thông Tin";
            this.btnXoaHS.UseVisualStyleBackColor = true;
            this.btnXoaHS.Click += new System.EventHandler(this.btnXoaHS_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(18, 208);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(707, 35);
            this.txtTimKiem.TabIndex = 27;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(731, 208);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(124, 35);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(1035, 157);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(125, 24);
            this.cbxGioiTinh.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Danh Sách Học Sinh";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 773);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxGioiTinh);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXoaHS);
            this.Controls.Add(this.btnSuaHS);
            this.Controls.Add(this.btnThemHS);
            this.Controls.Add(this.txtDTBHK1);
            this.Controls.Add(this.txtDTBHK2);
            this.Controls.Add(this.txtKhoi);
            this.Controls.Add(this.DateNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenHS);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lblKhoi);
            this.Controls.Add(this.lblDTBHK2);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblDTBHK1);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblTenHS);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblClassType);
            this.Controls.Add(this.cbClassType);
            this.Controls.Add(this.dataStudent);
            this.Name = "Student";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTBHK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTBHK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoi;
        private System.Windows.Forms.ComboBox cbClassType;
        private System.Windows.Forms.Label lblClassType;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDTBHK1;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDTBHK2;
        private System.Windows.Forms.Label lblKhoi;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker DateNgaySinh;
        private System.Windows.Forms.TextBox txtKhoi;
        private System.Windows.Forms.TextBox txtDTBHK2;
        private System.Windows.Forms.TextBox txtDTBHK1;
        private System.Windows.Forms.Button btnThemHS;
        private System.Windows.Forms.Button btnSuaHS;
        private System.Windows.Forms.Button btnXoaHS;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.Label label1;
    }
}
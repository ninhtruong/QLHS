
namespace QLHS
{
    partial class Class
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
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblSoLuongDat = new System.Windows.Forms.Label();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.cbxHocKy = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.txtSoLuongDat = new System.Windows.Forms.TextBox();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataLopHoc = new System.Windows.Forms.DataGridView();
            this.lblTenLop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(29, 127);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(53, 17);
            this.lblHocKy.TabIndex = 1;
            this.lblHocKy.Text = "Học Kỳ";
            // 
            // lblSoLuongDat
            // 
            this.lblSoLuongDat.AutoSize = true;
            this.lblSoLuongDat.Location = new System.Drawing.Point(895, 128);
            this.lblSoLuongDat.Name = "lblSoLuongDat";
            this.lblSoLuongDat.Size = new System.Drawing.Size(95, 17);
            this.lblSoLuongDat.TabIndex = 6;
            this.lblSoLuongDat.Text = "Số Lượng Đạt";
            // 
            // lblSiSo
            // 
            this.lblSiSo.AutoSize = true;
            this.lblSiSo.Location = new System.Drawing.Point(646, 131);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(39, 17);
            this.lblSiSo.TabIndex = 5;
            this.lblSiSo.Text = "Sĩ số";
            // 
            // cbxHocKy
            // 
            this.cbxHocKy.FormattingEnabled = true;
            this.cbxHocKy.Location = new System.Drawing.Point(88, 125);
            this.cbxHocKy.Name = "cbxHocKy";
            this.cbxHocKy.Size = new System.Drawing.Size(173, 24);
            this.cbxHocKy.TabIndex = 9;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(384, 126);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(173, 22);
            this.txtTenLop.TabIndex = 11;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(712, 128);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(124, 22);
            this.txtSiSo.TabIndex = 12;
            // 
            // txtSoLuongDat
            // 
            this.txtSoLuongDat.Location = new System.Drawing.Point(996, 128);
            this.txtSoLuongDat.Name = "txtSoLuongDat";
            this.txtSoLuongDat.Size = new System.Drawing.Size(124, 22);
            this.txtSoLuongDat.TabIndex = 14;
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(1003, 240);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(124, 35);
            this.btnXoaLop.TabIndex = 29;
            this.btnXoaLop.Text = "Xóa Lớp";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(853, 240);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(124, 35);
            this.btnChiTiet.TabIndex = 28;
            this.btnChiTiet.Text = "Xem Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(702, 240);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(124, 35);
            this.btnThemLop.TabIndex = 27;
            this.btnThemLop.Text = "Thêm Lớp";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(32, 240);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(386, 35);
            this.txtTimKiem.TabIndex = 30;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(447, 240);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(124, 35);
            this.btnTimKiem.TabIndex = 31;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Danh Sách Lớp Học";
            // 
            // dataLopHoc
            // 
            this.dataLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLopHoc.Location = new System.Drawing.Point(12, 299);
            this.dataLopHoc.Name = "dataLopHoc";
            this.dataLopHoc.RowHeadersWidth = 51;
            this.dataLopHoc.RowTemplate.Height = 24;
            this.dataLopHoc.Size = new System.Drawing.Size(1134, 449);
            this.dataLopHoc.TabIndex = 0;
            this.dataLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLopHoc_CellClick);
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(323, 131);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(61, 17);
            this.lblTenLop.TabIndex = 4;
            this.lblTenLop.Text = "Tên Lớp";
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 760);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXoaLop);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.txtSoLuongDat);
            this.Controls.Add(this.txtSiSo);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.cbxHocKy);
            this.Controls.Add(this.lblSoLuongDat);
            this.Controls.Add(this.lblSiSo);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.dataLopHoc);
            this.Name = "Class";
            this.Text = "Class";
            ((System.ComponentModel.ISupportInitialize)(this.dataLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblSoLuongDat;
        private System.Windows.Forms.Label lblSiSo;
        private System.Windows.Forms.ComboBox cbxHocKy;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.TextBox txtSoLuongDat;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataLopHoc;
        private System.Windows.Forms.Label lblTenLop;
    }
}
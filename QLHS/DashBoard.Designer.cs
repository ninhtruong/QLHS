
namespace QLHS
{
    partial class DashBoard
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
            this.btnLop = new System.Windows.Forms.Button();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLop
            // 
            this.btnLop.Location = new System.Drawing.Point(165, 125);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(188, 47);
            this.btnLop.TabIndex = 0;
            this.btnLop.Text = "Quản Lý Lớp";
            this.btnLop.UseVisualStyleBackColor = true;
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Location = new System.Drawing.Point(437, 125);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(222, 47);
            this.btnHocSinh.TabIndex = 1;
            this.btnHocSinh.Text = "Quản Lý Học Sinh";
            this.btnHocSinh.UseVisualStyleBackColor = true;
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Location = new System.Drawing.Point(727, 125);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(188, 47);
            this.btnGiaoVien.TabIndex = 2;
            this.btnGiaoVien.Text = "Quản Lý Giáo Viên";
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Location = new System.Drawing.Point(1008, 125);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(188, 47);
            this.btnXuatBaoCao.TabIndex = 3;
            this.btnXuatBaoCao.Text = "Xuất Báo Cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 553);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.btnGiaoVien);
            this.Controls.Add(this.btnHocSinh);
            this.Controls.Add(this.btnLop);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnHocSinh;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Button btnXuatBaoCao;
    }
}
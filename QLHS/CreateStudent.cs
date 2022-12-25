using QLHS.Common;
using QLHS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class CreateStudent : Form
    {
        public CreateStudent(string TenLop)
        {
            InitializeComponent();
            txtLop.Text = TenLop;
            txtMaHS.Text = ShowData.ShowIDHocSinh().ToString();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            
            var mahs = Convert.ToInt32(txtMaHS.Text);
            var tenhs = txtTenHS.Text;
            var gioitinh = cbxGioiTinh.Text == "Nam"?true:false;
            var diachi = txtDiaChi.Text;
            var email = txtEmail.Text;
            var ngaysinh = Convert.ToDateTime(dateNgaySinh.Text);
            var idlop = ShowData.ShowIDLopHoc(txtLop.Text);
            var hs = new HocSinh
            {
                MaHocSinh = mahs,
                MaLopHoc = idlop,
                HoTen = tenhs,
                GioiTinh = gioitinh.ToString(),
                DiaChi = diachi,
                Email = email,
                NgaySinh = ngaysinh
            };
            if (InsertData.InsertHS(hs) == 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại xem lại thông tin");



        }
    }
}

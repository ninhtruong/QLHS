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
    public partial class CreateClass : Form
    {
        public CreateClass()
        {
            InitializeComponent();
            txtMaLop.Text = ShowData.ShowIDLOP().ToString();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenlop = txtTenLop.Text;
            var khoi = ShowData.ShowIDKhoi(cbKhoi.Text);
            var sisotoida = Convert.ToInt32(txtSiso.Text);
            var lh = new LopHoc
            {
                TenLH = tenlop,
                MaKhoi = khoi,
                SiSoToiDa = sisotoida,
            };
            if (InsertData.InsertLH(lh) == 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại xem lại thông tin");
        }
    }
}

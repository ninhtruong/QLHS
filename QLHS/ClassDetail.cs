using QLHS.Common;
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
    public partial class ClassDetail : Form
    {
        public static string TenLop;
        public ClassDetail(string TenLH)
        {
            InitializeComponent();
            LoadData(TenLH);
        }

        private void LoadData(string TenLH)
        {
            TenLop = TenLH;
            dataHocSinh.DataSource = ShowData.ShowHocSinh(TenLH);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Class form = new Class();
            form.Show();
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CreateStudent form = new CreateStudent(TenLop);
            form.Show();
        }

        private void dataHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataHocSinh.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtMaHS.Text = row.Cells[0].Value.ToString();
                //var y = row.Cells[1].Value.ToString();
                txtNgaySinh.Text = row.Cells[3].Value.ToString();
                txtTenHS.Text = row.Cells[2].Value.ToString();
                txtGioiTinh.Text = row.Cells[4].Value.ToString();
                txtDiaChi.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
                txtLop.Text = TenLop;
                
            }
        }
    }
}

using QLHS.Common;
using QLHS.Data;
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
    public partial class CreatePoint : Form
    {
        public List<HocSinh> hs = new List<HocSinh>();
        public CreatePoint()
        {
            InitializeComponent();
            ShowHocKy();
            ListLopHoc();
            Enable();
        }

        private void ShowHocKy()
        {
            cbxHocKy.DataSource = ShowData.ShowHocKy();
        }

        private void Enable()
        {
            txtHS.ReadOnly = true;
            txtHS.ReadOnly = true;
            txtToan.ReadOnly = true;
            txtNguVan.ReadOnly = true;
            txtVatLy.ReadOnly = true;
            txtHoaHoc.ReadOnly = true;
            txtSinhHoc.ReadOnly = true;
            txtDiaLy.ReadOnly = true;
            txtLichSu.ReadOnly = true;
            txtNgoaiNgu.ReadOnly = true;
            txtCongNghe.ReadOnly = true;
            txtGDCD.ReadOnly = true;
            txtTinHoc.ReadOnly = true;
            txtTheDuc.ReadOnly = true;
            txtXepLoai.ReadOnly = true;
            btnChiTietHocSinh.Visible = false;
        }

        private void ShowLopHoc(string TenLH)
        {
            dataPoint.DataSource = ShowData.ShowLopHoc(TenLH, cbxHocKy.Text);
        }

        private void ListLopHoc()
        {
            cbxLopHoc.DataSource = ShowData.ListLopHoc();
        }

        private void cbxLopHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowLopHoc(cbxLopHoc.Text);
        }

        private void dataPoint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChiTietHocSinh.Visible = true;
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataPoint.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                var x = row.Cells[0].Value.ToString();
                //var y = row.Cells[1].Value.ToString();
                txtHS.Text = row.Cells[1].Value.ToString();
                txtToan.Text = row.Cells[2].Value.ToString();
                txtNguVan.Text = row.Cells[3].Value.ToString();
                txtVatLy.Text = row.Cells[4].Value.ToString();
                txtHoaHoc.Text = row.Cells[5].Value.ToString();
                txtSinhHoc.Text = row.Cells[6].Value.ToString();
                txtDiaLy.Text = row.Cells[7].Value.ToString();
                txtLichSu.Text = row.Cells[8].Value.ToString();
                txtNgoaiNgu.Text = row.Cells[9].Value.ToString();
                txtCongNghe.Text = row.Cells[10].Value.ToString();
                txtGDCD.Text = row.Cells[11].Value.ToString();
                txtTinHoc.Text = row.Cells[12].Value.ToString();
                txtTheDuc.Text = row.Cells[13].Value.ToString();
                txtXepLoai.Text = row.Cells[14].Value.ToString();
            }
        }

        private void btnChiTietHocSinh_Click(object sender, EventArgs e)
        {
            PointDetail form = new PointDetail(txtHS.Text, cbxLopHoc.Text,Convert.ToInt32(cbxHocKy.Text));
            form.Show();
            this.Hide();
        }
    }
}

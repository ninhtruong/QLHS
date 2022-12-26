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
    public partial class Class : Form
    {

        public static List<LopHocToiDa> ListLop;
        public Class()
        {
            InitializeComponent();
            ShowHocKy();
            ListLopHoc();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            CreateClass createlop = new CreateClass();
            createlop.Show();
        }

        private void ShowHocKy()
        {
            cbxHocKy.DataSource = ShowData.ShowHocKy();
        }

        private void ListLopHoc()
        {
            var sql = "SELECT * FROM LOPHOC";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListLopHoc = new List<LopHocToiDa>();
            while (read.Read())
            {
                var tenlophoc = read["TenLH"];
                var siso = read["SiSoToiDa"];
                ListLopHoc.Add(new LopHocToiDa { TenLH = tenlophoc.ToString(), SiSoToiDa = Convert.ToInt32(siso), SiSoHienCo = ShowData.CountLopHoc(tenlophoc.ToString()) });
            }
            ListLop = ListLopHoc;
            dataLopHoc.DataSource = ListLopHoc;
        }

        public class LopHocToiDa
        {
            public string TenLH { get; set; }
            public int SiSoToiDa { get; set; }

            public int SiSoHienCo { get; set; }
        }

        private void dataLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataLopHoc.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtTenLop.Text = row.Cells[0].Value.ToString();
                //var y = row.Cells[1].Value.ToString();
                txtSiSo.Text = row.Cells[1].Value.ToString();
                txtSoLuongDat.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ClassDetail form = new ClassDetail(txtTenLop.Text);
            form.Show();
            this.Hide();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataLopHoc.DataSource = ListLop.Where(c=>c.TenLH.Contains(txtTimKiem.Text)).ToList();
        }
    }
}

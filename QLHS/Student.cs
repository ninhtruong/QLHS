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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnThemHS_Click(object sender, EventArgs e)
        {
            CreateStudent createhs = new CreateStudent();
            createhs.Show();
        }

        private void btnSuaHS_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaHS_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            var sql = "SELECT * FROM HOCSINH";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListHocSinh = new List<HocSinh>();
            while (read.Read())
            {
                var mahocsinh = read["MaHocSinh"];
                var malop = read["MaLopHoc"];
                var hoten = read["HoTen"];
                var ngaysinh = read["NgaySinh"];
                var gioitinh = read["GioiTinh"];
                var diachi = read["DiaChi"];
                var email = read["Email"];

                ListHocSinh.Add(new HocSinh
                {
                    MaHocSinh = Convert.ToInt32(mahocsinh),
                    MaLopHoc = Convert.ToInt32(malop),
                    HoTen = hoten.ToString(),
                    NgaySinh = Convert.ToDateTime(ngaysinh),
                    GioiTinh = Convert.ToBoolean(gioitinh) == true ? "Nam" : "Nữ",
                    DiaChi = diachi.ToString(),
                    Email = email.ToString(),
                    TBHK1 = 0,
                    TBHK2 = 0
                });
            }

            dataStudent.DataSource = ListHocSinh;
        }

        private void dataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataStudent.Rows[e.RowIndex];
            txtMaHS.Text = Convert.ToInt32(row.Cells[0].Value).ToString();
            cbClass.Text = Convert.ToInt32(row.Cells[1].Value).ToString();
            txtTenHS.Text = row.Cells[2].Value.ToString();
            txtNgaySinh.Text = Convert.ToDateTime(row.Cells[3].Value).ToString();
            //var gioitinh = Convert.ToBoolean(row.Cells[4].Value) == true ? "Nam" : "Nữ";
            cbxGioiTinh.Text = row.Cells[4].Value.ToString();
            txtDiaChi.Text = row.Cells[5].Value.ToString();
            txtEmail.Text = row.Cells[6].Value.ToString();

        }
    }
}

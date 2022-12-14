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
    public partial class PointDetail : Form
    {
        public PointDetail(string MaHS,string LopHoc, int HocKy)
        {
            InitializeComponent();
            txtHocSinh.Text = MaHS;
            txtLop.Text = LopHoc;
            txtHocKy.Text = HocKy.ToString();
            LoadPointStudent(MaHS,LopHoc,HocKy);
        }


        private int GetHS(string TenHS, string TenLop)
        {
            var sql = "SELECT * FROM HOCSINH WHERE HoTen = N'"+ TenHS + "' AND MaLopHoc = (SELECT MaLopHoc FROM LOPHOC WHERE TenLH = '" + TenLop + "')";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListMaHS = new List<int>();
            while (read.Read())
            {
                var mahocsinh = read["MaHocSinh"];
                ListMaHS.Add(Convert.ToInt32(mahocsinh));
            }
            return ListMaHS.FirstOrDefault();
        }
        private int GetLop(string TenLop)
        {
            var sql = "	  SELECT * FROM LOPHOC WHERE TenLH = '" + TenLop + "'";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListLopHoc = new List<int>();
            while (read.Read())
            {
                var malop = read["MaKhoi"];
                ListLopHoc.Add(Convert.ToInt32(malop));
            }
            return ListLopHoc.FirstOrDefault();
        }

        private string GetMonHoc(int MaMonHoc)
        {
            var sql = "	  SELECT * FROM MonHoc WHERE MaMonHoc = " + MaMonHoc + "";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListMonHoc = new List<string>();
            while (read.Read())
            {
                var monhoc = read["TenMonHoc"];
                ListMonHoc.Add(monhoc.ToString());
            }
            return ListMonHoc.FirstOrDefault();
        }

        private string GetLoaiBaiThi(int MaLoaiBaiThi)
        {
            var sql = "	  SELECT * FROM LOAIBAITHI WHERE MaLoaiBaiThi = " + MaLoaiBaiThi + "";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListLoaiBaiThi = new List<string>();
            while (read.Read())
            {
                var loaibaithi = read["TenBaiThi"];
                ListLoaiBaiThi.Add(loaibaithi.ToString());
            }
            return ListLoaiBaiThi.FirstOrDefault();
        }
        private void LoadPointStudent(string TenHS, string TenLop, int HK)
        {
            var sql = "	  SELECT * FROM BAITHI WHERE MaHocSinh = " + GetHS(TenHS, TenLop) + " AND MaKhoi = " + GetLop(TenLop) + " AND MaHocKy = " + HK;
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListPointDetail = new List<ChiTietBaiThi>();
            while (read.Read())
            {
                var mabaithi = read["MaBaiThi"];
                var mahocsinh = read["MaHocSinh"];
                var makhoi = read["MaKhoi"];
                var mahocky = read["MaHocKy"];
                var maloaibaithi = read["MaLoaiBaiThi"];
                var mamonhoc = read["MaMonHoc"];
                var diem = read["Diem"];

                ListPointDetail.Add(new ChiTietBaiThi
                {
                    TenMocHoc = GetMonHoc(Convert.ToInt32(mamonhoc)),
                    LoaiBaiThi = GetLoaiBaiThi(Convert.ToInt32(maloaibaithi)),
                    Diem = Convert.ToInt32(diem),
                });
            }
            dataPointDetail.DataSource = ListPointDetail;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            CreatePoint form = new CreatePoint();
            form.Show();
            this.Hide();
        }
    }
}

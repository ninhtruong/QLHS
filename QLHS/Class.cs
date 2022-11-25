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
        public Class()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            CreateClass createlop = new CreateClass();
            createlop.Show();
        }

        private void LoadData()
        {
            var sql = "SELECT * FROM LOPHOC";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListClass = new List<LopHoc>();
            while (read.Read())
            {
                var malop = read["MaLopHoc"];
                var makhoi = read["MaKhoi"];
                var tenlop = read["TenLH"];
                var sisotoida = read["SiSoToiDa"];

                ListClass.Add(new LopHoc
                {
                    MaLop = Convert.ToInt32(malop),
                    MaKhoi = Convert.ToInt32(makhoi),
                    TenLH = tenlop.ToString(),
                    SiSoToiDa = Convert.ToInt32(sisotoida),
                    Tyle = 0
                });
            }

            dataLopHoc.DataSource = ListClass;
        }
    }
}

using QLHS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM NHANVIEN WHERE TaiKhoan =" + txtUsername.Text + " AND MatKhau = " + txtPassword.Text;
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");

            if (read != null)
                MessageBox.Show("ok");
            MessageBox.Show("fail");

        }

    }
}

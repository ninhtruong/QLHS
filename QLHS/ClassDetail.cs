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
        public ClassDetail(string TenLH)
        {
            InitializeComponent();
            LoadData(TenLH);
        }

        private void LoadData(string TenLH)
        {
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
            CreateStudent form = new CreateStudent();
            form.Show();
        }
    }
}

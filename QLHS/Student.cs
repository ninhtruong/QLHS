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
    }
}

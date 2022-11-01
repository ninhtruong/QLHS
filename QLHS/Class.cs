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
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            CreateClass createlop = new CreateClass();
            createlop.Show();
        }
    }
}

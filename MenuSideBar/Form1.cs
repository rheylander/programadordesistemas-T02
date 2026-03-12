using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuSideBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sENHAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSENHA frm = new frmSENHA();
            frm.Show();
        }
    }
}

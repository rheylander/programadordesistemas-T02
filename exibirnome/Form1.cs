using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exibirnome
{
    public partial class frmExibirNome : Form
    {
        public frmExibirNome()
        {
            InitializeComponent();
        }

        private void btnExibirNome_Click(object sender, EventArgs e)
        {
            string nome = txtExibirNome.Text;
            MessageBox.Show("Meu nome é: " + "\n" + nome);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alertas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlertaSimples(object sender, EventArgs e)
        {
            MessageBox.Show("Alerta Simples");
        }

        private void btnAlertaRobusto_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Vamos programar um sistema?",
                                                    "Título aqui",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Respondeu que sim");
            }
            else if (resposta == DialogResult.No)
            {
                MessageBox.Show("Respondeu que não");
            }
            else
            {
                MessageBox.Show("Resposta inválida");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

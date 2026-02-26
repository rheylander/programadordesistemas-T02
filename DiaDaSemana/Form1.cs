using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaDaSemana
{
    public partial class frmDiaSemana : Form
    {
        public frmDiaSemana()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            VerificarDiaSemana();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VerificarDiaSemana();
                e.SuppressKeyPress = true;
            }
        }

        private void VerificarDiaSemana()
        {
            if (int.TryParse(txtNumero.Text, out int dia))
            {
                switch (dia)
                {
                    case 1:
                        lblResultado.Text = "Resultado: Domingo";
                        break;
                    case 2:
                        lblResultado.Text = "Resultado: Segunda-feira";
                        break;
                    case 3:
                        lblResultado.Text = "Resultado: Terça-feira";
                        break;
                    case 4:
                        lblResultado.Text = "Resultado: Quarta-feira";
                        break;
                    case 5:
                        lblResultado.Text = "Resultado: Quinta-feira";
                        break;
                    case 6:
                        lblResultado.Text = "Resultado: Sexta-feira";
                        break;
                    case 7:
                        lblResultado.Text = "Resultado: Sábado";
                        break;
                    default:
                        lblResultado.Text = "Número inválido.";
                        break;
                }
            }
            else
            {
                lblResultado.Text = "Digite apenas números.";
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
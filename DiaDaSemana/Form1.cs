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
    public partial class FrmCalendario : Form
    {
        public FrmCalendario()
        {
            InitializeComponent();
        }

        private void txtInsereNumeroDaSemana_TextChanged(object sender, EventArgs e)
        {
            char[] numeros = txtInsereNumeroDaSemana.Text.ToCharArray();
        }

        private void btnVerificarDiaDaSemana_Click(object sender, EventArgs e)
        {
            var txtInsereNumeroDaSemana = txtInsereNumeroDaSemana.Text;
            switch (txtInsereNumeroDaSemana)
            {
                case "1":
                    txtPerguntaDiaDaSemana.Text = "Domingo";
                    break;

                case "2":
                    txtPerguntaDiaDaSemana.Text = "Segunda-feira";
                    break;

                case "3":
                    txtPerguntaDiaDaSemana.Text = "Terça-feira";
                    break;

                case "4":
                    txtPerguntaDiaDaSemana.Text = "Quarta-feira";
                    break;

                case "5":
                    txtPerguntaDiaDaSemana.Text = "Quinta-feira";
                    break;

                case "6":
                    txtPerguntaDiaDaSemana.Text = "Sexta-feira";
                    break;

                case "7":
                    txtPerguntaDiaDaSemana.Text = "Sábado";
                    break;
            }
        }

        private void lblExibiDiaDaSemana_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O número da semana é: " + txtInsereNumeroDaSemana.Text);
        }
    }
}
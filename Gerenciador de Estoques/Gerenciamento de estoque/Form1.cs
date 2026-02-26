using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_estoque
{
    public partial class Form1 : Form
    {
        // Quantidade inicial do estoque
        int estoqueAtual = 100;

        public Form1()
        {
            InitializeComponent();
            AtualizarEstoque();
        }

        // Atualiza a quantidade exibida e o status do estoque
        private void AtualizarEstoque()
        {
            lblEstoque2.Text = "QUANTIDADE NO ESTOQUE: " + estoqueAtual;

            // se for menor que 5, mostra alerta
            if (estoqueAtual < 5)
            {
                lblStatus.Text = "Alerta: Baixo estoque. Por favor, reabasteça este produto.";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.Text = "Estoque suficiente.";
                lblStatus.ForeColor = Color.Green;
            }
        }

        // Exibe mensagens de operação no painel
        private void ExibirMensagemNoPanel(string mensagem, Color cor)
        {
            panel1.Controls.Clear();

            Label lblMensagem = new Label();
            lblMensagem.Text = mensagem;
            lblMensagem.ForeColor = cor;
            lblMensagem.Font = new Font("Arial", 10, FontStyle.Bold);
            lblMensagem.AutoSize = false;
            lblMensagem.Size = panel1.Size;
            lblMensagem.TextAlign = ContentAlignment.MiddleCenter;

            panel1.Controls.Add(lblMensagem);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantidade.Text, out int quantidadeRetirada))
            {
                // Não aceita zero ou valores negativos
                if (quantidadeRetirada <= 0)
                {
                    ExibirMensagemNoPanel("Insira uma quantidade maior que zero!", Color.OrangeRed);
                    return;
                }

                // Não aceita retirada maior do que o estoque disponível
                if (quantidadeRetirada > estoqueAtual)
                {
                    ExibirMensagemNoPanel("Não há essa quantidade disponível em estoque!", Color.OrangeRed);
                    return;
                }

                // Faz a retirada
                estoqueAtual -= quantidadeRetirada;

                // Atualiza a tela com o novo valor do estoque
                AtualizarEstoque();

                // Mostra a mensagem da operação
                ExibirMensagemNoPanel("Foram retiradas " + quantidadeRetirada + " unidades do estoque!", Color.Green);

                // Limpa a caixa de texto
                txtQuantidade.Clear();
            }
            else
            {
                ExibirMensagemNoPanel("Por favor, insira um número válido!", Color.OrangeRed);
            }
        }

        // Métodos vazios ligados ao Designer
        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void lblEstoque_Click(object sender, EventArgs e)
        {
        }

        private void txtQuantidade_Click(object sender, EventArgs e)
        {
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
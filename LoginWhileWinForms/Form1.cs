using System;
using System.Windows.Forms;

namespace LoginWhileWinForms
{
    public partial class Form1 : Form
    {
        private string emailCorreto = "usuario@teste.com";
        private string senhaCorreta = "senha123";
        private int tentativas = 0;
        private const int maxTentativas = 3;

        public Form1()
        {
            InitializeComponent();
            lblMensagem.Text = "Digite seu e-mail e senha.";
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string emailDigitado = txtEmail.Text.Trim();
            string senhaDigitada = txtSenha.Text.Trim();

            if (emailDigitado == emailCorreto && senhaDigitada == senhaCorreta)
            {
                lblMensagem.Text = "Login bem-sucedido!";
                MessageBox.Show("Acesso liberado.", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tentativas++;

                if (tentativas >= maxTentativas)
                {
                    lblMensagem.Text = "Conta bloqueada por excesso de tentativas.";
                    btnEntrar.Enabled = false;
                    txtEmail.Enabled = false;
                    txtSenha.Enabled = false;

                    MessageBox.Show("Conta bloqueada por excesso de tentativas.",
                        "Bloqueado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    lblMensagem.Text = "E-mail ou senha incorretos. Tentativas restantes: " + (maxTentativas - tentativas);
                    txtSenha.Clear();
                    txtSenha.Focus();
                }
            }
        }
    }
}
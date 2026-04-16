using System;
using System.Windows.Forms;

namespace MenuSideBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void gerarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSENHA frm = new frmSENHA();
            frm.Show();
        }

        private void chamarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função de chamar senha.");
        }

        private void visualizarFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função de visualizar fila.");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema com MenuStrip - atividade Windows Forms.", "Sobre");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
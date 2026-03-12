using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureBox
{
    public partial class frmPictureBox : Form
    {
        private string imagemLocalizada;

        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void btnVerImagem_Click(object sender, EventArgs e)
        {
            pbCidade.Image = Image.FromFile(@"C:\Users\guilherme.srocha18\Downloads\saopaulo.jpg");
            pbCidade.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            try
            {
                //caixa de edialogo para abrir arquivo
                OpenFileDialog abrirarquivo = new OpenFileDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
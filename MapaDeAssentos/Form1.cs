using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MatrizesWinFormsAssentos
{
    public partial class Form1 : Form
    {
        private enum SeatState { Livre = 0, Reservado = 1, Bloqueado = 2 }

        private SeatState[,] _mapa = new SeatState[0, 0];
        private Button[,] _botoes = new Button[0, 0];

        public Form1()
        {
            InitializeComponent();

            // Estado inicial do modo
            rbReservar.Checked = true;

            // Eventos
            btnGerar.Click += btnGerar_Click;
            btnSalvar.Click += btnSalvar_Click;
            btnCarregar.Click += btnCarregar_Click;
            btnLimpar.Click += btnLimpar_Click;

            // Gera grid inicial
            GerarMapa((int)nudLinhas.Value, (int)nudColunas.Value);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarMapa((int)nudLinhas.Value, (int)nudColunas.Value);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarMapaCsv();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarMapaCsv();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparMapa();
        }

        private void GerarMapa(int linhas, int colunas)
        {
            if (linhas < 2) linhas = 2;
            if (colunas < 2) colunas = 2;

            _mapa = new SeatState[linhas, colunas];
            _botoes = new Button[linhas, colunas];

            gridAssentos.SuspendLayout();
            gridAssentos.Controls.Clear();
            gridAssentos.RowStyles.Clear();
            gridAssentos.ColumnStyles.Clear();

            gridAssentos.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            gridAssentos.RowCount = linhas;
            gridAssentos.ColumnCount = colunas;

            for (int c = 0; c < colunas; c++)
                gridAssentos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / colunas));

            for (int r = 0; r < linhas; r++)
                gridAssentos.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / linhas));

            for (int r = 0; r < linhas; r++)
            {
                for (int c = 0; c < colunas; c++)
                {
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Margin = new Padding(2);
                    btn.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                    btn.Tag = new Point(r, c);
                    btn.FlatStyle = FlatStyle.Flat;

                    btn.Click += Celula_Click;

                    _botoes[r, c] = btn;
                    gridAssentos.Controls.Add(btn, c, r);

                    AplicarVisual(btn, _mapa[r, c]);
                }
            }

            gridAssentos.ResumeLayout();
            AtualizarContadores();
        }

        private void Celula_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (!(btn.Tag is Point)) return;
            Point p = (Point)btn.Tag;

            int r = p.X;
            int c = p.Y;

            SeatState atual = _mapa[r, c];

            if (rbReservar.Checked)
            {
                if (atual == SeatState.Bloqueado)
                {
                    MessageBox.Show(
                        "Assento BLOQUEADO. Use 'Liberar' para desbloquear.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }

                _mapa[r, c] = (atual == SeatState.Reservado) ? SeatState.Livre : SeatState.Reservado;
            }
            else if (rbBloquear.Checked)
            {
                _mapa[r, c] = SeatState.Bloqueado;
            }
            else if (rbLiberar.Checked)
            {
                _mapa[r, c] = SeatState.Livre;
            }

            AplicarVisual(btn, _mapa[r, c]);
            AtualizarContadores();
        }

        private void AplicarVisual(Button btn, SeatState estado)
        {
            switch (estado)
            {
                case SeatState.Livre:
                    btn.Text = "";
                    btn.BackColor = Color.White;
                    break;

                case SeatState.Reservado:
                    btn.Text = "R";
                    btn.BackColor = Color.LightGreen;
                    break;

                case SeatState.Bloqueado:
                    btn.Text = "X";
                    btn.BackColor = Color.LightGray;
                    break;
            }
        }

        private void AtualizarVisual()
        {
            for (int r = 0; r < _mapa.GetLength(0); r++)
                for (int c = 0; c < _mapa.GetLength(1); c++)
                    AplicarVisual(_botoes[r, c], _mapa[r, c]);
        }

        private void AtualizarContadores()
        {
            int livres = 0, reservados = 0, bloqueados = 0;

            for (int r = 0; r < _mapa.GetLength(0); r++)
            {
                for (int c = 0; c < _mapa.GetLength(1); c++)
                {
                    switch (_mapa[r, c])
                    {
                        case SeatState.Livre: livres++; break;
                        case SeatState.Reservado: reservados++; break;
                        case SeatState.Bloqueado: bloqueados++; break;
                    }
                }
            }

            lblLivres.Text = "Livres: " + livres;
            lblReservados.Text = "Reservados: " + reservados;
            lblBloqueados.Text = "Bloqueados: " + bloqueados;
        }

        private void LimparMapa()
        {
            for (int r = 0; r < _mapa.GetLength(0); r++)
                for (int c = 0; c < _mapa.GetLength(1); c++)
                    _mapa[r, c] = SeatState.Livre;

            AtualizarVisual();
            AtualizarContadores();
        }

        // CSV simples (SEM JSON)
        // Linha 1: linhas;colunas
        // Linhas seguintes: 0;1;2...
        private void SalvarMapaCsv()
        {
            if (_mapa.GetLength(0) == 0 || _mapa.GetLength(1) == 0)
            {
                MessageBox.Show("Gere o grid antes de salvar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV (*.csv)|*.csv|TXT (*.txt)|*.txt";
                sfd.FileName = "mapa-assentos.csv";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                int linhas = _mapa.GetLength(0);
                int colunas = _mapa.GetLength(1);

                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine(linhas + ";" + colunas);

                        for (int r = 0; r < linhas; r++)
                        {
                            string[] vals = new string[colunas];
                            for (int c = 0; c < colunas; c++)
                                vals[c] = ((int)_mapa[r, c]).ToString();

                            sw.WriteLine(string.Join(";", vals));
                        }
                    }

                    MessageBox.Show("Mapa salvo com sucesso!", "OK",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar.\n" + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarMapaCsv()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV (*.csv)|*.csv|TXT (*.txt)|*.txt";

                if (ofd.ShowDialog() != DialogResult.OK) return;

                string[] linhasArquivo;

                try
                {
                    linhasArquivo = File.ReadAllLines(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível ler o arquivo.\n" + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (linhasArquivo.Length < 2)
                {
                    MessageBox.Show("Arquivo inválido (conteúdo insuficiente).", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] header = linhasArquivo[0].Split(';');
                int linhas, colunas;

                if (header.Length < 2 ||
                    !int.TryParse(header[0], out linhas) ||
                    !int.TryParse(header[1], out colunas) ||
                    linhas < 2 || colunas < 2)
                {
                    MessageBox.Show("Arquivo inválido (cabeçalho). Use: linhas;colunas",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (linhasArquivo.Length < linhas + 1)
                {
                    MessageBox.Show("Arquivo inválido (linhas faltando).",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GerarMapa(linhas, colunas);

                for (int r = 0; r < linhas; r++)
                {
                    string[] parts = linhasArquivo[r + 1].Split(';');
                    if (parts.Length < colunas)
                    {
                        MessageBox.Show("Arquivo inválido (colunas faltando na linha " + (r + 1) + ").",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    for (int c = 0; c < colunas; c++)
                    {
                        int v;
                        if (!int.TryParse(parts[c], out v) || v < 0 || v > 2)
                        {
                            MessageBox.Show("Valor inválido em [" + r + "," + c + "]. Use 0, 1 ou 2.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        _mapa[r, c] = (SeatState)v;
                    }
                }

                AtualizarVisual();
                AtualizarContadores();

                MessageBox.Show("Mapa carregado com sucesso!", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MatrizesWinFormsAssentos
{
    public partial class Form1 : Form
    {
        /*
         * ============================
         * 1) MODELO (MATRIZ)
         * ============================
         * Cada posição [linha, coluna] da matriz representa 1 assento.
         * Valores:
         *  0 = Livre
         *  1 = Reservado
         *  2 = Bloqueado
         */
        private enum SeatState { Livre = 0, Reservado = 1, Bloqueado = 2 }

        // Matriz de estados (a "matriz do exercício")
        private SeatState[,] _mapa = new SeatState[0, 0];

        // Matriz de botões (para conseguir atualizar a UI rapidamente)
        private Button[,] _botoes = new Button[0, 0];

        public Form1()
        {
            InitializeComponent();

            // ============================
            // 2) CONFIG INICIAL DA UI
            // ============================
            rbReservar.Checked = true; // modo padrão

            // ============================
            // 3) EVENTOS DOS BOTÕES
            // ============================
            btnGerar.Click += btnGerar_Click;
            btnSalvar.Click += btnSalvar_Click;
            btnCarregar.Click += btnCarregar_Click;
            btnLimpar.Click += btnLimpar_Click;

            // ============================
            // 4) GRID INICIAL
            // ============================
            // Usa os valores iniciais do NumericUpDown (8 e 10, por exemplo)
            GerarMapa((int)nudLinhas.Value, (int)nudColunas.Value);
        }

        // ============================
        // EVENTOS DO TOPO
        // ============================

        private void btnGerar_Click(object sender, EventArgs e)
        {
            // Recria o grid conforme valores escolhidos pelo usuário
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

        /*
         * ============================
         * 5) GERAR MAPA (MATRIZ + UI)
         * ============================
         * Aqui acontece o “principal”:
         * - Cria a matriz _mapa[linhas, colunas]
         * - Cria a matriz de botões _botoes[linhas, colunas]
         * - Monta o TableLayoutPanel com botões clicáveis
         */
        private void GerarMapa(int linhas, int colunas)
        {
            // Garantia mínima
            if (linhas < 2) linhas = 2;
            if (colunas < 2) colunas = 2;

            // Cria as matrizes
            _mapa = new SeatState[linhas, colunas];
            _botoes = new Button[linhas, colunas];

            // Otimiza montagem (evita piscadas)
            gridAssentos.SuspendLayout();

            // Limpa layout anterior
            gridAssentos.Controls.Clear();
            gridAssentos.RowStyles.Clear();
            gridAssentos.ColumnStyles.Clear();

            // Trava crescimento automático (evita bagunça)
            gridAssentos.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;

            // Define quantidade de linhas/colunas do TableLayoutPanel
            gridAssentos.RowCount = linhas;
            gridAssentos.ColumnCount = colunas;

            // Divide espaço igualmente entre as colunas
            for (int c = 0; c < colunas; c++)
                gridAssentos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / colunas));

            // Divide espaço igualmente entre as linhas
            for (int r = 0; r < linhas; r++)
                gridAssentos.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / linhas));

            // Cria os botões (assentos)
            for (int r = 0; r < linhas; r++)
            {
                for (int c = 0; c < colunas; c++)
                {
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Margin = new Padding(2);
                    btn.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                    btn.FlatStyle = FlatStyle.Flat;

                    // Guarda a posição do assento dentro do botão
                    // (assim no Click a gente sabe exatamente [r, c])
                    btn.Tag = new Point(r, c);

                    // Evento de clique do assento
                    btn.Click += Celula_Click;

                    // Guarda o botão na matriz de botões
                    _botoes[r, c] = btn;

                    // Adiciona o botão no TableLayoutPanel
                    // Atenção: TableLayoutPanel usa (coluna, linha)
                    gridAssentos.Controls.Add(btn, c, r);

                    // Estado inicial é Livre (0), então aplica visual de Livre
                    AplicarVisual(btn, _mapa[r, c]);
                }
            }

            gridAssentos.ResumeLayout();

            // Atualiza rodapé (contadores)
            AtualizarContadores();
        }

        /*
         * ============================
         * 6) CLIQUE NO ASSENTO
         * ============================
         * Conforme o modo selecionado:
         * - Reservar/Cancelar: alterna Livre <-> Reservado (mas não mexe se Bloqueado)
         * - Bloquear: vira Bloqueado
         * - Liberar: vira Livre
         */
        private void Celula_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Recupera a posição [r,c] salva no Tag
            if (!(btn.Tag is Point)) return;
            Point p = (Point)btn.Tag;

            int r = p.X;
            int c = p.Y;

            SeatState atual = _mapa[r, c];

            if (rbReservar.Checked)
            {
                // Não deixa reservar se estiver bloqueado
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

                // Alterna Livre <-> Reservado
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

            // Atualiza visual e contadores
            AplicarVisual(btn, _mapa[r, c]);
            AtualizarContadores();
        }

        /*
         * ============================
         * 7) VISUAL DO BOTÃO
         * ============================
         * Define texto + cor do assento conforme estado
         */
        private void AplicarVisual(Button btn, SeatState estado)
        {
            switch (estado)
            {
                case SeatState.Livre:
                    btn.Text = "";              // sem marcação
                    btn.BackColor = Color.White;
                    break;

                case SeatState.Reservado:
                    btn.Text = "R";              // reservado
                    btn.BackColor = Color.LightGreen;
                    break;

                case SeatState.Bloqueado:
                    btn.Text = "X";              // bloqueado
                    btn.BackColor = Color.LightGray;
                    break;
            }
        }

        /*
         * Atualiza o visual de todos os assentos
         * (útil após carregar arquivo ou limpar tudo)
         */
        private void AtualizarVisual()
        {
            for (int r = 0; r < _mapa.GetLength(0); r++)
                for (int c = 0; c < _mapa.GetLength(1); c++)
                    AplicarVisual(_botoes[r, c], _mapa[r, c]);
        }

        /*
         * ============================
         * 8) CONTADORES DO RODAPÉ
         * ============================
         * Conta quantos estão em cada estado e atualiza labels
         */
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

        /*
         * ============================
         * 9) LIMPAR MAPA
         * ============================
         * Volta tudo para Livre
         */
        private void LimparMapa()
        {
            for (int r = 0; r < _mapa.GetLength(0); r++)
                for (int c = 0; c < _mapa.GetLength(1); c++)
                    _mapa[r, c] = SeatState.Livre;

            AtualizarVisual();
            AtualizarContadores();
        }

        /*
         * ============================
         * 10) SALVAR/ CARREGAR (CSV)
         * ============================
         * Formato:
         * Linha 1: linhas;colunas
         * Linha 2..: valores 0;1;2;...
         * (Sem JSON, como você precisa)
         */
        private void SalvarMapaCsv()
        {
            // Se o grid ainda não foi gerado, não salva
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
                        // Cabeçalho
                        sw.WriteLine(linhas + ";" + colunas);

                        // Conteúdo
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

                // Precisa ter pelo menos: cabeçalho + 1 linha de dados
                if (linhasArquivo.Length < 2)
                {
                    MessageBox.Show("Arquivo inválido (conteúdo insuficiente).", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lê cabeçalho: linhas;colunas
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

                // Confere se tem linhas suficientes no arquivo
                if (linhasArquivo.Length < linhas + 1)
                {
                    MessageBox.Show("Arquivo inválido (linhas faltando).",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Recria o grid no tamanho do arquivo
                GerarMapa(linhas, colunas);

                // Lê cada linha e preenche a matriz
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
                        // Valores válidos: 0,1,2
                        if (!int.TryParse(parts[c], out v) || v < 0 || v > 2)
                        {
                            MessageBox.Show("Valor inválido em [" + r + "," + c + "]. Use 0, 1 ou 2.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        _mapa[r, c] = (SeatState)v;
                    }
                }

                // Atualiza interface após carregar
                AtualizarVisual();
                AtualizarContadores();

                MessageBox.Show("Mapa carregado com sucesso!", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
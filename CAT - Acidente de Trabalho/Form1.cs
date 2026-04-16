using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoCAT
{
    /// <summary>
    /// Formulário principal da tela de Comunicação de Acidente de Trabalho (CAT).
    /// 
    /// Estrutura:
    /// 1. Menu lateral
    /// 2. Cabeçalho superior
    /// 3. Card central com formulário
    /// 
    /// Responsabilidades:
    /// - montar a interface
    /// - validar os campos
    /// - coletar os dados digitados
    /// - executar ações de salvar e cancelar
    /// </summary>
    public partial class FrmCAT : Form
    {
        #region Cores e estilos

        private readonly Color corFundoJanela = Color.FromArgb(240, 243, 248);
        private readonly Color corMenu = Color.FromArgb(5, 45, 84);
        private readonly Color corMenuAtivo = Color.FromArgb(20, 85, 140);
        private readonly Color corTitulo = Color.FromArgb(30, 74, 122);
        private readonly Color corLabelCampo = Color.FromArgb(220, 80, 60);
        private readonly Color corBotaoPrimario = Color.FromArgb(0, 96, 180);

        #endregion

        #region Painéis principais

        private Panel pnlMenu;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlFormCard;

        #endregion

        #region Cabeçalho

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnConfiguracoes;

        #endregion

        #region Botões principais

        private Button btnCancelar;
        private Button btnSalvar;

        #endregion

        #region Campos do formulário

        private Label lblDataAcidente;
        private DateTimePicker dtpDataAcidente;

        private Label lblHoraAcidente;
        private MaskedTextBox mtbHoraAcidente;

        private Label lblDataObito;
        private DateTimePicker dtpDataObito;
        private CheckBox chkSemDataObito;

        private Label lblTipoCAT;
        private ComboBox cmbTipoCAT;

        private Label lblEmpregado;
        private ComboBox cmbEmpregado;

        private Label lblEmitenteCAT;
        private ComboBox cmbEmitenteCAT;

        private Label lblLocalAcidente;
        private ComboBox cmbLocalAcidente;

        private Label lblEntradaTrabalho;
        private MaskedTextBox mtbEntradaTrabalho;

        private Label lblSaidaTrabalho;
        private MaskedTextBox mtbSaidaTrabalho;

        private Label lblDescricaoAcidente;
        private TextBox txtDescricaoAcidente;

        #endregion

        public FrmCAT()
        {
            InitializeComponent();

            ConfigurarFormulario();
            CriarEstruturaBase();
        }

        #region Inicialização do formulário

        /// <summary>
        /// Configura as propriedades visuais iniciais do formulário.
        /// </summary>
        private void ConfigurarFormulario()
        {
            Text = "CAT - Comunicação de Acidente de Trabalho";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            MinimumSize = new Size(1280, 720);
            BackColor = corFundoJanela;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        /// <summary>
        /// Cria toda a estrutura principal da tela.
        /// </summary>
        private void CriarEstruturaBase()
        {
            CriarMenuLateral();
            CriarCabecalho();
            CriarAreaConteudo();
        }

        #endregion

        #region Menu lateral

        /// <summary>
        /// Cria o painel lateral esquerdo.
        /// </summary>
        private void CriarMenuLateral()
        {
            pnlMenu = new Panel
            {
                Name = "pnlMenu",
                Dock = DockStyle.Left,
                Width = 280,
                BackColor = corMenu
            };

            Controls.Add(pnlMenu);

            CriarConteudoMenu();
        }

        /// <summary>
        /// Adiciona conteúdo visual ao menu lateral.
        /// </summary>
        private void CriarConteudoMenu()
        {
            Label lblSistema = new Label
            {
                Name = "lblSistema",
                Text = "MedWork\r\nMedicina do Trabalho - SENAC",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(240, 60),
                Location = new Point(20, 20)
            };
            pnlMenu.Controls.Add(lblSistema);

            Label lblSecao1 = new Label
            {
                Text = "ESOCIAL — EVENTOS",
                ForeColor = Color.FromArgb(190, 205, 225),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 95)
            };
            pnlMenu.Controls.Add(lblSecao1);

            pnlMenu.Controls.Add(CriarBotaoMenu("Fatores de Risco (S-2240)", 120, false));
            pnlMenu.Controls.Add(CriarBotaoMenu("CAT — Acidente (S-2210)", 165, true));
            pnlMenu.Controls.Add(CriarBotaoMenu("Monit. Saúde / ASO (S-2220)", 210, false));
            pnlMenu.Controls.Add(CriarBotaoMenu("Empregados", 255, false));

            Label lblSecao2 = new Label
            {
                Text = "CADASTROS BASE",
                ForeColor = Color.FromArgb(190, 205, 225),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 330)
            };
            pnlMenu.Controls.Add(lblSecao2);

            pnlMenu.Controls.Add(CriarBotaoMenu("Médicos", 355, false));
            pnlMenu.Controls.Add(CriarBotaoMenu("Tipos de Exame", 400, false));
            pnlMenu.Controls.Add(CriarBotaoMenu("Ambientes de Trabalho", 445, false));
            pnlMenu.Controls.Add(CriarBotaoMenu("Integração eSocial", 490, false));

            Label lblUsuario = new Label
            {
                Text = "Rafael Oliveira\r\nMédico Coordenador",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                AutoSize = false,
                Size = new Size(180, 40),
                Location = new Point(60, pnlMenu.Height - 70),
                Anchor = AnchorStyles.Left | AnchorStyles.Bottom
            };
            pnlMenu.Controls.Add(lblUsuario);

            Label lblAvatar = new Label
            {
                Text = "RO",
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(37, 111, 178),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Size = new Size(36, 36),
                Location = new Point(18, pnlMenu.Height - 65),
                Anchor = AnchorStyles.Left | AnchorStyles.Bottom,
                BorderStyle = BorderStyle.FixedSingle
            };
            pnlMenu.Controls.Add(lblAvatar);
        }

        /// <summary>
        /// Cria botão padronizado para o menu lateral.
        /// </summary>
        private Button CriarBotaoMenu(string texto, int posicaoY, bool ativo)
        {
            return new Button
            {
                Width = 240,
                Height = 40,
                Location = new Point(20, posicaoY),
                Text = texto,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = ativo ? corMenuAtivo : corMenu,
                FlatAppearance =
                {
                    BorderSize = 0
                }
            };
        }

        #endregion

        #region Cabeçalho superior

        /// <summary>
        /// Cria o cabeçalho superior.
        /// </summary>
        private void CriarCabecalho()
        {
            pnlHeader = new Panel
            {
                Name = "pnlHeader",
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = Color.White
            };

            Controls.Add(pnlHeader);

            CriarConteudoCabecalho();
        }

        /// <summary>
        /// Adiciona título, subtítulo e botão de configurações ao cabeçalho.
        /// </summary>
        private void CriarConteudoCabecalho()
        {
            lblTitulo = new Label
            {
                Name = "lblTitulo",
                Text = "CAT — Acidente de Trabalho",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = corTitulo,
                AutoSize = true,
                Location = new Point(300, 12)
            };

            lblSubtitulo = new Label
            {
                Name = "lblSubtitulo",
                Text = "S-2210 - Comunicação de Acidente",
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(302, 40)
            };

            btnConfiguracoes = new Button
            {
                Name = "btnConfiguracoes",
                Text = "Configurações",
                Size = new Size(130, 35),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(Width - 180, 17),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White
            };
            btnConfiguracoes.FlatAppearance.BorderColor = Color.Silver;

            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(btnConfiguracoes);

            pnlHeader.Resize += (s, e) =>
            {
                btnConfiguracoes.Location = new Point(pnlHeader.Width - 150, 17);
            };
        }

        #endregion

        #region Área central

        /// <summary>
        /// Cria a área central onde ficará o card do formulário.
        /// </summary>
        private void CriarAreaConteudo()
        {
            pnlContent = new Panel
            {
                Name = "pnlContent",
                Dock = DockStyle.Fill,
                BackColor = corFundoJanela,
                AutoScroll = true
            };

            Controls.Add(pnlContent);

            CriarCardFormulario();
        }

        /// <summary>
        /// Cria o card branco do formulário principal.
        /// </summary>
        private void CriarCardFormulario()
        {
            pnlFormCard = new Panel
            {
                Name = "pnlFormCard",
                BackColor = Color.White,
                Size = new Size(1180, 620),
                Location = new Point(25, 20),
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            pnlContent.Controls.Add(pnlFormCard);

            CriarCabecalhoFormulario();
            CriarAbasFake();
            CriarCamposFormulario();
        }

        /// <summary>
        /// Cria o topo interno do card com título e botões de ação.
        /// </summary>
        private void CriarCabecalhoFormulario()
        {
            Label lblFormTitulo = new Label
            {
                Name = "lblFormTitulo",
                Text = "Comunicação de Acidente de Trabalho (CAT)",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = corTitulo,
                AutoSize = true,
                Location = new Point(20, 20)
            };

            Label lblFormSubtitulo = new Label
            {
                Name = "lblFormSubtitulo",
                Text = "Registro de novo acidente ou doença ocupacional",
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(22, 47)
            };

            btnCancelar = new Button
            {
                Name = "btnCancelar",
                Text = "Cancelar",
                Size = new Size(100, 35),
                Location = new Point(930, 18),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White
            };
            btnCancelar.FlatAppearance.BorderColor = Color.Silver;
            btnCancelar.Click += BtnCancelar_Click;

            btnSalvar = new Button
            {
                Name = "btnSalvar",
                Text = "Salvar CAT",
                Size = new Size(120, 35),
                Location = new Point(1040, 18),
                FlatStyle = FlatStyle.Flat,
                BackColor = corBotaoPrimario,
                ForeColor = Color.White
            };
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Click += BtnSalvar_Click;

            pnlFormCard.Controls.Add(lblFormTitulo);
            pnlFormCard.Controls.Add(lblFormSubtitulo);
            pnlFormCard.Controls.Add(btnCancelar);
            pnlFormCard.Controls.Add(btnSalvar);
        }

        /// <summary>
        /// Simula as abas exibidas na imagem.
        /// </summary>
        private void CriarAbasFake()
        {
            Panel linha = new Panel
            {
                BackColor = Color.Gainsboro,
                Size = new Size(1120, 1),
                Location = new Point(20, 105)
            };
            pnlFormCard.Controls.Add(linha);

            Label lblAba1 = new Label
            {
                Text = "DADOS CADASTRAIS",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 96, 180),
                AutoSize = true,
                Location = new Point(25, 85)
            };

            Label lblAba2 = new Label
            {
                Text = "TESTEMUNHAS",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(260, 85)
            };

            Label lblAba3 = new Label
            {
                Text = "DADOS COMPLEMENTARES",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(420, 85)
            };

            Panel barraAtiva = new Panel
            {
                BackColor = Color.FromArgb(245, 153, 47),
                Size = new Size(170, 3),
                Location = new Point(20, 104)
            };

            pnlFormCard.Controls.Add(lblAba1);
            pnlFormCard.Controls.Add(lblAba2);
            pnlFormCard.Controls.Add(lblAba3);
            pnlFormCard.Controls.Add(barraAtiva);
        }

        #endregion

        #region Criação dos campos

        /// <summary>
        /// Cria todos os campos da aba de dados cadastrais.
        /// </summary>
        private void CriarCamposFormulario()
        {
            CriarLinha1();
            CriarLinha2();
            CriarLinha3();
            CriarLinha4();
        }

        /// <summary>
        /// Cria a primeira linha de campos.
        /// </summary>
        private void CriarLinha1()
        {
            int labelY = 135;
            int inputY = 160;

            lblDataAcidente = CriarLabelCampo("DATA DO ACIDENTE *", 20, labelY);
            dtpDataAcidente = CriarDatePicker(20, inputY, 250);

            lblHoraAcidente = CriarLabelCampo("HORA DO ACIDENTE *", 290, labelY);
            mtbHoraAcidente = CriarCampoHora(290, inputY, 250);

            lblDataObito = CriarLabelCampo("DATA DO ÓBITO", 560, labelY);
            dtpDataObito = CriarDatePicker(560, inputY, 220);

            chkSemDataObito = new CheckBox
            {
                Name = "chkSemDataObito",
                Text = "Não se aplica",
                AutoSize = true,
                Location = new Point(560, 197)
            };
            chkSemDataObito.Checked = true;
            dtpDataObito.Enabled = false;
            chkSemDataObito.CheckedChanged += ChkSemDataObito_CheckedChanged;

            lblTipoCAT = CriarLabelCampo("TIPO DE CAT *", 830, labelY);
            cmbTipoCAT = CriarComboBox(830, inputY, 310, new string[]
            {
                "Inicial",
                "Reabertura",
                "Comunicação de Óbito"
            });

            pnlFormCard.Controls.Add(lblDataAcidente);
            pnlFormCard.Controls.Add(dtpDataAcidente);
            pnlFormCard.Controls.Add(lblHoraAcidente);
            pnlFormCard.Controls.Add(mtbHoraAcidente);
            pnlFormCard.Controls.Add(lblDataObito);
            pnlFormCard.Controls.Add(dtpDataObito);
            pnlFormCard.Controls.Add(chkSemDataObito);
            pnlFormCard.Controls.Add(lblTipoCAT);
            pnlFormCard.Controls.Add(cmbTipoCAT);
        }

        /// <summary>
        /// Cria a segunda linha de campos.
        /// </summary>
        private void CriarLinha2()
        {
            int labelY = 230;
            int inputY = 255;

            lblEmpregado = CriarLabelCampo("EMPREGADO *", 20, labelY);
            cmbEmpregado = CriarComboBox(20, inputY, 520, new string[]
            {
                "-- Selecione o empregado --",
                "João da Silva",
                "Maria Oliveira",
                "Carlos Souza"
            });

            lblEmitenteCAT = CriarLabelCampo("EMITENTE DA CAT *", 560, labelY);
            cmbEmitenteCAT = CriarComboBox(560, inputY, 580, new string[]
            {
                "Empregador",
                "Empregado",
                "Sindicato",
                "Médico",
                "Autoridade Pública"
            });

            pnlFormCard.Controls.Add(lblEmpregado);
            pnlFormCard.Controls.Add(cmbEmpregado);
            pnlFormCard.Controls.Add(lblEmitenteCAT);
            pnlFormCard.Controls.Add(cmbEmitenteCAT);
        }

        /// <summary>
        /// Cria a terceira linha de campos.
        /// </summary>
        private void CriarLinha3()
        {
            int labelY = 325;
            int inputY = 350;

            lblLocalAcidente = CriarLabelCampo("LOCAL DO ACIDENTE *", 20, labelY);
            cmbLocalAcidente = CriarComboBox(20, inputY, 360, new string[]
            {
                "No estabelecimento do empregador",
                "Em via pública",
                "Em viagem a serviço",
                "Na residência"
            });

            lblEntradaTrabalho = CriarLabelCampo("ENTRADA NO TRABALHO", 410, labelY);
            mtbEntradaTrabalho = CriarCampoHora(410, inputY, 320);

            lblSaidaTrabalho = CriarLabelCampo("SAÍDA DO TRABALHO", 760, labelY);
            mtbSaidaTrabalho = CriarCampoHora(760, inputY, 320);

            pnlFormCard.Controls.Add(lblLocalAcidente);
            pnlFormCard.Controls.Add(cmbLocalAcidente);
            pnlFormCard.Controls.Add(lblEntradaTrabalho);
            pnlFormCard.Controls.Add(mtbEntradaTrabalho);
            pnlFormCard.Controls.Add(lblSaidaTrabalho);
            pnlFormCard.Controls.Add(mtbSaidaTrabalho);
        }

        /// <summary>
        /// Cria a quarta linha com descrição do acidente.
        /// </summary>
        private void CriarLinha4()
        {
            int labelY = 420;
            int inputY = 445;

            lblDescricaoAcidente = CriarLabelCampo("DESCRIÇÃO DO ACIDENTE *", 20, labelY);

            txtDescricaoAcidente = new TextBox
            {
                Name = "txtDescricaoAcidente",
                Location = new Point(20, inputY),
                Size = new Size(1120, 110),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };

            pnlFormCard.Controls.Add(lblDescricaoAcidente);
            pnlFormCard.Controls.Add(txtDescricaoAcidente);
        }

        #endregion

        #region Métodos auxiliares de UI

        /// <summary>
        /// Cria label padronizada para nome dos campos.
        /// </summary>
        private Label CriarLabelCampo(string texto, int x, int y)
        {
            return new Label
            {
                Text = texto,
                Location = new Point(x, y),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = corLabelCampo
            };
        }

        /// <summary>
        /// Cria ComboBox padronizado.
        /// </summary>
        private ComboBox CriarComboBox(int x, int y, int largura, string[] itens)
        {
            ComboBox comboBox = new ComboBox
            {
                Location = new Point(x, y),
                Size = new Size(largura, 32),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            comboBox.Items.AddRange(itens);

            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;

            return comboBox;
        }

        /// <summary>
        /// Cria campo de hora padronizado.
        /// </summary>
        private MaskedTextBox CriarCampoHora(int x, int y, int largura)
        {
            return new MaskedTextBox
            {
                Mask = "00:00",
                Location = new Point(x, y),
                Size = new Size(largura, 32),
                TextMaskFormat = MaskFormat.IncludePromptAndLiterals
            };
        }

        /// <summary>
        /// Cria seletor de data padronizado.
        /// </summary>
        private DateTimePicker CriarDatePicker(int x, int y, int largura)
        {
            return new DateTimePicker
            {
                Location = new Point(x, y),
                Size = new Size(largura, 32),
                Format = DateTimePickerFormat.Short
            };
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Habilita ou desabilita a data de óbito.
        /// </summary>
        private void ChkSemDataObito_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataObito.Enabled = !chkSemDataObito.Checked;
        }

        /// <summary>
        /// Limpa ou fecha a operação conforme confirmação do usuário.
        /// </summary>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja limpar os campos do formulário?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                LimparFormulario();
            }
        }

        /// <summary>
        /// Executa validação, coleta e exibição dos dados ao salvar.
        /// </summary>
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            CatModel cat = ObterDadosFormulario();

            MessageBox.Show(
                "CAT salva com sucesso!\n\n" + cat,
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #endregion

        #region Regras de negócio da tela

        /// <summary>
        /// Valida os campos obrigatórios do formulário.
        /// </summary>
        private bool ValidarFormulario()
        {
            if (!HoraValida(mtbHoraAcidente.Text))
            {
                MessageBox.Show(
                    "Informe uma hora do acidente válida no formato HH:mm.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                mtbHoraAcidente.Focus();
                return false;
            }

            if (cmbEmpregado.SelectedIndex <= 0)
            {
                MessageBox.Show(
                    "Selecione um empregado.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbEmpregado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescricaoAcidente.Text))
            {
                MessageBox.Show(
                    "Informe a descrição do acidente.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDescricaoAcidente.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(mtbEntradaTrabalho.Text.Replace(":", "").Trim()) &&
                !HoraValida(mtbEntradaTrabalho.Text))
            {
                MessageBox.Show(
                    "Informe uma hora de entrada válida no formato HH:mm.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                mtbEntradaTrabalho.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(mtbSaidaTrabalho.Text.Replace(":", "").Trim()) &&
                !HoraValida(mtbSaidaTrabalho.Text))
            {
                MessageBox.Show(
                    "Informe uma hora de saída válida no formato HH:mm.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                mtbSaidaTrabalho.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Monta um objeto com os dados informados no formulário.
        /// </summary>
        private CatModel ObterDadosFormulario()
        {
            return new CatModel
            {
                DataAcidente = dtpDataAcidente.Value.Date,
                HoraAcidente = mtbHoraAcidente.Text,
                DataObito = chkSemDataObito.Checked ? (DateTime?)null : dtpDataObito.Value.Date,
                TipoCAT = cmbTipoCAT.Text,
                Empregado = cmbEmpregado.Text,
                EmitenteCAT = cmbEmitenteCAT.Text,
                LocalAcidente = cmbLocalAcidente.Text,
                EntradaTrabalho = mtbEntradaTrabalho.Text,
                SaidaTrabalho = mtbSaidaTrabalho.Text,
                DescricaoAcidente = txtDescricaoAcidente.Text.Trim()
            };
        }

        /// <summary>
        /// Limpa os campos e retorna o formulário ao estado inicial.
        /// </summary>
        private void LimparFormulario()
        {
            dtpDataAcidente.Value = DateTime.Today;
            mtbHoraAcidente.Clear();

            chkSemDataObito.Checked = true;
            dtpDataObito.Value = DateTime.Today;

            cmbTipoCAT.SelectedIndex = 0;
            cmbEmpregado.SelectedIndex = 0;
            cmbEmitenteCAT.SelectedIndex = 0;
            cmbLocalAcidente.SelectedIndex = 0;

            mtbEntradaTrabalho.Clear();
            mtbSaidaTrabalho.Clear();

            txtDescricaoAcidente.Clear();

            dtpDataAcidente.Focus();
        }

        /// <summary>
        /// Verifica se a hora está válida no formato HH:mm.
        /// </summary>
        private bool HoraValida(string horaTexto)
        {
            if (string.IsNullOrWhiteSpace(horaTexto) || horaTexto.Contains("_"))
                return false;

            return TimeSpan.TryParse(horaTexto, out TimeSpan hora)
                   && hora.Hours >= 0 && hora.Hours <= 23
                   && hora.Minutes >= 0 && hora.Minutes <= 59;
        }

        #endregion
    }
}
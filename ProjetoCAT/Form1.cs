using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoCAT
{
    public partial class Form1 : Form
    {
        private Panel pnlMenu;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlFormCard;

        private Button btnCancelar;
        private Button btnSalvar;

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

        public Form1()
        {
            InitializeComponent();

            ConfigurarFormulario();
            CriarEstruturaBase();
        }

        private void ConfigurarFormulario()
        {
            Text = "CAT - Comunicação de Acidente de Trabalho";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            BackColor = Color.FromArgb(240, 243, 248);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        private void CriarEstruturaBase()
        {
            CriarMenuLateral();
            CriarCabecalho();
            CriarAreaConteudo();
        }

        private void CriarMenuLateral()
        {
            pnlMenu = new Panel();
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Width = 280;
            pnlMenu.BackColor = Color.FromArgb(5, 45, 84);
            Controls.Add(pnlMenu);

            Label lblSistema = new Label();
            lblSistema.Text = "MedWork\r\nMedicina do Trabalho - SENAC";
            lblSistema.ForeColor = Color.White;
            lblSistema.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSistema.AutoSize = false;
            lblSistema.Size = new Size(240, 60);
            lblSistema.Location = new Point(20, 20);
            pnlMenu.Controls.Add(lblSistema);

            Button btnCAT = CriarBotaoMenu("CAT — Acidente (S-2210)", 160, true);
            pnlMenu.Controls.Add(btnCAT);

            Button btnMonitoramento = CriarBotaoMenu("Monit. Saúde / ASO (S-2220)", 210, false);
            pnlMenu.Controls.Add(btnMonitoramento);

            Button btnEmpregados = CriarBotaoMenu("Empregados", 260, false);
            pnlMenu.Controls.Add(btnEmpregados);
        }

        private Button CriarBotaoMenu(string texto, int y, bool ativo)
        {
            Button btn = new Button();
            btn.Width = 240;
            btn.Height = 40;
            btn.Location = new Point(20, y);
            btn.Text = texto;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.White;
            btn.BackColor = ativo
                ? Color.FromArgb(20, 85, 140)
                : Color.FromArgb(5, 45, 84);
            btn.TextAlign = ContentAlignment.MiddleLeft;

            return btn;
        }

        private void CriarCabecalho()
        {
            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.BackColor = Color.White;
            Controls.Add(pnlHeader);

            Label lblTitulo = new Label();
            lblTitulo.Text = "CAT — Acidente de Trabalho";
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 74, 122);
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(300, 12);
            pnlHeader.Controls.Add(lblTitulo);

            Label lblSubtitulo = new Label();
            lblSubtitulo.Text = "S-2210 - Comunicação de Acidente";
            lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(302, 40);
            pnlHeader.Controls.Add(lblSubtitulo);

            Button btnConfiguracoes = new Button();
            btnConfiguracoes.Text = "Configurações";
            btnConfiguracoes.Size = new Size(130, 35);
            btnConfiguracoes.Location = new Point(1100, 17);
            btnConfiguracoes.FlatStyle = FlatStyle.Flat;
            pnlHeader.Controls.Add(btnConfiguracoes);
        }

        private void CriarAreaConteudo()
        {
            pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.FromArgb(240, 243, 248);
            Controls.Add(pnlContent);

            CriarCardFormulario();
        }

        private void CriarCardFormulario()
        {
            pnlFormCard = new Panel();
            pnlFormCard.BackColor = Color.White;
            pnlFormCard.Size = new Size(1180, 620);
            pnlFormCard.Location = new Point(25, 20);
            pnlFormCard.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.Controls.Add(pnlFormCard);

            Label lblFormTitulo = new Label();
            lblFormTitulo.Text = "Comunicação de Acidente de Trabalho (CAT)";
            lblFormTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblFormTitulo.ForeColor = Color.FromArgb(30, 74, 122);
            lblFormTitulo.AutoSize = true;
            lblFormTitulo.Location = new Point(20, 20);
            pnlFormCard.Controls.Add(lblFormTitulo);

            btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.Location = new Point(930, 18);
            btnCancelar.Click += BtnCancelar_Click;
            pnlFormCard.Controls.Add(btnCancelar);

            btnSalvar = new Button();
            btnSalvar.Text = "Salvar CAT";
            btnSalvar.Size = new Size(120, 35);
            btnSalvar.Location = new Point(1040, 18);
            btnSalvar.BackColor = Color.FromArgb(0, 96, 180);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Click += BtnSalvar_Click;
            pnlFormCard.Controls.Add(btnSalvar);

            CriarCamposFormulario();
        }

        private void CriarCamposFormulario()
        {
            CriarLinha1();
            CriarLinha2();
            CriarLinha3();
            CriarLinha4();
        }

        private void CriarLinha1()
        {
            int labelY = 100;
            int inputY = 125;

            lblDataAcidente = CriarLabelCampo("DATA DO ACIDENTE *", 20, labelY);
            dtpDataAcidente = CriarDatePicker(20, inputY, 250);

            lblHoraAcidente = CriarLabelCampo("HORA DO ACIDENTE *", 290, labelY);
            mtbHoraAcidente = CriarCampoHora(290, inputY, 250);

            lblDataObito = CriarLabelCampo("DATA DO ÓBITO", 560, labelY);
            dtpDataObito = CriarDatePicker(560, inputY, 220);

            chkSemDataObito = new CheckBox();
            chkSemDataObito.Text = "Não se aplica";
            chkSemDataObito.AutoSize = true;
            chkSemDataObito.Location = new Point(560, 162);
            chkSemDataObito.Checked = true;
            dtpDataObito.Enabled = false;
            chkSemDataObito.CheckedChanged += ChkSemDataObito_CheckedChanged;

            lblTipoCAT = CriarLabelCampo("TIPO DE CAT *", 830, labelY);
            cmbTipoCAT = CriarComboBox(830, inputY, 300, new string[]
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

        private void CriarLinha2()
        {
            int labelY = 195;
            int inputY = 220;

            lblEmpregado = CriarLabelCampo("EMPREGADO *", 20, labelY);
            cmbEmpregado = CriarComboBox(20, inputY, 520, new string[]
            {
                "-- Selecione o empregado --",
                "João da Silva",
                "Maria Oliveira",
                "Carlos Souza"
            });

            lblEmitenteCAT = CriarLabelCampo("EMITENTE DA CAT *", 560, labelY);
            cmbEmitenteCAT = CriarComboBox(560, inputY, 570, new string[]
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

        private void CriarLinha3()
        {
            int labelY = 290;
            int inputY = 315;

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

        private void CriarLinha4()
        {
            int labelY = 385;
            int inputY = 410;

            lblDescricaoAcidente = CriarLabelCampo("DESCRIÇÃO DO ACIDENTE *", 20, labelY);

            txtDescricaoAcidente = new TextBox();
            txtDescricaoAcidente.Location = new Point(20, inputY);
            txtDescricaoAcidente.Size = new Size(1110, 120);
            txtDescricaoAcidente.Multiline = true;
            txtDescricaoAcidente.ScrollBars = ScrollBars.Vertical;

            pnlFormCard.Controls.Add(lblDescricaoAcidente);
            pnlFormCard.Controls.Add(txtDescricaoAcidente);
        }

        private Label CriarLabelCampo(string texto, int x, int y)
        {
            Label lbl = new Label();
            lbl.Text = texto;
            lbl.Location = new Point(x, y);
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(220, 80, 60);

            return lbl;
        }

        private ComboBox CriarComboBox(int x, int y, int largura, string[] itens)
        {
            ComboBox cmb = new ComboBox();
            cmb.Location = new Point(x, y);
            cmb.Size = new Size(largura, 32);
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.Items.AddRange(itens);

            if (cmb.Items.Count > 0)
                cmb.SelectedIndex = 0;

            return cmb;
        }

        private MaskedTextBox CriarCampoHora(int x, int y, int largura)
        {
            MaskedTextBox mtb = new MaskedTextBox();
            mtb.Mask = "00:00";
            mtb.Location = new Point(x, y);
            mtb.Size = new Size(largura, 32);

            return mtb;
        }

        private DateTimePicker CriarDatePicker(int x, int y, int largura)
        {
            DateTimePicker dtp = new DateTimePicker();
            dtp.Location = new Point(x, y);
            dtp.Size = new Size(largura, 32);
            dtp.Format = DateTimePickerFormat.Short;

            return dtp;
        }

        private void ChkSemDataObito_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataObito.Enabled = !chkSemDataObito.Checked;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja limpar os campos?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                LimparFormulario();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            string resumo =
                "CAT salva com sucesso!\n\n" +
                "Data do acidente: " + dtpDataAcidente.Value.ToString("dd/MM/yyyy") + "\n" +
                "Hora do acidente: " + mtbHoraAcidente.Text + "\n" +
                "Tipo de CAT: " + cmbTipoCAT.Text + "\n" +
                "Empregado: " + cmbEmpregado.Text + "\n" +
                "Emitente da CAT: " + cmbEmitenteCAT.Text + "\n" +
                "Local do acidente: " + cmbLocalAcidente.Text + "\n" +
                "Entrada no trabalho: " + mtbEntradaTrabalho.Text + "\n" +
                "Saída do trabalho: " + mtbSaidaTrabalho.Text + "\n" +
                "Descrição: " + txtDescricaoAcidente.Text;

            MessageBox.Show(resumo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarFormulario()
        {
            if (mtbHoraAcidente.Text.Contains("_"))
            {
                MessageBox.Show("Informe a hora do acidente.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbHoraAcidente.Focus();
                return false;
            }

            if (cmbEmpregado.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecione o empregado.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEmpregado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescricaoAcidente.Text))
            {
                MessageBox.Show("Informe a descrição do acidente.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricaoAcidente.Focus();
                return false;
            }

            return true;
        }

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
        }
    }
}
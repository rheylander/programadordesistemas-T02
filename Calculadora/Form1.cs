using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        private decimal _primeiroNumero = 0m;
        private string _operador = "";
        private bool _aguardandoNovoNumero = true;

        public frmCalculadora()
        {
            InitializeComponent();
            ConfigurarCalculadora();
        }

        private void ConfigurarCalculadora()
        {
            // Configuração inicial do display
            tbDisplay.Text = "0";
            tbDisplay.ReadOnly = true;
            tbDisplay.TextAlign = HorizontalAlignment.Right;

            // Liga os botões que ainda não estavam ligados no Designer
            btnSoma.Click += btnSoma_Click;
            btnSubtracao.Click += btnSubtracao_Click;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            btnDivisao.Click += btnDivisao_Click;
            btnIgual.Click += btnIgual_Click;
            btnPonto.Click += btnPonto_Click;
        }

        // =========================
        // MÉTODOS AUXILIARES
        // =========================

        private void AdicionarNumero(string numero)
        {
            if (_aguardandoNovoNumero || tbDisplay.Text == "0")
            {
                tbDisplay.Text = numero;
                _aguardandoNovoNumero = false;
            }
            else
            {
                tbDisplay.Text += numero;
            }
        }

        private void AdicionarSeparadorDecimal()
        {
            string separador = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (_aguardandoNovoNumero)
            {
                tbDisplay.Text = "0" + separador;
                _aguardandoNovoNumero = false;
                return;
            }

            if (!tbDisplay.Text.Contains(separador))
            {
                tbDisplay.Text += separador;
            }
        }

        private decimal LerValorDisplay()
        {
            string texto = tbDisplay.Text.Trim();

            // Tenta com a cultura atual (pt-BR geralmente usa vírgula)
            if (decimal.TryParse(texto, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal valor))
                return valor;

            // Plano B: caso venha com ponto
            string normalizado = texto.Replace(",", ".");
            if (decimal.TryParse(normalizado, NumberStyles.Number, CultureInfo.InvariantCulture, out valor))
                return valor;

            return 0m;
        }

        private void PrepararOperacao(string operador)
        {
            // Se o usuário apertar operador duas vezes seguidas, apenas troca o operador
            if (_aguardandoNovoNumero)
            {
                _operador = operador;
                return;
            }

            // Se já existe operação pendente, calcula antes (ex.: 2 + 3 + 4)
            if (!string.IsNullOrEmpty(_operador))
            {
                ExecutarCalculo();
            }
            else
            {
                _primeiroNumero = LerValorDisplay();
            }

            _operador = operador;
            _aguardandoNovoNumero = true;
        }

        private void ExecutarCalculo()
        {
            if (string.IsNullOrEmpty(_operador))
                return;

            decimal segundoNumero = LerValorDisplay();
            decimal resultado = 0m;

            try
            {
                switch (_operador)
                {
                    case "+":
                        resultado = _primeiroNumero + segundoNumero;
                        break;

                    case "-":
                        resultado = _primeiroNumero - segundoNumero;
                        break;

                    case "x":
                    case "X":
                    case "*":
                        resultado = _primeiroNumero * segundoNumero;
                        break;

                    case "/":
                    case "÷":
                        if (segundoNumero == 0)
                        {
                            MessageBox.Show(
                                "Não é possível dividir por zero.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            LimparTudo();
                            return;
                        }
                        resultado = _primeiroNumero / segundoNumero;
                        break;

                    default:
                        return;
                }

                tbDisplay.Text = resultado.ToString(CultureInfo.CurrentCulture);
                _primeiroNumero = resultado;
                _aguardandoNovoNumero = true;
            }
            catch
            {
                MessageBox.Show(
                    "Ocorreu um erro no cálculo.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                LimparTudo();
            }
        }

        private void LimparTudo()
        {
            tbDisplay.Text = "0";
            _primeiroNumero = 0m;
            _operador = "";
            _aguardandoNovoNumero = true;
        }

        // =========================
        // BOTÕES NUMÉRICOS (já existiam)
        // =========================

        private void btn0_Click(object sender, EventArgs e)
        {
            AdicionarNumero("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AdicionarNumero("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AdicionarNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AdicionarNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AdicionarNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AdicionarNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AdicionarNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AdicionarNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AdicionarNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AdicionarNumero("9");
        }

        // =========================
        // BOTÕES DE OPERAÇÃO (novos)
        // =========================

        private void btnSoma_Click(object sender, EventArgs e)
        {
            PrepararOperacao("+");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            PrepararOperacao("-");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            PrepararOperacao("x");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            PrepararOperacao("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_operador))
                return;

            ExecutarCalculo();
            _operador = "";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            AdicionarSeparadorDecimal();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }
    }
}

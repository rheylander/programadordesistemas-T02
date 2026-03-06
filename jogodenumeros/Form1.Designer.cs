namespace jogodenumeros
{
    partial class frmJogoNumeros
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.txtNumeroInserido = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnTentativa = new System.Windows.Forms.Button();
            this.lblAbaixoBotao = new System.Windows.Forms.Label();
            this.lblNumerosTentativas = new System.Windows.Forms.Label();
            this.panelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.Red;
            this.panelTopo.Controls.Add(this.lblTitulo);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(800, 100);
            this.panelTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(257, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(392, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Boas Vindas ao meu Jogo de Números";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Red;
            this.lblSubtitulo.Location = new System.Drawing.Point(204, 124);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(509, 22);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Você tem 10 tentativas. Insira um número de 1 até 100.";
            // 
            // txtNumeroInserido
            // 
            this.txtNumeroInserido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroInserido.ForeColor = System.Drawing.Color.Red;
            this.txtNumeroInserido.Location = new System.Drawing.Point(244, 160);
            this.txtNumeroInserido.Name = "txtNumeroInserido";
            this.txtNumeroInserido.Size = new System.Drawing.Size(405, 31);
            this.txtNumeroInserido.TabIndex = 2;
            this.txtNumeroInserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Red;
            this.txtResultado.Location = new System.Drawing.Point(124, 373);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(664, 31);
            this.txtResultado.TabIndex = 3;
            // 
            // btnTentativa
            // 
            this.btnTentativa.BackColor = System.Drawing.Color.Red;
            this.btnTentativa.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTentativa.ForeColor = System.Drawing.Color.White;
            this.btnTentativa.Location = new System.Drawing.Point(351, 213);
            this.btnTentativa.Name = "btnTentativa";
            this.btnTentativa.Size = new System.Drawing.Size(180, 51);
            this.btnTentativa.TabIndex = 4;
            this.btnTentativa.Text = "Tentar";
            this.btnTentativa.UseVisualStyleBackColor = false;
            this.btnTentativa.Click += new System.EventHandler(this.btnTentativa_Click);
            // 
            // lblAbaixoBotao
            // 
            this.lblAbaixoBotao.AutoSize = true;
            this.lblAbaixoBotao.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbaixoBotao.Location = new System.Drawing.Point(167, 313);
            this.lblAbaixoBotao.Name = "lblAbaixoBotao";
            this.lblAbaixoBotao.Size = new System.Drawing.Size(326, 40);
            this.lblAbaixoBotao.TabIndex = 5;
            this.lblAbaixoBotao.Text = "Veja quantas tentativas restam:";
            // 
            // lblNumerosTentativas
            // 
            this.lblNumerosTentativas.AutoSize = true;
            this.lblNumerosTentativas.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumerosTentativas.Location = new System.Drawing.Point(532, 304);
            this.lblNumerosTentativas.Name = "lblNumerosTentativas";
            this.lblNumerosTentativas.Size = new System.Drawing.Size(54, 45);
            this.lblNumerosTentativas.TabIndex = 6;
            this.lblNumerosTentativas.Text = "10";
            // 
            // frmJogoNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumerosTentativas);
            this.Controls.Add(this.lblAbaixoBotao);
            this.Controls.Add(this.btnTentativa);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumeroInserido);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.panelTopo);
            this.Name = "frmJogoNumeros";
            this.Text = "Jogo de Números";
            this.Load += new System.EventHandler(this.frmJogoNumeros_Load);
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txtNumeroInserido;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnTentativa;
        private System.Windows.Forms.Label lblAbaixoBotao;
        private System.Windows.Forms.Label lblNumerosTentativas;
    }
}


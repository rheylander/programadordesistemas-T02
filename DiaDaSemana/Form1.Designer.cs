namespace DiaDaSemana
{
    partial class FrmCalendario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExibiDiaDaSemana = new System.Windows.Forms.Label();
            this.txtInsereNumeroDaSemana = new System.Windows.Forms.TextBox();
            this.txtPerguntaDiaDaSemana = new System.Windows.Forms.TextBox();
            this.btnVerificarDiaDaSemana = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.lblExibiDiaDaSemana);
            this.panel1.Controls.Add(this.txtInsereNumeroDaSemana);
            this.panel1.Controls.Add(this.txtPerguntaDiaDaSemana);
            this.panel1.Controls.Add(this.btnVerificarDiaDaSemana);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // lblExibiDiaDaSemana
            // 
            this.lblExibiDiaDaSemana.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblExibiDiaDaSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExibiDiaDaSemana.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblExibiDiaDaSemana.Location = new System.Drawing.Point(196, 311);
            this.lblExibiDiaDaSemana.Name = "lblExibiDiaDaSemana";
            this.lblExibiDiaDaSemana.Size = new System.Drawing.Size(355, 42);
            this.lblExibiDiaDaSemana.TabIndex = 3;
            this.lblExibiDiaDaSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExibiDiaDaSemana.Click += new System.EventHandler(this.lblExibiDiaDaSemana_Click);
            // 
            // txtInsereNumeroDaSemana
            // 
            this.txtInsereNumeroDaSemana.Location = new System.Drawing.Point(297, 150);
            this.txtInsereNumeroDaSemana.Name = "txtInsereNumeroDaSemana";
            this.txtInsereNumeroDaSemana.Size = new System.Drawing.Size(153, 40);
            this.txtInsereNumeroDaSemana.TabIndex = 2;
            this.txtInsereNumeroDaSemana.TextChanged += new System.EventHandler(this.txtInsereNumeroDaSemana_TextChanged);
            // 
            // txtPerguntaDiaDaSemana
            // 
            this.txtPerguntaDiaDaSemana.Location = new System.Drawing.Point(98, 77);
            this.txtPerguntaDiaDaSemana.Name = "txtPerguntaDiaDaSemana";
            this.txtPerguntaDiaDaSemana.Size = new System.Drawing.Size(550, 40);
            this.txtPerguntaDiaDaSemana.TabIndex = 1;
            this.txtPerguntaDiaDaSemana.Text = "Qual o dia da semana de hoje?";
            this.txtPerguntaDiaDaSemana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerificarDiaDaSemana
            // 
            this.btnVerificarDiaDaSemana.Location = new System.Drawing.Point(202, 222);
            this.btnVerificarDiaDaSemana.Name = "btnVerificarDiaDaSemana";
            this.btnVerificarDiaDaSemana.Size = new System.Drawing.Size(342, 51);
            this.btnVerificarDiaDaSemana.TabIndex = 0;
            this.btnVerificarDiaDaSemana.Text = "Mostrar dia da semana";
            this.btnVerificarDiaDaSemana.UseVisualStyleBackColor = true;
            this.btnVerificarDiaDaSemana.Click += new System.EventHandler(this.btnVerificarDiaDaSemana_Click);
            // 
            // FrmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCalendario";
            this.Text = "Calendário";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVerificarDiaDaSemana;
        private System.Windows.Forms.TextBox txtInsereNumeroDaSemana;
        private System.Windows.Forms.TextBox txtPerguntaDiaDaSemana;
        private System.Windows.Forms.Label lblExibiDiaDaSemana;
    }
}


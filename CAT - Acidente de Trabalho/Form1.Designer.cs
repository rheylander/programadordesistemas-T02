namespace ProjetoCAT
{
    partial class FrmCAT
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
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.dateTimePicker1DataDoAcidente = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker2DataDoObito = new System.Windows.Forms.DateTimePicker();
            this.comboBox1TipoDeCat = new System.Windows.Forms.ComboBox();
            this.comboBox2Empregado = new System.Windows.Forms.ComboBox();
            this.comboBox3EmitenteDaCat = new System.Windows.Forms.ComboBox();
            this.comboBox4LocalDoAcidente = new System.Windows.Forms.ComboBox();
            this.maskedTextBox2EntradaNoTrabalho = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3SaidaDoTrabalho = new System.Windows.Forms.MaskedTextBox();
            this.textBox1DescricaoDoAcidente = new System.Windows.Forms.TextBox();
            this.pnlTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.Controls.Add(this.textBox1DescricaoDoAcidente);
            this.pnlTopo.Controls.Add(this.maskedTextBox3SaidaDoTrabalho);
            this.pnlTopo.Controls.Add(this.maskedTextBox2EntradaNoTrabalho);
            this.pnlTopo.Controls.Add(this.comboBox4LocalDoAcidente);
            this.pnlTopo.Controls.Add(this.comboBox3EmitenteDaCat);
            this.pnlTopo.Controls.Add(this.comboBox2Empregado);
            this.pnlTopo.Controls.Add(this.comboBox1TipoDeCat);
            this.pnlTopo.Controls.Add(this.dateTimePicker2DataDoObito);
            this.pnlTopo.Controls.Add(this.maskedTextBox1);
            this.pnlTopo.Controls.Add(this.dateTimePicker1DataDoAcidente);
            this.pnlTopo.Location = new System.Drawing.Point(47, 36);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(601, 493);
            this.pnlTopo.TabIndex = 0;
            // 
            // dateTimePicker1DataDoAcidente
            // 
            this.dateTimePicker1DataDoAcidente.Location = new System.Drawing.Point(357, 34);
            this.dateTimePicker1DataDoAcidente.Name = "dateTimePicker1DataDoAcidente";
            this.dateTimePicker1DataDoAcidente.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1DataDoAcidente.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(357, 65);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(117, 25);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.Text = "Hora do Acidente";
            // 
            // dateTimePicker2DataDoObito
            // 
            this.dateTimePicker2DataDoObito.Location = new System.Drawing.Point(357, 110);
            this.dateTimePicker2DataDoObito.Name = "dateTimePicker2DataDoObito";
            this.dateTimePicker2DataDoObito.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2DataDoObito.TabIndex = 7;
            // 
            // comboBox1TipoDeCat
            // 
            this.comboBox1TipoDeCat.FormattingEnabled = true;
            this.comboBox1TipoDeCat.Location = new System.Drawing.Point(357, 141);
            this.comboBox1TipoDeCat.Name = "comboBox1TipoDeCat";
            this.comboBox1TipoDeCat.Size = new System.Drawing.Size(121, 25);
            this.comboBox1TipoDeCat.TabIndex = 8;
            this.comboBox1TipoDeCat.Text = "Tipo de CAT";
            // 
            // comboBox2Empregado
            // 
            this.comboBox2Empregado.FormattingEnabled = true;
            this.comboBox2Empregado.Location = new System.Drawing.Point(357, 172);
            this.comboBox2Empregado.Name = "comboBox2Empregado";
            this.comboBox2Empregado.Size = new System.Drawing.Size(121, 25);
            this.comboBox2Empregado.TabIndex = 9;
            this.comboBox2Empregado.Text = "Empregado";
            // 
            // comboBox3EmitenteDaCat
            // 
            this.comboBox3EmitenteDaCat.FormattingEnabled = true;
            this.comboBox3EmitenteDaCat.Location = new System.Drawing.Point(357, 206);
            this.comboBox3EmitenteDaCat.Name = "comboBox3EmitenteDaCat";
            this.comboBox3EmitenteDaCat.Size = new System.Drawing.Size(121, 25);
            this.comboBox3EmitenteDaCat.TabIndex = 10;
            this.comboBox3EmitenteDaCat.Text = "Emitente da CAT";
            // 
            // comboBox4LocalDoAcidente
            // 
            this.comboBox4LocalDoAcidente.FormattingEnabled = true;
            this.comboBox4LocalDoAcidente.Location = new System.Drawing.Point(357, 238);
            this.comboBox4LocalDoAcidente.Name = "comboBox4LocalDoAcidente";
            this.comboBox4LocalDoAcidente.Size = new System.Drawing.Size(131, 25);
            this.comboBox4LocalDoAcidente.TabIndex = 11;
            this.comboBox4LocalDoAcidente.Text = "Local do Acidente";
            // 
            // maskedTextBox2EntradaNoTrabalho
            // 
            this.maskedTextBox2EntradaNoTrabalho.Location = new System.Drawing.Point(357, 270);
            this.maskedTextBox2EntradaNoTrabalho.Name = "maskedTextBox2EntradaNoTrabalho";
            this.maskedTextBox2EntradaNoTrabalho.Size = new System.Drawing.Size(151, 25);
            this.maskedTextBox2EntradaNoTrabalho.TabIndex = 12;
            this.maskedTextBox2EntradaNoTrabalho.Text = "Entrada no Trabalho";
            // 
            // maskedTextBox3SaidaDoTrabalho
            // 
            this.maskedTextBox3SaidaDoTrabalho.Location = new System.Drawing.Point(357, 302);
            this.maskedTextBox3SaidaDoTrabalho.Name = "maskedTextBox3SaidaDoTrabalho";
            this.maskedTextBox3SaidaDoTrabalho.Size = new System.Drawing.Size(131, 25);
            this.maskedTextBox3SaidaDoTrabalho.TabIndex = 13;
            this.maskedTextBox3SaidaDoTrabalho.Text = "Saida do Trabalho";
            // 
            // textBox1DescricaoDoAcidente
            // 
            this.textBox1DescricaoDoAcidente.Location = new System.Drawing.Point(357, 350);
            this.textBox1DescricaoDoAcidente.Name = "textBox1DescricaoDoAcidente";
            this.textBox1DescricaoDoAcidente.Size = new System.Drawing.Size(100, 25);
            this.textBox1DescricaoDoAcidente.TabIndex = 14;
            this.textBox1DescricaoDoAcidente.Text = "Descrição do Acidente";
            // 
            // FrmCAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.pnlTopo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAT - Acidente de Trabalho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1DataDoAcidente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.TextBox textBox1DescricaoDoAcidente;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3SaidaDoTrabalho;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2EntradaNoTrabalho;
        private System.Windows.Forms.ComboBox comboBox4LocalDoAcidente;
        private System.Windows.Forms.ComboBox comboBox3EmitenteDaCat;
        private System.Windows.Forms.ComboBox comboBox2Empregado;
        private System.Windows.Forms.ComboBox comboBox1TipoDeCat;
        private System.Windows.Forms.DateTimePicker dateTimePicker2DataDoObito;
    }
}


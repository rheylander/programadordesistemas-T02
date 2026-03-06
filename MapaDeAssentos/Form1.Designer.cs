namespace MatrizesWinFormsAssentos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.FlowLayoutPanel pnlTopo;
        private System.Windows.Forms.Label lblLinhasTitulo;
        private System.Windows.Forms.NumericUpDown nudLinhas;
        private System.Windows.Forms.Label lblColunasTitulo;
        private System.Windows.Forms.NumericUpDown nudColunas;

        private System.Windows.Forms.Button btnGerar;

        private System.Windows.Forms.GroupBox gbModo;
        private System.Windows.Forms.FlowLayoutPanel pnlModo;
        private System.Windows.Forms.RadioButton rbReservar;
        private System.Windows.Forms.RadioButton rbBloquear;
        private System.Windows.Forms.RadioButton rbLiberar;

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnLimpar;

        private System.Windows.Forms.TableLayoutPanel gridAssentos;

        private System.Windows.Forms.FlowLayoutPanel pnlRodape;
        private System.Windows.Forms.Label lblLivres;
        private System.Windows.Forms.Label lblSep1;
        private System.Windows.Forms.Label lblReservados;
        private System.Windows.Forms.Label lblSep2;
        private System.Windows.Forms.Label lblBloqueados;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTopo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLinhasTitulo = new System.Windows.Forms.Label();
            this.nudLinhas = new System.Windows.Forms.NumericUpDown();
            this.lblColunasTitulo = new System.Windows.Forms.Label();
            this.nudColunas = new System.Windows.Forms.NumericUpDown();
            this.btnGerar = new System.Windows.Forms.Button();
            this.gbModo = new System.Windows.Forms.GroupBox();
            this.pnlModo = new System.Windows.Forms.FlowLayoutPanel();
            this.rbReservar = new System.Windows.Forms.RadioButton();
            this.rbBloquear = new System.Windows.Forms.RadioButton();
            this.rbLiberar = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gridAssentos = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRodape = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLivres = new System.Windows.Forms.Label();
            this.lblSep1 = new System.Windows.Forms.Label();
            this.lblReservados = new System.Windows.Forms.Label();
            this.lblSep2 = new System.Windows.Forms.Label();
            this.lblBloqueados = new System.Windows.Forms.Label();
            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).BeginInit();
            this.gbModo.SuspendLayout();
            this.pnlModo.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.AutoSize = true;
            this.pnlTopo.Controls.Add(this.lblLinhasTitulo);
            this.pnlTopo.Controls.Add(this.nudLinhas);
            this.pnlTopo.Controls.Add(this.lblColunasTitulo);
            this.pnlTopo.Controls.Add(this.nudColunas);
            this.pnlTopo.Controls.Add(this.btnGerar);
            this.pnlTopo.Controls.Add(this.gbModo);
            this.pnlTopo.Controls.Add(this.btnSalvar);
            this.pnlTopo.Controls.Add(this.btnCarregar);
            this.pnlTopo.Controls.Add(this.btnLimpar);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.pnlTopo.Size = new System.Drawing.Size(843, 101);
            this.pnlTopo.TabIndex = 0;
            // 
            // lblLinhasTitulo
            // 
            this.lblLinhasTitulo.AutoSize = true;
            this.lblLinhasTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblLinhasTitulo.Name = "lblLinhasTitulo";
            this.lblLinhasTitulo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblLinhasTitulo.Size = new System.Drawing.Size(41, 18);
            this.lblLinhasTitulo.TabIndex = 0;
            this.lblLinhasTitulo.Text = "Linhas:";
            // 
            // nudLinhas
            // 
            this.nudLinhas.Location = new System.Drawing.Point(59, 12);
            this.nudLinhas.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudLinhas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudLinhas.Name = "nudLinhas";
            this.nudLinhas.Size = new System.Drawing.Size(51, 20);
            this.nudLinhas.TabIndex = 1;
            this.nudLinhas.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblColunasTitulo
            // 
            this.lblColunasTitulo.AutoSize = true;
            this.lblColunasTitulo.Location = new System.Drawing.Point(122, 9);
            this.lblColunasTitulo.Margin = new System.Windows.Forms.Padding(9, 0, 3, 0);
            this.lblColunasTitulo.Name = "lblColunasTitulo";
            this.lblColunasTitulo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblColunasTitulo.Size = new System.Drawing.Size(48, 18);
            this.lblColunasTitulo.TabIndex = 2;
            this.lblColunasTitulo.Text = "Colunas:";
            // 
            // nudColunas
            // 
            this.nudColunas.Location = new System.Drawing.Point(176, 12);
            this.nudColunas.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudColunas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudColunas.Name = "nudColunas";
            this.nudColunas.Size = new System.Drawing.Size(51, 20);
            this.nudColunas.TabIndex = 3;
            this.nudColunas.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnGerar
            // 
            this.btnGerar.AutoSize = true;
            this.btnGerar.Location = new System.Drawing.Point(243, 12);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(72, 23);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar Grid";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // gbModo
            // 
            this.gbModo.AutoSize = true;
            this.gbModo.Controls.Add(this.pnlModo);
            this.gbModo.Location = new System.Drawing.Point(331, 9);
            this.gbModo.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.gbModo.Name = "gbModo";
            this.gbModo.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.gbModo.Size = new System.Drawing.Size(275, 54);
            this.gbModo.TabIndex = 5;
            this.gbModo.TabStop = false;
            this.gbModo.Text = "Modo";
            // 
            // pnlModo
            // 
            this.pnlModo.AutoSize = true;
            this.pnlModo.Controls.Add(this.rbReservar);
            this.pnlModo.Controls.Add(this.rbBloquear);
            this.pnlModo.Controls.Add(this.rbLiberar);
            this.pnlModo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModo.Location = new System.Drawing.Point(9, 22);
            this.pnlModo.Name = "pnlModo";
            this.pnlModo.Size = new System.Drawing.Size(257, 23);
            this.pnlModo.TabIndex = 0;
            // 
            // rbReservar
            // 
            this.rbReservar.AutoSize = true;
            this.rbReservar.Location = new System.Drawing.Point(3, 3);
            this.rbReservar.Name = "rbReservar";
            this.rbReservar.Size = new System.Drawing.Size(115, 17);
            this.rbReservar.TabIndex = 0;
            this.rbReservar.TabStop = true;
            this.rbReservar.Text = "Reservar/Cancelar";
            this.rbReservar.UseVisualStyleBackColor = true;
            // 
            // rbBloquear
            // 
            this.rbBloquear.AutoSize = true;
            this.rbBloquear.Location = new System.Drawing.Point(124, 3);
            this.rbBloquear.Name = "rbBloquear";
            this.rbBloquear.Size = new System.Drawing.Size(67, 17);
            this.rbBloquear.TabIndex = 1;
            this.rbBloquear.Text = "Bloquear";
            this.rbBloquear.UseVisualStyleBackColor = true;
            // 
            // rbLiberar
            // 
            this.rbLiberar.AutoSize = true;
            this.rbLiberar.Location = new System.Drawing.Point(197, 3);
            this.rbLiberar.Name = "rbLiberar";
            this.rbLiberar.Size = new System.Drawing.Size(57, 17);
            this.rbLiberar.TabIndex = 2;
            this.rbLiberar.Text = "Liberar";
            this.rbLiberar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Location = new System.Drawing.Point(619, 12);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar (CSV)";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.AutoSize = true;
            this.btnCarregar.Location = new System.Drawing.Point(702, 12);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(87, 23);
            this.btnCarregar.TabIndex = 7;
            this.btnCarregar.Text = "Carregar (CSV)";
            this.btnCarregar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.Location = new System.Drawing.Point(12, 66);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // gridAssentos
            // 
            this.gridAssentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gridAssentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAssentos.Location = new System.Drawing.Point(0, 101);
            this.gridAssentos.Name = "gridAssentos";
            this.gridAssentos.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.gridAssentos.Size = new System.Drawing.Size(843, 354);
            this.gridAssentos.TabIndex = 1;
            // 
            // pnlRodape
            // 
            this.pnlRodape.AutoSize = true;
            this.pnlRodape.Controls.Add(this.lblLivres);
            this.pnlRodape.Controls.Add(this.lblSep1);
            this.pnlRodape.Controls.Add(this.lblReservados);
            this.pnlRodape.Controls.Add(this.lblSep2);
            this.pnlRodape.Controls.Add(this.lblBloqueados);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 455);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.pnlRodape.Size = new System.Drawing.Size(843, 31);
            this.pnlRodape.TabIndex = 2;
            // 
            // lblLivres
            // 
            this.lblLivres.AutoSize = true;
            this.lblLivres.Location = new System.Drawing.Point(12, 9);
            this.lblLivres.Name = "lblLivres";
            this.lblLivres.Size = new System.Drawing.Size(47, 13);
            this.lblLivres.TabIndex = 0;
            this.lblLivres.Text = "Livres: 0";
            // 
            // lblSep1
            // 
            this.lblSep1.AutoSize = true;
            this.lblSep1.Location = new System.Drawing.Point(65, 9);
            this.lblSep1.Name = "lblSep1";
            this.lblSep1.Size = new System.Drawing.Size(15, 13);
            this.lblSep1.TabIndex = 1;
            this.lblSep1.Text = " | ";
            // 
            // lblReservados
            // 
            this.lblReservados.AutoSize = true;
            this.lblReservados.Location = new System.Drawing.Point(86, 9);
            this.lblReservados.Name = "lblReservados";
            this.lblReservados.Size = new System.Drawing.Size(76, 13);
            this.lblReservados.TabIndex = 2;
            this.lblReservados.Text = "Reservados: 0";
            // 
            // lblSep2
            // 
            this.lblSep2.AutoSize = true;
            this.lblSep2.Location = new System.Drawing.Point(168, 9);
            this.lblSep2.Name = "lblSep2";
            this.lblSep2.Size = new System.Drawing.Size(15, 13);
            this.lblSep2.TabIndex = 3;
            this.lblSep2.Text = " | ";
            // 
            // lblBloqueados
            // 
            this.lblBloqueados.AutoSize = true;
            this.lblBloqueados.Location = new System.Drawing.Point(189, 9);
            this.lblBloqueados.Name = "lblBloqueados";
            this.lblBloqueados.Size = new System.Drawing.Size(75, 13);
            this.lblBloqueados.TabIndex = 4;
            this.lblBloqueados.Text = "Bloqueados: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 486);
            this.Controls.Add(this.gridAssentos);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlTopo);
            this.MinimumSize = new System.Drawing.Size(774, 525);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapa de Assentos - Matrizes (WinForms .NET)";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).EndInit();
            this.gbModo.ResumeLayout(false);
            this.gbModo.PerformLayout();
            this.pnlModo.ResumeLayout(false);
            this.pnlModo.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlRodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
namespace tabuadacomloop
{
    partial class frmTabuadaLoop
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
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.panelDireito = new System.Windows.Forms.Panel();
            this.lblTopo = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnExecutarTabuada = new System.Windows.Forms.Button();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.panelFundo.SuspendLayout();
            this.panelEsquerdo.SuspendLayout();
            this.panelDireito.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.Cyan;
            this.panelFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFundo.Controls.Add(this.panelDireito);
            this.panelFundo.Controls.Add(this.panelEsquerdo);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(800, 450);
            this.panelFundo.TabIndex = 0;
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.BackColor = System.Drawing.Color.PeachPuff;
            this.panelEsquerdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEsquerdo.Controls.Add(this.lstTabuada);
            this.panelEsquerdo.Location = new System.Drawing.Point(10, 10);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(350, 400);
            this.panelEsquerdo.TabIndex = 0;
            // 
            // panelDireito
            // 
            this.panelDireito.BackColor = System.Drawing.Color.PeachPuff;
            this.panelDireito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDireito.Controls.Add(this.btnExecutarTabuada);
            this.panelDireito.Controls.Add(this.txtNumero);
            this.panelDireito.Controls.Add(this.lblTopo);
            this.panelDireito.Location = new System.Drawing.Point(434, 10);
            this.panelDireito.Name = "panelDireito";
            this.panelDireito.Size = new System.Drawing.Size(350, 400);
            this.panelDireito.TabIndex = 1;
            // 
            // lblTopo
            // 
            this.lblTopo.AutoSize = true;
            this.lblTopo.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopo.Location = new System.Drawing.Point(54, 29);
            this.lblTopo.Name = "lblTopo";
            this.lblTopo.Size = new System.Drawing.Size(240, 32);
            this.lblTopo.TabIndex = 0;
            this.lblTopo.Text = "Insira um número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(60, 88);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(234, 62);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExecutarTabuada
            // 
            this.btnExecutarTabuada.BackColor = System.Drawing.Color.Cyan;
            this.btnExecutarTabuada.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnExecutarTabuada.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutarTabuada.ForeColor = System.Drawing.Color.Black;
            this.btnExecutarTabuada.Location = new System.Drawing.Point(60, 255);
            this.btnExecutarTabuada.Name = "btnExecutarTabuada";
            this.btnExecutarTabuada.Size = new System.Drawing.Size(234, 81);
            this.btnExecutarTabuada.TabIndex = 2;
            this.btnExecutarTabuada.Text = " Executar Tabuada";
            this.btnExecutarTabuada.UseVisualStyleBackColor = false;
            this.btnExecutarTabuada.Click += new System.EventHandler(this.btnExecutarTabuada_Click);
            // 
            // lstTabuada
            // 
            this.lstTabuada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.ItemHeight = 25;
            this.lstTabuada.Location = new System.Drawing.Point(16, 29);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(300, 329);
            this.lstTabuada.TabIndex = 0;
            // 
            // frmTabuadaLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFundo);
            this.Name = "frmTabuadaLoop";
            this.Text = "Tabuada Com Loop";
            this.panelFundo.ResumeLayout(false);
            this.panelEsquerdo.ResumeLayout(false);
            this.panelDireito.ResumeLayout(false);
            this.panelDireito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelEsquerdo;
        private System.Windows.Forms.Panel panelDireito;
        private System.Windows.Forms.Label lblTopo;
        private System.Windows.Forms.Button btnExecutarTabuada;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ListBox lstTabuada;
    }
}


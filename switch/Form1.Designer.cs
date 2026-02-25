namespace @switch
{
    partial class Form1
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodigoInserido = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.txtCodigoInserido);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Moccasin;
            this.btnEnviar.Location = new System.Drawing.Point(341, 187);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(118, 34);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEnviar_MouseClick);
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescricao.Enabled = false;
            this.lblDescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescricao.Location = new System.Drawing.Point(350, 254);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(100, 23);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoInserido
            // 
            this.txtCodigoInserido.BackColor = System.Drawing.Color.Moccasin;
            this.txtCodigoInserido.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoInserido.Location = new System.Drawing.Point(350, 121);
            this.txtCodigoInserido.Name = "txtCodigoInserido";
            this.txtCodigoInserido.Size = new System.Drawing.Size(100, 33);
            this.txtCodigoInserido.TabIndex = 1;
            this.txtCodigoInserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Moccasin;
            this.lblTitulo.Location = new System.Drawing.Point(125, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(551, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Insira o código de 1 a 6 para exibir o tipo de carro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Condicional Switch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtCodigoInserido;
        private System.Windows.Forms.Button btnEnviar;
    }
}


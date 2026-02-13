namespace exibirnome
{
    partial class frmExibirNome
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
            this.txtExibirNome = new System.Windows.Forms.TextBox();
            this.btnExibirNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExibirNome
            // 
            this.txtExibirNome.BackColor = System.Drawing.Color.White;
            this.txtExibirNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExibirNome.ForeColor = System.Drawing.Color.Black;
            this.txtExibirNome.Location = new System.Drawing.Point(151, 141);
            this.txtExibirNome.Name = "txtExibirNome";
            this.txtExibirNome.Size = new System.Drawing.Size(472, 39);
            this.txtExibirNome.TabIndex = 0;
            
            // 
            // btnExibirNome
            // 
            this.btnExibirNome.BackColor = System.Drawing.Color.Black;
            this.btnExibirNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirNome.ForeColor = System.Drawing.Color.Gold;
            this.btnExibirNome.Location = new System.Drawing.Point(268, 83);
            this.btnExibirNome.Name = "btnExibirNome";
            this.btnExibirNome.Size = new System.Drawing.Size(222, 52);
            this.btnExibirNome.TabIndex = 1;
            this.btnExibirNome.Text = "Exibir Nome";
            this.btnExibirNome.UseVisualStyleBackColor = false;
            this.btnExibirNome.Click += new System.EventHandler(this.btnExibirNome_Click);
            // 
            // frmExibirNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExibirNome);
            this.Controls.Add(this.txtExibirNome);
            this.Name = "frmExibirNome";
            this.Text = "Exibir Nome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExibirNome;
        private System.Windows.Forms.Button btnExibirNome;
    }
}


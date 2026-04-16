namespace MenuSideBar
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarFilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelDeAtendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.senhaToolStripMenuItem,
            this.filaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inicioToolStripMenuItem.Text = "Início";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // senhaToolStripMenuItem
            // 
            this.senhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarSenhaToolStripMenuItem,
            this.chamarSenhaToolStripMenuItem});
            this.senhaToolStripMenuItem.Name = "senhaToolStripMenuItem";
            this.senhaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.senhaToolStripMenuItem.Text = "Senha";
            // 
            // gerarSenhaToolStripMenuItem
            // 
            this.gerarSenhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.gerarSenhaToolStripMenuItem.Name = "gerarSenhaToolStripMenuItem";
            this.gerarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerarSenhaToolStripMenuItem.Text = "Gerar Senha";
            this.gerarSenhaToolStripMenuItem.Click += new System.EventHandler(this.gerarSenhaToolStripMenuItem_Click);
            // 
            // chamarSenhaToolStripMenuItem
            // 
            this.chamarSenhaToolStripMenuItem.Name = "chamarSenhaToolStripMenuItem";
            this.chamarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chamarSenhaToolStripMenuItem.Text = "Chamar Senha";
            // 
            // filaToolStripMenuItem
            // 
            this.filaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarFilaToolStripMenuItem,
            this.painelDeAtendimentoToolStripMenuItem});
            this.filaToolStripMenuItem.Name = "filaToolStripMenuItem";
            this.filaToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filaToolStripMenuItem.Text = "Fila";
            // 
            // visualizarFilaToolStripMenuItem
            // 
            this.visualizarFilaToolStripMenuItem.Name = "visualizarFilaToolStripMenuItem";
            this.visualizarFilaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.visualizarFilaToolStripMenuItem.Text = "Visualizar Fila";
            this.visualizarFilaToolStripMenuItem.Click += new System.EventHandler(this.visualizarFilaToolStripMenuItem_Click);
            // 
            // painelDeAtendimentoToolStripMenuItem
            // 
            this.painelDeAtendimentoToolStripMenuItem.Name = "painelDeAtendimentoToolStripMenuItem";
            this.painelDeAtendimentoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.painelDeAtendimentoToolStripMenuItem.Text = "Painel de Atendimento";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "105";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "109";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "240";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "365";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "585";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema de Senhas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarFilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem painelDeAtendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}
namespace formFixo
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuFixo = new System.Windows.Forms.MenuStrip();
            this.menuFixoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFixoPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFixoRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFixoControle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFixoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFixo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFixo
            // 
            this.menuFixo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFixoNovo,
            this.menuFixoPesquisar,
            this.menuFixoRelatorio,
            this.menuFixoControle,
            this.menuFixoSair});
            this.menuFixo.Location = new System.Drawing.Point(0, 0);
            this.menuFixo.Name = "menuFixo";
            this.menuFixo.Size = new System.Drawing.Size(933, 24);
            this.menuFixo.TabIndex = 0;
            this.menuFixo.Text = "menuStrip1";
            // 
            // menuFixoNovo
            // 
            this.menuFixoNovo.Name = "menuFixoNovo";
            this.menuFixoNovo.Size = new System.Drawing.Size(48, 20);
            this.menuFixoNovo.Text = "Novo";
            this.menuFixoNovo.Click += new System.EventHandler(this.menuFixoNovo_Click);
            // 
            // menuFixoPesquisar
            // 
            this.menuFixoPesquisar.Name = "menuFixoPesquisar";
            this.menuFixoPesquisar.Size = new System.Drawing.Size(69, 20);
            this.menuFixoPesquisar.Text = "Pesquisar";
            this.menuFixoPesquisar.Click += new System.EventHandler(this.menuFixoPesquisar_Click);
            // 
            // menuFixoRelatorio
            // 
            this.menuFixoRelatorio.Name = "menuFixoRelatorio";
            this.menuFixoRelatorio.Size = new System.Drawing.Size(66, 20);
            this.menuFixoRelatorio.Text = "Relatório";
            this.menuFixoRelatorio.Click += new System.EventHandler(this.menuFixoRelatorio_Click);
            // 
            // menuFixoControle
            // 
            this.menuFixoControle.Name = "menuFixoControle";
            this.menuFixoControle.Size = new System.Drawing.Size(65, 20);
            this.menuFixoControle.Text = "Controle";
            this.menuFixoControle.Click += new System.EventHandler(this.menuFixoControle_Click);
            // 
            // menuFixoSair
            // 
            this.menuFixoSair.Name = "menuFixoSair";
            this.menuFixoSair.Size = new System.Drawing.Size(38, 20);
            this.menuFixoSair.Text = "Sair";
            this.menuFixoSair.Click += new System.EventHandler(this.menuFixoSair_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.menuFixo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuFixo;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Atendimento ";
            this.menuFixo.ResumeLayout(false);
            this.menuFixo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuFixo;
        private System.Windows.Forms.ToolStripMenuItem menuFixoNovo;
        private System.Windows.Forms.ToolStripMenuItem menuFixoPesquisar;
        private System.Windows.Forms.ToolStripMenuItem menuFixoRelatorio;
        private System.Windows.Forms.ToolStripMenuItem menuFixoControle;
        private System.Windows.Forms.ToolStripMenuItem menuFixoSair;
    }
}
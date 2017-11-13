namespace formFixo
{
    partial class formNovo
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
            this.btnNovoSalvar = new System.Windows.Forms.Button();
            this.btnNovoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovoSalvar
            // 
            this.btnNovoSalvar.Location = new System.Drawing.Point(735, 359);
            this.btnNovoSalvar.Name = "btnNovoSalvar";
            this.btnNovoSalvar.Size = new System.Drawing.Size(91, 29);
            this.btnNovoSalvar.TabIndex = 0;
            this.btnNovoSalvar.Text = "Salvar";
            this.btnNovoSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovoCancelar
            // 
            this.btnNovoCancelar.Location = new System.Drawing.Point(832, 359);
            this.btnNovoCancelar.Name = "btnNovoCancelar";
            this.btnNovoCancelar.Size = new System.Drawing.Size(91, 29);
            this.btnNovoCancelar.TabIndex = 1;
            this.btnNovoCancelar.Text = "Cancelar";
            this.btnNovoCancelar.UseVisualStyleBackColor = true;
            this.btnNovoCancelar.Click += new System.EventHandler(this.btnNovoCancelar_Click);
            // 
            // formNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 400);
            this.Controls.Add(this.btnNovoCancelar);
            this.Controls.Add(this.btnNovoSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "formNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controle Atendimento - Novo Atendimento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formNovo_FormClosing);
            this.Load += new System.EventHandler(this.formNovo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoSalvar;
        private System.Windows.Forms.Button btnNovoCancelar;
    }
}
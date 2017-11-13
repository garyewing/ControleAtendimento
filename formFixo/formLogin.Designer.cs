namespace formFixo
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.btnLoginEntrar = new System.Windows.Forms.Button();
            this.btnLoginSair = new System.Windows.Forms.Button();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.lblLoginSenha = new System.Windows.Forms.Label();
            this.lblLoginAtendimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoginEntrar
            // 
            this.btnLoginEntrar.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.btnLoginEntrar.Location = new System.Drawing.Point(442, 276);
            this.btnLoginEntrar.Name = "btnLoginEntrar";
            this.btnLoginEntrar.Size = new System.Drawing.Size(106, 36);
            this.btnLoginEntrar.TabIndex = 0;
            this.btnLoginEntrar.Text = "Entrar";
            this.btnLoginEntrar.UseVisualStyleBackColor = true;
            // 
            // btnLoginSair
            // 
            this.btnLoginSair.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginSair.Location = new System.Drawing.Point(583, 276);
            this.btnLoginSair.Name = "btnLoginSair";
            this.btnLoginSair.Size = new System.Drawing.Size(106, 36);
            this.btnLoginSair.TabIndex = 1;
            this.btnLoginSair.Text = "Sair";
            this.btnLoginSair.UseVisualStyleBackColor = true;
            this.btnLoginSair.Click += new System.EventHandler(this.btnLoginSair_Click);
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.txtLoginUser.Location = new System.Drawing.Point(495, 136);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(194, 33);
            this.txtLoginUser.TabIndex = 2;
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.txtLoginSenha.Location = new System.Drawing.Point(495, 189);
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.Size = new System.Drawing.Size(194, 33);
            this.txtLoginSenha.TabIndex = 3;
            this.txtLoginSenha.UseSystemPasswordChar = true;
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginUser.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUser.Location = new System.Drawing.Point(403, 139);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(64, 26);
            this.lblLoginUser.TabIndex = 4;
            this.lblLoginUser.Text = "Login";
            this.lblLoginUser.Click += new System.EventHandler(this.lblLoginUser_Click);
            // 
            // lblLoginSenha
            // 
            this.lblLoginSenha.AutoSize = true;
            this.lblLoginSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginSenha.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.lblLoginSenha.Location = new System.Drawing.Point(403, 192);
            this.lblLoginSenha.Name = "lblLoginSenha";
            this.lblLoginSenha.Size = new System.Drawing.Size(67, 26);
            this.lblLoginSenha.TabIndex = 5;
            this.lblLoginSenha.Text = "Senha";
            // 
            // lblLoginAtendimento
            // 
            this.lblLoginAtendimento.AutoSize = true;
            this.lblLoginAtendimento.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginAtendimento.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAtendimento.Location = new System.Drawing.Point(448, 43);
            this.lblLoginAtendimento.Name = "lblLoginAtendimento";
            this.lblLoginAtendimento.Size = new System.Drawing.Size(217, 42);
            this.lblLoginAtendimento.TabIndex = 6;
            this.lblLoginAtendimento.Text = "Atendimento";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formFixo.Properties.Resources.logoSplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(750, 354);
            this.Controls.Add(this.lblLoginAtendimento);
            this.Controls.Add(this.lblLoginSenha);
            this.Controls.Add(this.lblLoginUser);
            this.Controls.Add(this.txtLoginSenha);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.btnLoginSair);
            this.Controls.Add(this.btnLoginEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Atendimento - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginEntrar;
        private System.Windows.Forms.Button btnLoginSair;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.Label lblLoginSenha;
        private System.Windows.Forms.Label lblLoginAtendimento;
    }
}
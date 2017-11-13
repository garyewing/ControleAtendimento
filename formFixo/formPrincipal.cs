using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace formFixo
{
    public partial class formPrincipal : Form
    {
        public static formPrincipal staticVariavel = null;
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void menuFixoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuFixoNovo_Click(object sender, EventArgs e)
        {
            staticVariavel = this;
            this.Hide();
            Form novo = new formNovo();
            novo.ShowDialog(this);
            
        }

       
        private void menuFixoPesquisar_Click(object sender, EventArgs e)
        {
            staticVariavel = this;
            this.Hide();
            Form pesquisar = new formPesquisar();
            pesquisar.ShowDialog(this);
        }

        private void menuFixoRelatorio_Click(object sender, EventArgs e)
        {
            staticVariavel = this;
            this.Hide();
            Form relatorio = new formRelatorio();
            relatorio.ShowDialog(this);
        }

        private void menuFixoControle_Click(object sender, EventArgs e)
        {
            staticVariavel = this;
            this.Hide();
            Form controle = new formControle();
            controle.ShowDialog(this);
        }
    }
}

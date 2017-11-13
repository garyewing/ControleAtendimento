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
    public partial class formPesquisar : Form
    {
        public formPesquisar()
        {
            InitializeComponent();
        }

        private void formPesquisar_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrincipal.staticVariavel.Show();
            e.Cancel = false;
        }

        private void formPesquisar_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class formRelatorio : Form
    {
        public formRelatorio()
        {
            InitializeComponent();
        }
        private void formRelatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrincipal.staticVariavel.Show();
            e.Cancel = false;
        }
        private void formRelatorio_Load(object sender, EventArgs e)
        {

        }
    }
}

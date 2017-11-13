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
    public partial class formControle : Form
    {
        public formControle()
        {
            InitializeComponent();
        }

        private void formControle_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrincipal.staticVariavel.Show();
            e.Cancel = false;
        }
        private void formControle_Load(object sender, EventArgs e)
        {

        }
    }
}

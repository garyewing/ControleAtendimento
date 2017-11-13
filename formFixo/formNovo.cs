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
    public partial class formNovo : Form
    {
        public formNovo()
        {
            InitializeComponent();
        }
        private void formNovo_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrincipal.staticVariavel.Show();
            e.Cancel = false; 
        }

        private void btnNovoCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
            formPrincipal.staticVariavel.Show();
        }

        private void formNovo_Load(object sender, EventArgs e)
        {
           
        }
    }
}

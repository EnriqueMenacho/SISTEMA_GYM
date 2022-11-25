using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_ADS
{
    public partial class form_pagos : Form
    {
        public form_pagos()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
            form_home pantalla = new form_home();
            pantalla.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

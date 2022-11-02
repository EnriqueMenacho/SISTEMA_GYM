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
    public partial class form_ficha : Form
    {
        public form_ficha()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
            form_home pantalla = new form_home();
            pantalla.Show();
        }

        private void form_ficha_Load(object sender, EventArgs e)
        {

        }

        private void lbl_altura_Click(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click_1(object sender, EventArgs e)
        {
            form_home pantalla = new form_home();
            this.Close();
            pantalla.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_home pantalla = new form_home();
            this.Close();
            pantalla.Show();
        }
    }
}

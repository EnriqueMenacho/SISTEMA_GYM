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
    public partial class form_asistencia : Form
    {
        public form_asistencia()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
            form_home pantalla = new form_home();
            pantalla.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click_1(object sender, EventArgs e)
        {
            form_home pantalla_pricipal = new form_home();
            this.Close();
            pantalla_pricipal.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form_home pantalla_pricipal = new form_home();
            this.Close();
            pantalla_pricipal.Show();
        }
    }
}

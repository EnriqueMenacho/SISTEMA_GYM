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
    public partial class form_cliente : Form
    {
        public form_cliente()
        {
            InitializeComponent();

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void tab_FICHA_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(1);
            lbl_cedula.Text = txt_cedula.Text;
            lbl_nombre.Text = txt_nombre.Text;
            lbl_apellido.Text = txt_apellido.Text;
            lbl_direccion.Text = txt_direccion.Text;
            lbl_celular.Text = txt_celular.Text;
            lbl_fechaNac.Text= cmb_dias.Text + "/" + cmb_mes.Text + "/" + cmb_ano.Text;
            if (radioButton1.Checked) {
                lbl_sexo.Text = "MASCULINO";
            }
            else
            {
                lbl_sexo.Text = "FEMENINO";
            }


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tab_DM_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(2);
            lbl_tipo.Text = cmb_membresia.Text;
            lbl_costos.Text = txt_costos.Text;
            lbl_fechaPago.Text = cmb_diaFP.Text + "/" + cmb_mesFP.Text + "/" + cmb_anoFP.Text;
            lbl_proximoPago.Text = txt_pp.Text;
            lbl_total.Text = txt_tp.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabControl1.SelectTab(3);
                lbl_nivel.Text = cmb_nivel.Text;
                lbl_peso.Text= txt_peso.Text + " Kg";
                lbl_altura.Text = txt_altura.Text + " Cm";
                lbl_cintura.Text= txt_cintura.Text + " Cm";
                lbl_cuello.Text = txt_cuello.Text + " Cm";
                lbl_cadera.Text = txt_cadera.Text + " Cm";
                //formula imc
                float imc = (float.Parse(txt_peso.Text)/((float.Parse(txt_altura.Text) / 100) * (float.Parse(txt_altura.Text) / 100)));
                lbl_imc.Text = Convert.ToString(Math.Round(imc));

            }
            catch
            {
                MessageBox.Show("POR FAVOR RELLENE LOS CAMPOS CORRECTAMENTE");
                this.tabControl1.SelectTab(2);
            }
            
        }

        private void label29_Click(object sender, EventArgs e) 
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("***EL CLIENTE FUE REGISTRADO***\nLOS DATOS SE GUARDARON CORRECTAMENTE");
            this.Close();
            form_home pantalla2 = new form_home();
            pantalla2.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
            form_home pantalla = new form_home();
            pantalla.Show();

        }
    }
}

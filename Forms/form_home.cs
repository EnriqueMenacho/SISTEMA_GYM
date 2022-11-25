using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_ADS
{
    public partial class form_home : Form
    {
        public form_home()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form_home_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            form_cliente pantalla = new form_cliente();
            pantalla.Show();
            this.Hide();
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
           form_cliente pantalla = new form_cliente();
            pantalla.Show();
            this.Hide();
        }

        private void btn_nuevaAsistencia_Click(object sender, EventArgs e)
        {
            form_asistencia pantalla = new form_asistencia();
            pantalla.Show();
            this.Hide();
        }

        private void lbl_btn_nuevaAsistencia_Click(object sender, EventArgs e)
        {
            form_asistencia pantalla = new form_asistencia();
            pantalla.Show();
            this.Hide();
        }

        private void btn_nuevoPago_Click(object sender, EventArgs e)
        {
            form_pagos pantalla = new form_pagos();
            pantalla.Show();
            this.Hide();
        }

        private void lbl_btn_nuevoPago_Click(object sender, EventArgs e)
        {
            form_pagos pantalla = new form_pagos();
            pantalla.Show();
            this.Hide();
        }

        private void btn_nuevaFicha_Click(object sender, EventArgs e)
        {
            form_ficha pantalla = new form_ficha();
            pantalla.Show();
            this.Hide();
        }

        private void lbl_btn_nuevaFicha_Click(object sender, EventArgs e)
        {
            form_ficha pantalla = new form_ficha();
            pantalla.Show();
            this.Hide();
        }

        private void btn_nuevaRutina_Click(object sender, EventArgs e)
        {
            form_rutinas pantalla = new form_rutinas();
            pantalla.Show();
            this.Hide();
        }

        private void lbl_btn_nuevaRutina_Click(object sender, EventArgs e)
        {
            form_rutinas pantalla = new form_rutinas();
            pantalla.Show();
            this.Hide();
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            form_modificarCliente pantalla = new form_modificarCliente();
            pantalla.Show();
            this.Hide();
        }

        private void lbl_btn_buscarCliente_Click(object sender, EventArgs e)
        {
            form_modificarCliente pantalla = new form_modificarCliente();
            pantalla.Show();
            this.Hide();
        }

        private void btn_buscarMembresia_Click(object sender, EventArgs e)
        {
            form_membresia pantalla = new form_membresia();
            pantalla.Show();
            this.Hide();
        }

        private void lbl_btn_buscarMembresia_Click(object sender, EventArgs e)
        {
            form_membresia pantalla = new form_membresia();
            pantalla.Show();
            this.Hide();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            form_reporte pantalla = new form_reporte();
            pantalla.Show();
            this.Hide();
        }

        private void lbl_btn_reportes_Click(object sender, EventArgs e)
        {
            form_reporte pantalla = new form_reporte();
            pantalla.Show();
            this.Hide();
        }
    }
}

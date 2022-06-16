using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Residencia.Logica;
using Residencia.Modelo;

namespace Residencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Apoyos objeto = new Apoyos()
            {
                Nombre = txtnombreb.Text,
                Apellido = txtapellidob.Text
            };
            //los datos se van a guardar en esta variable respuesta
            bool respuesta = Apoyoslogica.Instancia.Consultar(objeto);
            if (respuesta)
            {
                limpiar();
                mostar_apoyos1();
            } 

        }
        public void mostar_apoyos1()
        {
            
            dgvapoyosb.DataSource = null;
            dgvapoyosb.DataSource = Apoyoslogica.Instancia.Listar(); //para que de la informacion, devuelve la lista de personas

        }
        public void limpiar()
        {
            txtnombreb.Text = "";
            txtapellidob.Text = "";
            txtnombreb.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Registro();
            formulario.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        /*private void txtnombreb_Enter(object sender, EventArgs e)
        {
            TextBox textb = (TextBox)sender;
            if(textb.Text == textb.Tag.ToString())
            {
                textb.Text = String.Empty;
                textb.ForeColor = Color.Black;
            }
        }

        private void txtnombreb_Leave(object sender, EventArgs e)
        {
            TextBox textb = (TextBox)sender;
            if (string.IsNullOrEmpty(textb.Text))
            {
                textb.Text = textb.Tag.ToString();
                textb.ForeColor = Color.DarkGray;
            }
        }*/
    }
}

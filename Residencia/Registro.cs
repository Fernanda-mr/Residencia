using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Residencia.Modelo;
using Residencia.Logica;

namespace Residencia
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Apoyos objeto = new Apoyos()
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Tipo_Apoyo = txboxtapoyo.Text

            };
            bool respuesta = Apoyoslogica.Instancia.Guardar(objeto);

            if (respuesta)
            {
                MessageBox.Show("Beneficiario " + objeto.Nombre.ToString() + " registrado en apoyo para: " + objeto.Tipo_Apoyo.ToString());
                limpiar();
                mostar_apoyos();
            }
        }

        public void mostar_apoyos()
        {
            dgvapoyos.DataSource = null;
            dgvapoyos.DataSource = Apoyoslogica.Instancia.Listar(); //para que de la informacion, devuelve la lista de personas
            
        }

        public void limpiar()
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txboxtapoyo.Text = "";
            txtnombre.Focus();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            mostar_apoyos();
           // txboxtapoyo.SelectedIndex = 0;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Apoyos objeto = new Apoyos()
            {
                ID = int.Parse (txtid.Text),
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Tipo_Apoyo = txboxtapoyo.Text
            };
            //los datos se van a guardar en esta variable respuesta
            bool respuesta = Apoyoslogica.Instancia.Editar(objeto);
            if (respuesta)
            {
                MessageBox.Show("Editado correctamente");
                limpiar();
                mostar_apoyos();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        /*d
         * Hacer todo en un evento.
         * Hacer desaparecer el textbox si no hay texto escrito
         * No dejar redimensionar o maximizar la ventana
         */

        /*
        private void nombre_TextChanged(object sender, EventArgs e)
        {
            resultado.Text = nombre.Text + " " + apellido1.Text + " " + apellido2.Text;
        }

        private void apellido1_TextChanged(object sender, EventArgs e)
        {

            resultado.Text = nombre.Text + " " + apellido1.Text + " " + apellido2.Text;

        }

        private void apellido2_TextChanged(object sender, EventArgs e)
        {
            resultado.Text = nombre.Text + " " + apellido1.Text + " " + apellido2.Text;

        }

        private void cbCambiaOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCambiaOrden.Checked)
            {
                resultado.Text = apellido1.Text + " " + apellido2.Text + ", " + nombre.Text;
            }
            else
            {
                resultado.Text = nombre.Text + " " + apellido1.Text + " " + apellido2.Text;

            }
        }
        */

        private void mostrarTextoCompleto(Object sender, EventArgs e)
        {
           
            if (cbCambiaOrden.Checked)
            {
                resultado.Text = apellido1.Text + " " + apellido2.Text + ", " + nombre.Text;
            }
            else
            {
                resultado.Text = nombre.Text + " " + apellido1.Text + " " + apellido2.Text;

            }

        }


    }
}

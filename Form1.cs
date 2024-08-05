using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Tareas_pendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void B_agregar_Click(object sender, EventArgs e)
        {
            var materia = txt_materia.Text;
            var contenido = txt_contenido.Text; 
            var Fecha = F_entrega.Text;

            if (materia != "" && contenido != "")
            {
                String cadena = materia + "  ||  " + contenido + "  ||  " + Fecha;
                list_tareas.Items.Add(cadena);
                LimpiarCajas();
            }
            else
            {
                MessageBox.Show("Complete los Campos");
            }

        }
        public void LimpiarCajas()
        {
            txt_materia.Text = "";
            txt_contenido.Text = "";
        }

        private void B_eliminar_Click(object sender, EventArgs e)
        {
            if (list_tareas.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar ", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    list_tareas.Items.RemoveAt(list_tareas.SelectedIndex);
                    list_tareas.Items.Remove(list_tareas.SelectedIndex);
                    MessageBox.Show("Se elimino con exito");
                }
                else
                {
                    MessageBox.Show("Se canceló con exito");
                }
            }
            else
            {
                MessageBox.Show("Operación invalida");
            }
        }
    }
}

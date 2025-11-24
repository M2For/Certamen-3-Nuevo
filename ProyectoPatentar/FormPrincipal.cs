using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPatentar
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void btnSolicitantes_Click(object sender, EventArgs e)
        {
            FormSolicitante21 formProductos = new FormSolicitante21();
            formProductos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdentificacionMarca formProductos = new IdentificacionMarca();
            formProductos.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClasificacion21 formProductos = new FormClasificacion21();
            formProductos.ShowDialog();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            FormResumen21 formProductos = new FormResumen21();
            formProductos.ShowDialog(); 
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "¿Está seguro de salir?",
            "Confirmar Salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

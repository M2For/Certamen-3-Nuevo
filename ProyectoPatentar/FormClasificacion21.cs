using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPatentar
{
    public partial class FormClasificacion21 : Form
    {
        private List<Clasificacion> listaClasificaciones = new List<Clasificacion>();
        private string archivoClasificaciones = "clasificaciones.txt";
        private int indiceEditando = -1;

        public FormClasificacion21()
        {
            InitializeComponent();
            CargarClasificaciones();
        }


        private void CargarClasificaciones()
        {
            listaClasificaciones.Clear();

            if (File.Exists(archivoClasificaciones))
            {
                string[] lineas = File.ReadAllLines(archivoClasificaciones);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        Clasificacion c = Clasificacion.DesdeTexto(linea);
                        if (c != null) listaClasificaciones.Add(c);
                    }
                }
            }
            ActualizarGrid();
        }

        private void GuardarClasificaciones()
        {
            List<string> lineas = new List<string>();
            foreach (Clasificacion c in listaClasificaciones)
            {
                lineas.Add(c.ATexto());
            }
            File.WriteAllLines(archivoClasificaciones, lineas);
        }

        private void ActualizarGrid()
        {
            dgvClasificacion.Rows.Clear();

            foreach (Clasificacion c in listaClasificaciones)
            {
                int index = dgvClasificacion.Rows.Add();
                dgvClasificacion.Rows[index].Cells["colClaseNumero"].Value = c.ClaseNumero.ToString();
                dgvClasificacion.Rows[index].Cells["colDescripcion"].Value = c.Descripcion;
            }
        }

        private bool ValidarCampos()
        {
            if (!int.TryParse(txtClaseNumero.Text, out int clase) || clase < 1 || clase > 45)
            {
                MessageBox.Show("Ingrese un número de clase válido entre 1 y 45.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcionProductos.Text))
            {
                MessageBox.Show("Debe ingresar una descripción específica de los productos/servicios para esta clase.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtClaseNumero.Clear();
            txtDescripcionProductos.Clear();
            txtClaseNumero.Focus();

            indiceEditando = -1;
            btnAgregar.Text = "Agregar";
        }


        private void txtClaseNumero_TextChanged(object sender, EventArgs e) { }
        private void txtDescripcionProductos_TextChanged(object sender, EventArgs e) { }

        private void txtClaseNumero_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int claseNum = int.Parse(txtClaseNumero.Text);

            if (indiceEditando >= 0)
            {
                listaClasificaciones[indiceEditando].ClaseNumero = claseNum;
                listaClasificaciones[indiceEditando].Descripcion = txtDescripcionProductos.Text;

                indiceEditando = -1;
                btnAgregar.Text = "Agregar";
                MessageBox.Show("Clasificación actualizada correctamente.");
            }
            else
            {
                foreach (Clasificacion c in listaClasificaciones)
                {
                    if (c.ClaseNumero == claseNum)
                    {
                        MessageBox.Show($"La Clase {claseNum} ya está registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                Clasificacion nueva = new Clasificacion(
                    claseNum,
                    txtDescripcionProductos.Text
                );

                listaClasificaciones.Add(nueva);
                MessageBox.Show("Clasificación agregada correctamente.");
            }

            GuardarClasificaciones();
            ActualizarGrid();
            LimpiarCampos();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dgvClasificacion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una clase para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            indiceEditando = dgvClasificacion.SelectedRows[0].Index;
            Clasificacion c = listaClasificaciones[indiceEditando];

            txtClaseNumero.Text = c.ClaseNumero.ToString();
            txtDescripcionProductos.Text = c.Descripcion;

            btnAgregar.Text = "Guardar Cambios";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClasificacion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una clase para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar esta clase de clasificación?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int indice = dgvClasificacion.SelectedRows[0].Index;
                listaClasificaciones.RemoveAt(indice);

                GuardarClasificaciones();
                ActualizarGrid();
                LimpiarCampos();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

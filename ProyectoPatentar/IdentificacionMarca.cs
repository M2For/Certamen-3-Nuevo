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
    public partial class IdentificacionMarca : Form
    {
        private List<Identificacion> listaIdentificaciones = new List<Identificacion>();
        private string archivoIdentificaciones = "identificaciones.txt";
        private int indiceEditando = -1;

        public IdentificacionMarca()
        {
            InitializeComponent();
            CargarIdentificaciones();
        }


        private void CargarIdentificaciones()
        {
            listaIdentificaciones.Clear();

            if (File.Exists(archivoIdentificaciones))
            {
                string[] lineas = File.ReadAllLines(archivoIdentificaciones);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        Identificacion id = Identificacion.DesdeTexto(linea);
                        if (id != null) listaIdentificaciones.Add(id);
                    }
                }
            }
            ActualizarGrid();
        }

        private void GuardarIdentificaciones()
        {
            List<string> lineas = new List<string>();
            foreach (Identificacion id in listaIdentificaciones)
            {
                lineas.Add(id.ATexto());
            }
            File.WriteAllLines(archivoIdentificaciones, lineas);
        }

        private void ActualizarGrid()
        {
            dgvPatentes.Rows.Clear(); 

            foreach (Identificacion id in listaIdentificaciones)
            {
                int index = dgvPatentes.Rows.Add();
                dgvPatentes.Rows[index].Cells["colNombreMarca"].Value = id.NombreMarca;
                dgvPatentes.Rows[index].Cells["colTipoMarca"].Value = id.TipoMarca;
                dgvPatentes.Rows[index].Cells["colDescripcionLogo"].Value = id.DescripcionLogo;
                dgvPatentes.Rows[index].Cells["colTraduccion"].Value = id.Traduccion;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreMarca.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la marca.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTipoMarca.Text))
            {
                MessageBox.Show("Debe indicar el tipo de marca (Ej: Denominativa, Mixta, Figurativa).", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtNombreMarca.Clear();
            txtTipoMarca.Clear();
            txtDescripcionLogo.Clear();
            txtTraduccion.Clear();
            txtNombreMarca.Focus();

            indiceEditando = -1;
            btnAgregar.Text = "Agregar";
        }

        private void txtNombreMarca_TextChanged(object sender, EventArgs e) { }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            string nombre = txtNombreMarca.Text;

            if (indiceEditando >= 0)
            {
                listaIdentificaciones[indiceEditando].NombreMarca = nombre;
                listaIdentificaciones[indiceEditando].TipoMarca = txtTipoMarca.Text;
                listaIdentificaciones[indiceEditando].DescripcionLogo = txtDescripcionLogo.Text;
                listaIdentificaciones[indiceEditando].Traduccion = txtTraduccion.Text;

                indiceEditando = -1;
                btnAgregar.Text = "Agregar";
                MessageBox.Show("Identificación actualizada correctamente.");
            }
            else
            {
                foreach (Identificacion id in listaIdentificaciones)
                {
                    if (id.NombreMarca.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Esta identificación ya está en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                Identificacion nueva = new Identificacion(
                    nombre,
                    txtTipoMarca.Text,
                    txtDescripcionLogo.Text,
                    txtTraduccion.Text
                );

                listaIdentificaciones.Add(nueva);
                MessageBox.Show("Identificación agregada correctamente.");
            }

            GuardarIdentificaciones();
            ActualizarGrid();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPatentes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una identificación para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            indiceEditando = dgvPatentes.SelectedRows[0].Index;
            Identificacion id = listaIdentificaciones[indiceEditando];

            txtNombreMarca.Text = id.NombreMarca;
            txtTipoMarca.Text = id.TipoMarca;
            txtDescripcionLogo.Text = id.DescripcionLogo;
            txtTraduccion.Text = id.Traduccion;

            btnAgregar.Text = "Guardar Cambios";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPatentes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una identificación para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar esta identificación?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int indice = dgvPatentes.SelectedRows[0].Index;
                listaIdentificaciones.RemoveAt(indice);

                GuardarIdentificaciones();
                ActualizarGrid();
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}

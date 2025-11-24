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
    public partial class FormSolicitante21 : Form
    {
        // Lista de Solicitantes (antes Productos)
        private List<Solicitante> listaSolicitantes = new List<Solicitante>();
        private string archivoSolicitantes = "solicitantes.txt"; // Archivo actualizado
        private int indiceEditando = -1;

        public FormSolicitante21()
        {
            InitializeComponent();
            CargarSolicitantes();
        }

        // Cargar solicitantes desde archivo
        private void CargarSolicitantes()
        {
            listaSolicitantes.Clear();

            if (File.Exists(archivoSolicitantes))
            {
                string[] lineas = File.ReadAllLines(archivoSolicitantes);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        Solicitante s = Solicitante.DesdeTexto(linea);
                        if (s != null) listaSolicitantes.Add(s);
                    }
                }
            }
            ActualizarGrid();
        }

        // Guardar solicitantes en archivo
        private void GuardarSolicitantes()
        {
            List<string> lineas = new List<string>();
            foreach (Solicitante s in listaSolicitantes)
            {
                lineas.Add(s.ATexto());
            }
            File.WriteAllLines(archivoSolicitantes, lineas);
        }

        // Actualizar DataGridView
        private void ActualizarGrid()
        {
            dgvProductos.Rows.Clear();

            foreach (Solicitante s in listaSolicitantes)
            {
                int index = dgvProductos.Rows.Add();
                dgvProductos.Rows[index].Cells["colNombre"].Value = s.Nombre;
                dgvProductos.Rows[index].Cells["colRut"].Value = s.Rut;
                dgvProductos.Rows[index].Cells["colEmail"].Value = s.Email;
                dgvProductos.Rows[index].Cells["colTelefono"].Value = s.Telefono.ToString();
                dgvProductos.Rows[index].Cells["colTipoPersona"].Value = s.TipoPersona;
                dgvProductos.Rows[index].Cells["colDomicilio"].Value = s.Domicilio;
            }
        }

        // Validar campos
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre completo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRut.Text))
            {
                MessageBox.Show("Ingrese un RUT válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!long.TryParse(txtTelefono.Text, out long telefono) || telefono <= 0)
            {
                MessageBox.Show("Ingrese un número de teléfono válido (solo números)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Ingrese un correo electrónico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEmail.Clear();
            txtDomicilio.Clear();
            txtPersona.Clear();
            txtTelefono.Clear();
            txtRut.Clear();
            txtNombre.Focus();

            indiceEditando = -1;
            btnAgregar.Text = "Agregar";
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un solicitante para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            indiceEditando = dgvProductos.SelectedRows[0].Index;
            Solicitante s = listaSolicitantes[indiceEditando];

            txtNombre.Text = s.Nombre;
            txtRut.Text = s.Rut;
            txtEmail.Text = s.Email;
            txtTelefono.Text = s.Telefono.ToString();
            txtPersona.Text = s.TipoPersona;
            txtDomicilio.Text = s.Domicilio;

            btnAgregar.Text = "Guardar Cambios";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un solicitante para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar este solicitante?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int indice = dgvProductos.SelectedRows[0].Index;
                listaSolicitantes.RemoveAt(indice);

                GuardarSolicitantes();
                ActualizarGrid();
                LimpiarCampos();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            string nombre = txtNombre.Text;

            if (indiceEditando >= 0)
            {
                // MODO EDICIÓN
                listaSolicitantes[indiceEditando].Nombre = nombre;
                listaSolicitantes[indiceEditando].Rut = txtRut.Text;
                listaSolicitantes[indiceEditando].Email = txtEmail.Text;
                listaSolicitantes[indiceEditando].Telefono = long.Parse(txtTelefono.Text);
                listaSolicitantes[indiceEditando].TipoPersona = txtPersona.Text;
                listaSolicitantes[indiceEditando].Domicilio = txtDomicilio.Text;

                indiceEditando = -1;
                btnAgregar.Text = "Agregar";
                MessageBox.Show("Solicitante actualizado correctamente.");
            }
            else
            {
                // MODO AGREGAR
                foreach (Solicitante s in listaSolicitantes)
                {
                    if (s.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Este solicitante ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                Solicitante nuevo = new Solicitante(
                    nombre,
                    txtRut.Text,
                    txtEmail.Text,
                    long.Parse(txtTelefono.Text),
                    txtPersona.Text,
                    txtDomicilio.Text
                );

                listaSolicitantes.Add(nuevo);
                MessageBox.Show("Solicitante agregado correctamente.");
            }

            GuardarSolicitantes();
            ActualizarGrid();
            LimpiarCampos();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal.GUI
{
    public partial class Comandos : Form
    {
        public Comandos()
        {
            InitializeComponent();
        }

        Boolean edicionMode = false;
        private void Limpiar()
        {
            txtComando.Clear();
            txtIdComando.Clear();
        }
        BindingSource _DATOS = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.Comandos();
                dgvDatosC.AutoGenerateColumns = false;
                dgvDatosC.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        private void lblIdEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comandos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (edicionMode)
            {
                Mantenimiento.CLS.Comando c = new Mantenimiento.CLS.Comando();
                c.IdComando = int.Parse(txtIdComando.Text);
                c.Comando1 = txtComando.Text.ToString();
                if (c.Actualizar())
                {
                    MessageBox.Show("Actualizacion Exitosa");
                    Limpiar();
                    CargarDatos();
                }
                else{
                    MessageBox.Show("Actualizacion Fallida");
                }
            }
            else
            {
                Mantenimiento.CLS.Comando c = new Mantenimiento.CLS.Comando();
                c.Comando1 = txtComando.Text.ToString();

                if (c.Insertar())
                {
                    MessageBox.Show("Inserccion Exitosa");
                    CargarDatos();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Inserccion Fallida");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Mantenimiento.CLS.Comando c = new Mantenimiento.CLS.Comando();
            c.IdComando = Convert.ToInt32(dgvDatosC.CurrentRow.Cells["idComando"].Value);
            if (c.Eliminar())
            {
                MessageBox.Show("Eliminacion exitosa");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Eliminacion Fallida");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            edicionMode = true;
            txtIdComando.Text = dgvDatosC.CurrentRow.Cells["idComando"].Value.ToString() ;
            txtComando.Text = dgvDatosC.CurrentRow.Cells["comando"].Value.ToString() ;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (edicionMode)
            {
                Limpiar();
                edicionMode = false;
            }
            else
            {
                Limpiar();
            }
        }
    }
}

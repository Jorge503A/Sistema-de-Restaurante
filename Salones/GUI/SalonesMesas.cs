using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salones.GUI
{
    public partial class SalonesMesas : Form
    {
        BindingSource _DATOS = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                //_DATOS.DataSource = DataManager.DBConsultas.Comandos();
                //dgvDatosC.AutoGenerateColumns = false;
                //dgvDatosC.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public SalonesMesas()
        {
            InitializeComponent();
        }

        private void SalonesMesas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}

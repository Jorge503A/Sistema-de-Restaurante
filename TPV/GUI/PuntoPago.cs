﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV.GUI
{
    public partial class PuntoPago : Form
    {
        BindingSource datos = new BindingSource();
        public PuntoPago()
        {
            InitializeComponent();
        }

        public void CargarProductosPorMesa(String id)
        {
            try
            {
                datos.DataSource = DataManager.DBConsultas.ProductosEnMesa(id);
                dgvDatos.DataSource = datos;
                dgvDatos.AutoGenerateColumns = false;

                lblTicket.Text = dgvDatos.Rows[0].Cells["idPedido"].Value.ToString();//Accedemos a la primera posicion de la tabla

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void PuntoPago_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PuntoVenta f = new PuntoVenta();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SeleccionSalonMesa f = new SeleccionSalonMesa();
            f.ShowDialog();
            if (SeleccionSalonMesa.idMesa > 0)
            {
                CargarProductosPorMesa(SeleccionSalonMesa.idMesa.ToString());
            }
            lblMesa.Text = SeleccionSalonMesa.Mesa.ToString();
            lblMesa.Tag = SeleccionSalonMesa.idMesa.ToString();
        }
    }
}

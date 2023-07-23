﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceExpressDsk.GUI
{
    public partial class Main : Form
    {
        SessionManager.Session oUsuario = SessionManager.Session.Instancia;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Se cerrara la sesion, ¿esta seguro que desea cerrar sesion?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancelar el cierre del formulario
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //lblConexionGreen.Visible = true;
            lblUsuario.Text = "SESION DE : " + oUsuario.Usuario.ToUpper();
            //lblRol.Text = oUsuario.Rol.ToUpper();
            //timer1.Start();
        }

        private void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TPV.GUI.PuntoVenta f = new TPV.GUI.PuntoVenta();
            f.ShowDialog();
            this.Show();
        }

        private void aperturaCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TPV.GUI.ClientesGestion f = new TPV.GUI.ClientesGestion();
            f.ShowDialog();
        }

        private void puntoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TPV.GUI.PuntoVenta f = new TPV.GUI.PuntoVenta();
            f.Hide();
            TPV.GUI.ComandaGestion f2 = new TPV.GUI.ComandaGestion(f);
            f2.Hide();
            TPV.GUI.PuntoPago f3 = new TPV.GUI.PuntoPago();
            f3.ShowDialog();
            f2.ShowDialog();
            f.ShowDialog();
            this.Show();
        }

        private void ticketsProcesadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TPV.GUI.TicketsProcesados f = new TPV.GUI.TicketsProcesados();
            f.ShowDialog();
        }

        private void anularFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TPV.GUI.AnularFactura f = new TPV.GUI.AnularFactura();
            f.ShowDialog();
        }
    }
}

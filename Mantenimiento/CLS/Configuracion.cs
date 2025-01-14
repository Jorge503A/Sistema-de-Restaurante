﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimiento.CLS
{
    class Configuracion
    {
        int idConfiguracion;
        Boolean controlStock;
        Boolean incluirPropina;
        double propina;
        Boolean incluirImpuesto;
        double iva;
        double mesaVIP;
        Double autorizarDescProp;
        String printerComanda;
        String printerFactura;
        String printerInformes;
        Boolean alertaCaja;
        Boolean multisesion;
        int numSesiones;

        public int IdConfiguracion { get => idConfiguracion; set => idConfiguracion = value; }
        public bool ControlStock { get => controlStock; set => controlStock = value; }
        public bool IncluirPropina { get => incluirPropina; set => incluirPropina = value; }
        public double Propina { get => propina; set => propina = value; }
        public bool IncluirImpuesto { get => incluirImpuesto; set => incluirImpuesto = value; }
        public double Iva { get => iva; set => iva = value; }
        public double MesaVIP { get => mesaVIP; set => mesaVIP = value; }
        public double AutorizarDescProp { get => autorizarDescProp; set => autorizarDescProp = value; }
        public string PrinterComanda { get => printerComanda; set => printerComanda = value; }
        public string PrinterFactura { get => printerFactura; set => printerFactura = value; }
        public bool AlertaCaja { get => alertaCaja; set => alertaCaja = value; }
        public bool Multisesion { get => multisesion; set => multisesion = value; }
        public int NumSesiones { get => numSesiones; set => numSesiones = value; }
        public string PrinterInformes { get => printerInformes; set => printerInformes = value; }

        public Boolean Insertar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"INSERT INTO configuracion(controlStock, incluirPropina, propina, incluirImpuesto, iva, mesaVIP, autorizarDescProp, printerComanda, printerFactura, printerInformes, alertaCaja, multisesion, numSesiones) VALUES(" + controlStock + ", " + incluirPropina + ", " + propina + ", " + incluirImpuesto + ", " + iva + ", " + mesaVIP + ", " + autorizarDescProp + ", '" + printerComanda + "', '" + printerFactura + "', '" + PrinterInformes + "', " + alertaCaja + ", " + multisesion + ", " + numSesiones + ");";

            try
            {
                DataManager.DBOperacion op = new DataManager.DBOperacion();
                Int32 filasInsertadas = 0;
                filasInsertadas = op.EjecutarSentencia(sentencia);
                if (filasInsertadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public Boolean Actualizar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"UPDATE configuracion SET controlStock = " + controlStock + ", incluirPropina = " + incluirPropina + ", propina = " + propina + ", incluirImpuesto = " + incluirImpuesto + ", iva = " + iva + ", mesaVIP = " + mesaVIP + ", autorizarDescProp = " + autorizarDescProp + ", printerComanda = '" + printerComanda + "', printerFactura = '" + printerFactura + "', printerInformes = '" + printerInformes + "', alertaCaja = " + alertaCaja + ", multisesion = " + multisesion + ", numSesiones = " + numSesiones + "" +
                "WHERE idConfiguracion = " + idConfiguracion + ";";

            try
            {
                DataManager.DBOperacion op = new DataManager.DBOperacion();
                Int32 filasActualizadas = 0;
                filasActualizadas = op.EjecutarSentencia(sentencia);
                if (filasActualizadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public Boolean Eliminar()
        {
            Boolean resultado = false;
            string sentencia;
            sentencia = @"DELETE FROM configuracion " +
                "WHERE idConfiguracion = " + idConfiguracion + ";";

            try
            {
                DataManager.DBOperacion op = new DataManager.DBOperacion();
                Int32 filasEliminadas = 0;
                filasEliminadas = op.EjecutarSentencia(sentencia);
                if (filasEliminadas > 0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }
    }
}

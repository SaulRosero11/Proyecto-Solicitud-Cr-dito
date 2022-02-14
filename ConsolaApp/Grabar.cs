using System;
using ModeloDB;
using CargaDatos;
using Modelo.Entidades;
using System.Collections.Generic;

namespace ConsolaApp
{
    public class Grabar
    {
        public void DatosIni ()
        {
            DatosIniciales datos = new DatosIniciales();
            var listas = datos.Carga();

            //Extraer del diccionario las listas
            var listaSolicitante = (List<Solicitante>)listas["Solicitantes"];
            var listaAfiliado = (List<Afiliado>)listas["Afiliados"];
            var listaRolPagos = (List<RolPagos>)listas["RolPagos"];
            var listDeclaracionImps = (List<DeclaracionImp>)listas["DeclaracionImps"];
            var listaGastos = (List<Gastos>)listas["Gastos"];
            var listaCapcidadPago = (List<CapacidadPago>)listas["CapacidadPagos"];
            var listaBienesSolicitante = (List<BienesSolicitante>)listas["BienesSolicitantes"];
            var listaDetalleDeudas = (List<DetalleDeudas>)listas["DetalleDeudas"];
            var listaHistorialCrediticio = (List<HistorialCrediticio>)listas["HistorialCrediticios"];
            var listaBienAdquirir = (List<BienAdquirir>)listas["BienAdquirir"];
            var listaSolicitud = (List<Solicitud>)listas["Solicitud"];
            var listaAmortizacion = (List<Amortizacion>)listas["Amortizacion"];
            var listaSolic_Det = (List<Solicitud_Det>)listas["Solicitud_Det"];
            var listConfiguracion = (List<Configuracion>)listas["Configuracion"];

            using (DBCreditos repos = CreditosDBBuilder.Crear())
            {
                //Se asegura que se borre y vuelva a crear la base de datos
                repos.PreparaDB();
                //Agrega los listados
                repos.Solicitantes.AddRange(listaSolicitante);
                repos.Afiliado.AddRange(listaAfiliado);
                repos.RolPagos.AddRange(listaRolPagos);
                repos.DeclaracionImps.AddRange(listDeclaracionImps);
                repos.Gastos.AddRange(listaGastos);
                repos.CapacidadPagos.AddRange(listaCapcidadPago);
                repos.BienesSolicitante.AddRange(listaBienesSolicitante);
                repos.DetalleDeudas.AddRange(listaDetalleDeudas);
                repos.HistorialCrediticios.AddRange(listaHistorialCrediticio);
                repos.BienAdquirirs.AddRange(listaBienAdquirir);
                repos.Solicitud.AddRange(listaSolicitud);
                repos.Amortizacion.AddRange(listaAmortizacion);
                repos.Solicitud_Dets.AddRange(listaSolic_Det);
                repos.Configuracions.AddRange(listConfiguracion);
                //Guarda todos los datos
                repos.SaveChanges();
            }
        }
    }
}

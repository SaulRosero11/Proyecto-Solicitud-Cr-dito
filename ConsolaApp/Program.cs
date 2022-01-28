using System;
using ModeloDB;
using CargaDatos;
using Modelo.Entidades;
using System.Collections.Generic;

namespace ConsolaApp
{
    class Program
    {
        static void Main(string[] args)
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

            using (DBCreditos repos = new DBCreditos())
            {
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
                repos.SaveChanges();
            }
        }
    }
}

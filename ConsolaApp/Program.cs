using System;
using ModeloDB;
using Modelo.Entidades;
using System.Collections.Generic;

namespace ConsolaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HistorialCrediticio Dato = new HistorialCrediticio()
            {
                BienesSolicitante = new BienesSolicitante(),
                DeudasBienes = 5000,
                DetalleDeudas = new DetalleDeudas(),
                DeudasDet = 400,
                CentralRiesgos = false,
                PagosPendientes = false,
                EstadoHistorial = true,
                Solicituds = new List<Solicitud>() { new Solicitud() { } }
            };

            using (DBCreditos repos = new DBCreditos())
            {
                repos.HistorialCrediticios.AddRange(Dato);
                repos.SaveChanges();
            }
        }
    }
}

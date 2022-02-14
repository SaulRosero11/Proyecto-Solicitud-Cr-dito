using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Operaciones
{
    public class Calculo
    {
        public float Sueldo { get; set; }
        public float porcentaje { get; set; }

        public Calculo(Configuracion configuracion, CapacidadPago capacidadPago)
        {
            this.porcentaje = configuracion.PorcentajeSueldo;
            this.Sueldo = capacidadPago.CapcidadPago;
        }

        public float CapacidadPago(Solicitud solicitud)
        {
            float respuesta;

            respuesta = Sueldo * porcentaje;

            respuesta = (float)Math.Round((double)respuesta, 2);

            return respuesta;
        }

        public bool Aprobado(Solicitud solicitud)
        {
            return CapacidadPago(solicitud) >= solicitud.TotalCuota;
        }

    }
}

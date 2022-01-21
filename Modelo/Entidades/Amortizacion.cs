using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Amortizacion
    {
        //Camps de amortizacion
        public float ValorCredito { get; set; }
        public float TotalInteres { get; set; }
        public float TotalCuota { get; set; }

        //Se valida que cumpla con los documentos y las reglas
        public string EstadoCredito { get; set; }

        //Relacion solicitud
        public int SolicitudId { get; set; }
        public Solicitud Solicitud { get; set; }
    }
}

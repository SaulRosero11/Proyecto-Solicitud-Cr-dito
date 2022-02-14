using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Solicitud_Det
    {
        public int Solicitud_DetId { get; set; }
        //Relacion solicitud
        public Solicitud Solicitud { get; set; }
        public int solicitudId { get; set; }
        //Relacion Amortizacion
        public Amortizacion Amortizacion { get; set; }
        public int amortizacionId { get; set; } 

    }
}

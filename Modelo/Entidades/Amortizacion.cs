using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum Estado { Pendiente, Aprobada, Rechazada, Anulada }
    public class Amortizacion
    {
        //Camps de amortizacion
        public int AmortizacionId { get; set; }
        public float ValorCredito { get; set; }
        public float PagoMensual { get; set; }
        public Estado Estado { get; set; }
             
        //Relacion solicitud
        public List<Solicitud_Det> Solicitud_Dets { get; set; }
    }
}

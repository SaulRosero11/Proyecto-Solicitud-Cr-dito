using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Solicitud
    {
        //Campos solicitud
        public int SolicitudId { get; set; }
        public string TipoCredito { get; set; }
        public string DiscapacidadDesc { get; set; }
        public float TNA { get; set; }
        public int TiempoCredtio { get; set; }
        public float TotalCredito { get; set; }
        public int NumeroPagos { get; set; }
        public float CuotaDesgrav { get; set; }
        public float CuatoSeguro { get; set; }
        public float CuotaMensual { get; set; }
        public float TotalCuota { get; set; }

        //Relacion con el afiliado 
        public Afiliado Afiliado { get; set; }

        //Relacion con el Capcidad Pago 
        public CapacidadPago CapacidadPago { get; set; }

        //Relacion con el Historial Crediticio 
        public HistorialCrediticio HistorialCrediticio { get; set; }

        //Relacion con el Bien Adquirir
        public BienAdquirir BienAdquirir { get; set; }

        //Relacion Amortizacion
        public ICollection<Amortizacion> Amortizacions { get; set; }

    }
}

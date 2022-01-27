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
        public Boolean DiscapacidadDesc { get; set; }
        public string TNA { get; set; }
        public int TiempoCredito { get; set; }
        public float TotalCredito { get; set; }
        public int NumeroPagos { get; set; }
        public float CuotaDesgrav { get; set; }
        public float CuatoSeguro { get; set; }
        public float CuotaMensual { get; set; }
        public float TotalCuota { get; set; }

        //Relacion con el afiliado 
        public int AfiliadoId { get; set; }
        public Afiliado Afiliado { get; set; }

        //Relacion con el Capcidad Pago 
        public int CapacidadPagoId { get; set; }
        public CapacidadPago CapacidadPago { get; set; }

        //Relacion con el Historial Crediticio
        public int HistorialCrediticioId { get; set; }
        public HistorialCrediticio HistorialCrediticio { get; set; }

        //Relacion con el Bien Adquirir
        public int BienAdquirirId { get; set; }
        public BienAdquirir BienAdquirir { get; set; }

    }
}

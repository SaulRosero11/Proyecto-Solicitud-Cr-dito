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

        //Relacion con amortizacion
        public List<Solicitud_Det> Solicitud_Dets { get; set; }

        //Porcentaje de sueldo
        public float Porcentaje(float PorcentajeSueldo, float CapcidadPago)
        {
            // Cálculo
            float suma = 0;

            suma = PorcentajeSueldo * CapcidadPago;
            suma = MathF.Round(suma, 2);
            return suma;
        }

        //Se valida que cumpla con los documentos y las reglas
        public bool EstadoCredi(float PorcentajeSueldo, float CapcidadPago)
        {
            bool res;
            res = Porcentaje(PorcentajeSueldo, CapcidadPago) >= TotalCuota;
            return res;

        }
    }
}

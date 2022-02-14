using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum Targetas { Si,No}
    public enum CreditosLineaBlanca { Si,No}
    public class DetalleDeudas
    {
        //Campos de detalle deudas
        public int DetalleDeudasId { get; set; }
        public Targetas TragetasCredito { get; set; }
        public float PagoPendienteTargetas { get; set; }
        public CreditosLineaBlanca CreditosLineaBlanca { get; set; }
        public float PagoPendienteCreditos { get; set; }

        //Calculo de total de deudas por pagar
        public float TotalPendienteDeudas { get; set; }

        //Relacion con Solicitante 
        public int SolicitanteId { get; set; }
        public Solicitante Solicitante { get; set; }

        //Relacion con Historial Crediticio
        public List<HistorialCrediticio> HistorialCrediticios { get; set; }
    }
}

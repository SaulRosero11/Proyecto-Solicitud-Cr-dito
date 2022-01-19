using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class HistorialCrediticio
    {
        //Campos historial crediticio
        public int HistorialCrediticioId { get; set; }

        //Relacion con Bienes Solicitante
        public BienesSolicitante bienesSolicitante { get; set; }
        public float DeudasBienes { get; set; }

        //Relacion con Detalle Deudas
        public DetalleDeudas detalleDeudas { get; set; }
        public float DeudasDet { get; set; }

        //Campos historial crediticio
        public bool CentralRiesgos { get; set; }
        public bool PagosPendientes { get; set; }

        //campos estado de historial segun sus deudas
        public bool EstadoHistorial { get; set; }

        //Relacion Soliticitud
        public ICollection<Solicitud> Solicituds { get; set; }
    }
}

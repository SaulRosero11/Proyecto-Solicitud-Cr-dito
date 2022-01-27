using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class DeclaracionImp
    {
        //Campos declaracion impuestos
        public int DeclaracionImpId { get; set; }
        public float VentasAnuales { get; set; }
        public float AporteIESS { get; set; }
        public float PrestamosIESS { get; set; }
        public float GastosVarios { get; set; }

        //Calculo de total de ingresos 
        public float TotalIngresos { get; set; }

        //Relacion con Solicitante
        public int SolicitanteId { get; set; }
        public Solicitante Solicitante { get; set; }

        //Relacion Capacidad Pago
        public ICollection<CapacidadPago> capacidadPagos { get; set; }
    }
}

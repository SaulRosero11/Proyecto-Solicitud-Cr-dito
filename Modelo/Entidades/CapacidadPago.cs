using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class CapacidadPago
    {
        //Campos capacidad pago
        public int CapacidadPagoId { get; set; }
        //Relacion con Declaracion
        public DeclaracionImp DeclaracionImp { get; set; }
        public float Declaracion { get; set; }

        //Relacion con RolPagos  
        public RolPagos RolPagos { get; set; }
        public float RolPagosTotal { get; set; }

        //Relacion con Gastos
        public Gastos Gastos { get; set; }
        public float GastosTotal { get; set; }

        //Resultado de la capacidad del pago
        public float CapcidadPago { get; set; }

        //Relacion Soliticitud
        public ICollection<Solicitud> Solicituds { get; set; }
    }
}

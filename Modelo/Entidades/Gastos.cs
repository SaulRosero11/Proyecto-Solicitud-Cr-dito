using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Gastos
    {
        //Campos detalle bien
        public int GastosId { get; set; }
        public float Arriendo { get; set; }
        public float ServiciosBasicos { get; set; }
        public float Comida { get; set; }
        public float Transporte { get; set; }
        public float Educacion { get; set; }
        public float GastosVarios { get; set; }

        //Calculo de Gatos totales
        public float TotalGastos { get; set; }

        //Relacion con Solicitante 
        public Solicitante Solicitante { get; set; }
        
        //Relacion Capacidad Pago
        public ICollection<CapacidadPago> capacidadPagos { get; set; }
    }
}

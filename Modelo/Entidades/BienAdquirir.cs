using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class BienAdquirir
    {
        //Campos detalle bien
        public int BienAdquirirId { get; set; }
        public string Propietario { get; set; }
        public float Avaluo { get; set; }
        public bool PagoIMP { get; set; }
        public bool Hipoteca { get; set; }
        public bool Escrituras { get; set; }
        public bool EstadoBien { get; set; }

        //Relacion Soliticitud
        public ICollection<Solicitud> Solicitud { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum PagoImp { Si, No}
    public enum Hipoteca { Si,No}
    public enum Escrituras { Si,No}
    public enum EstadoBien { Aprovado, Reporbado}
    public class BienAdquirir
    {
        //Campos detalle bien
        public int BienAdquirirId { get; set; }
        public string TipoVivienda { get; set; }
        public string Propietario { get; set; }
        public float Avaluo { get; set; }
        public PagoImp PagoIMP { get; set; }
        public Hipoteca Hipoteca { get; set; }
        public Escrituras Escrituras { get; set; }
        public EstadoBien EstadoBien { get; set; }

        //Relacion Soliticitud
        public List<Solicitud> Solicitud { get; set; }
    }
}

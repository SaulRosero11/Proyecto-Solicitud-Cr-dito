using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Afiliado
    {
        //Campos de la calse Solicitante
        public int AfiliadoId { get; set; }
        public string TipoAfiliado { get; set; }
        public string RucEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public DateTime PeriodoDesde { get; set; }
        public DateTime PeriodoHasta { get; set; }
        public int TotalAportaciones { get; set; }

        //Relacion con Solicitante 
        public int SolicitanteId { get; set; }
        public Solicitante Solicitante { get; set; }

        //Relacion Soliticitud
        public ICollection<Solicitud> Solicituds { get; set; }
    }
}

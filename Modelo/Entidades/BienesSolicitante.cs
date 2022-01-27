using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class BienesSolicitante
    {
        //Campos bienes solicitante
        public int BienesSolicitanteId { get; set; }
        public Boolean Automovil { get; set; }
        public float PagoPendienteAutomovil { get; set; }
        public Boolean Casa { get; set; }
        public float PagoPendienteCasa { get; set; }
        public Boolean Terreno { get; set; }
        public float PagoPendienteTerreno { get; set; }
        public float TotalPendienteBienes { get; set; }

        //Relacion con Solicitante 
        public int SolicitanteId { get; set; }
        public Solicitante Solicitante { get; set; }

        //Relacion con Historial Crediticio
        public ICollection<HistorialCrediticio> HistorialCrediticios { get; set; }
    }
}

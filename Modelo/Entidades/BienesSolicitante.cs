using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum Casa { Si,No}
    public enum Automovil { Si,No}
    public enum Terreno { Si,No}
    public class BienesSolicitante
    {
        //Campos bienes solicitante
        public int BienesSolicitanteId { get; set; }
        public Automovil Automovil { get; set; }
        public float PagoPendienteAutomovil { get; set; }
        public Casa Casa { get; set; }
        public float PagoPendienteCasa { get; set; }
        public Terreno Terreno { get; set; }
        public float PagoPendienteTerreno { get; set; }
        public float TotalPendienteBienes { get; set; }

        //Relacion con Solicitante 
        public int SolicitanteId { get; set; }
        public Solicitante Solicitante { get; set; }

        //Relacion con Historial Crediticio
        public List<HistorialCrediticio> HistorialCrediticios { get; set; }
    }
}

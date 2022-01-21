using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Solicitante
    {
        //Campos de la calse Solicitante
        public int SolicitanteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime FechaNac { get; set; }
        public bool Discapacidad { get; set; }

        //Relacion con afiliado
        public Afiliado Afiliado { get; set; }
        //Relacion con rol pagos
        public ICollection<RolPagos> RolPagos { get; set; }
        //Relacion con declaracion
        public ICollection<DeclaracionImp> DeclaracionImps { get; set; }
        //Relacion con gastos
        public ICollection<Gastos> Gastos { get; set; }
        //Relacion con deudas
        public ICollection<DetalleDeudas> DetalleDeudas { get; set; }
        //Relacion con Bienes Solicitante
        public ICollection<BienesSolicitante> BienesSolicitantes { get; set; }
    }
}

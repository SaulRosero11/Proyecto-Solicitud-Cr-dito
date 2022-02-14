using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum EstadoCivil { Casado, Soltero, Viudo}
    public class Solicitante
    {
        //Campos de la calse Solicitante
        public int SolicitanteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaNac { get; set; }
        public bool Discapacidad { get; set; }

        //Relacion con afiliado
        public Afiliado Afiliado { get; set; }
        //Relacion con rol pagos
        public List<RolPagos> RolPagos { get; set; }
        //Relacion con declaracion
        public List<DeclaracionImp> DeclaracionImps { get; set; }
        //Relacion con gastos
        public List<Gastos> Gastos { get; set; }
        //Relacion con deudas
        public List<DetalleDeudas> DetalleDeudas { get; set; }
        //Relacion con Bienes Solicitante
        public List<BienesSolicitante> BienesSolicitantes { get; set; }
    }
}

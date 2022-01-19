using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace ModeloDB
{
    public class DBCreditos : DbContext
    {
        //Entidades
        public DbSet<Solicitante> Solicitantes { get; set; }
        public DbSet<Afiliado> Afiliado { get; set; }
        public DbSet<RolPagos> RolPagos { get; set; }
        public DbSet<DeclaracionImp> DeclaracionImps { get; set; }
        public DbSet<Gastos> Gastos { get; set; }
        public DbSet<CapacidadPago> CapacidadPagos { get; set; }
        public DbSet<BienesSolicitante> BienesSolicitante { get; set; }
        public DbSet<DetalleDeudas> DetalleDeudas { get; set; }
        public DbSet<HistorialCrediticio> HistorialCrediticios { get; set; }
        public DbSet<BienAdquirir> BienAdquirirs { get; set; }
        public DbSet<Solicitud> Solicitud { get; set; }
        public DbSet<Amortizacion> Amortizacion { get; set; }

        //Conexion a la base de datos
        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            String conSQLServer = "server = Tony; initial catalog = DBCreditos; trusted_connection = true;";

            /*
            String conNpgsql = "Host = localhost; " +
                               "Port = 5432; " +
                               "Database = DBUniversidad; " +
                               "Username = postgres; " +
                               "Password = 1234; ";

            */

            //Conexión a SQL-Server 
            options.UseSqlServer(conSQLServer);

            //Conxión a PGSQL
            //options.UseNpgsql(conNpgsql);
        }
    }
}

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

        //Configurar el modelo de objetos
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            //Llamar a tabla sin id
            model.Entity<ClaseSin>()
                .HasNoKey();
            //Relacion
            model.Entity<ClaseSin>()
                .HasOnce(sin => sin.relacion
                .WhitMany()
                .HasForeignKey(sin => sin.relacionId);

            //LLamar tabla Muchos a muchos X2
            model.Entity<ClaseEntre>()
                .HashOne(entre => entre.Clase1)
                .WithMany(clase => clase.entre)
                .HasForeignKey(entre => entre.claseId);
            //Configuracion de la tabla
            model.Entity<ClaseEntre>()
                .HasOne(entre => new (
                    entre.clase1Id,
                    entre.clase2Id);
            */


            //Relacion cardinalida de solicitante afiliado 1-1
            modelBuilder.Entity<Solicitante>()
                .HasOne(solicitante => solicitante.Afiliado)
                .WithOne(afiliado => afiliado.Solicitante)
                .HasForeignKey<Afiliado>(afiliado => afiliado.SolicitanteId);

            //Relacion cardianlidad de solicitante BienesSolicitante 1-m
            modelBuilder.Entity<BienesSolicitante>()
                .HasOne(bienesSolicitante => bienesSolicitante.Solicitante)
                .WithMany(solicitante => solicitante.BienesSolicitantes)
                .HasForeignKey(bienesSolicitante => bienesSolicitante.SolicitanteId);

            //Relacion cardianlidad de solicitante DeclaraiconImps 1-m
            modelBuilder.Entity<DeclaracionImp>()
                .HasOne(declaracionImps => declaracionImps.Solicitante)
                .WithMany(solicitante => solicitante.DeclaracionImps)
                .HasForeignKey(declaracionImps => declaracionImps.SolicitanteId);

            //Relacion cardianlidad de solicitante DetaleDeudas 1-m
            modelBuilder.Entity<DetalleDeudas>()
                .HasOne(deudas => deudas.Solicitante)
                .WithMany(solicitante => solicitante.DetalleDeudas)
                .HasForeignKey(deudas => deudas.SolicitanteId);

            //Relacion cardianlidad de solicitante Gastos 1-m
            modelBuilder.Entity<Gastos>()
                .HasOne(gastos => gastos.Solicitante)
                .WithMany(solicitante => solicitante.Gastos)
                .HasForeignKey(gastos => gastos.SolicitanteId);

            //Relacion cardianlidad de solicitante RolPagos 1-m
            modelBuilder.Entity<RolPagos>()
                .HasOne(rolPagos => rolPagos.Solicitante)
                .WithMany(solicitante => solicitante.RolPagos)
                .HasForeignKey(rolPagos => rolPagos.SolicitanteId);

            //relaciones HistorialCrediticio
            //Relacion BienesSOlcitante 1-m
            modelBuilder.Entity<HistorialCrediticio>()
                .HasOne(historial => historial.BienesSolicitante)
                .WithMany(bienes => bienes.HistorialCrediticios)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(histo => histo.BienesSolicitanteId);

            //Relacion Detalles Deudas 1-m
            modelBuilder.Entity<HistorialCrediticio>()
                .HasOne(historial => historial.DetalleDeudas)
                .WithMany(detalle => detalle.HistorialCrediticios)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(histo => histo.DetalleDeudasId);

            //relaciones Capcidad Pago
            //Relacion RolPagos 1-m
            modelBuilder.Entity<CapacidadPago>()
                .HasOne(capacidad => capacidad.RolPagos)
                .WithMany(rol => rol.capacidadPagos)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(capacidad => capacidad.RolPagosId);

            //Relacion RolPagos 1-m
            modelBuilder.Entity<CapacidadPago>()
                .HasOne(capacidad => capacidad.DeclaracionImp)
                .WithMany(declaracion => declaracion.capacidadPagos)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(capacidad => capacidad.DeclaracionImpId);

            //Relacion RolPagos 1-m
            modelBuilder.Entity<CapacidadPago>()
                .HasOne(capacidad => capacidad.Gastos)
                .WithMany(gastos => gastos.capacidadPagos)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(capacidad => capacidad.GastosId);

            //Relaicones Solicitud
            //Relacion cardianlidad de Afiliado con Solcitud 1-m
            modelBuilder.Entity<Solicitud>()
                .HasOne(solicitud => solicitud.Afiliado)
                .WithMany(Afiliado => Afiliado.Solicituds)
                .HasForeignKey(solicitud => solicitud.AfiliadoId);

            //Relacion cardianlidad de Afiliado con Solcitud de 1-m
            modelBuilder.Entity<Solicitud>()
                .HasOne(solicitud => solicitud.CapacidadPago)
                .WithMany(capacidadPago => capacidadPago.Solicituds)
                .HasForeignKey(solicitud => solicitud.CapacidadPagoId);

            //Relacion cardianlidad de Afiliado con Solcitud de 1-m
            modelBuilder.Entity<Solicitud>()
                .HasOne(solicitud => solicitud.HistorialCrediticio)
                .WithMany(historial => historial.Solicituds)
                .HasForeignKey(solicitud => solicitud.HistorialCrediticioId);

            //Relacion cardianlidad de Afiliado con Solcitud 1 m
            modelBuilder.Entity<Solicitud>()
                .HasOne(solicitud => solicitud.BienAdquirir)
                .WithMany(bien => bien.Solicitud)
                .HasForeignKey(solicitud => solicitud.BienAdquirirId);

            //Relacion cardianlidad de Afiliado con Solcitud 1-m
            modelBuilder.Entity<Amortizacion>()
                .HasNoKey();

            modelBuilder.Entity<Amortizacion>()
                .HasOne(amor => amor.Solicitud)
                .WithMany()
                .HasForeignKey(amortizacion => amortizacion.SolicitudId);

        }
        

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

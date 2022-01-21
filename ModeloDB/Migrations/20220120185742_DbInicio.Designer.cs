﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloDB;

namespace ModeloDB.Migrations
{
    [DbContext(typeof(DBCreditos))]
    [Migration("20220120185742_DbInicio")]
    partial class DbInicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.Entidades.Afiliado", b =>
                {
                    b.Property<int>("AfiliadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PeriodoDesde")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PeriodoHasta")
                        .HasColumnType("datetime2");

                    b.Property<string>("RucEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SolicitanteId")
                        .HasColumnType("int");

                    b.Property<string>("TipoAfiliado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalAportaciones")
                        .HasColumnType("int");

                    b.HasKey("AfiliadoId");

                    b.HasIndex("SolicitanteId")
                        .IsUnique();

                    b.ToTable("Afiliado");
                });

            modelBuilder.Entity("Modelo.Entidades.Amortizacion", b =>
                {
                    b.Property<string>("EstadoCredito")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SolicitudId")
                        .HasColumnType("int");

                    b.Property<float>("TotalCuota")
                        .HasColumnType("real");

                    b.Property<float>("TotalInteres")
                        .HasColumnType("real");

                    b.Property<float>("ValorCredito")
                        .HasColumnType("real");

                    b.HasIndex("SolicitudId");

                    b.ToTable("Amortizacion");
                });

            modelBuilder.Entity("Modelo.Entidades.BienAdquirir", b =>
                {
                    b.Property<int>("BienAdquirirId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Avaluo")
                        .HasColumnType("real");

                    b.Property<bool>("Escrituras")
                        .HasColumnType("bit");

                    b.Property<bool>("EstadoBien")
                        .HasColumnType("bit");

                    b.Property<bool>("Hipoteca")
                        .HasColumnType("bit");

                    b.Property<bool>("PagoIMP")
                        .HasColumnType("bit");

                    b.Property<string>("Propietario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BienAdquirirId");

                    b.ToTable("BienAdquirirs");
                });

            modelBuilder.Entity("Modelo.Entidades.BienesSolicitante", b =>
                {
                    b.Property<int>("BienesSolicitanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Automovil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Casa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PagoPendienteAutomovil")
                        .HasColumnType("real");

                    b.Property<float>("PagoPendienteCasa")
                        .HasColumnType("real");

                    b.Property<float>("PagoPendienteTerreno")
                        .HasColumnType("real");

                    b.Property<int>("SolicitanteId")
                        .HasColumnType("int");

                    b.Property<string>("Terreno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalPendienteBienes")
                        .HasColumnType("real");

                    b.HasKey("BienesSolicitanteId");

                    b.HasIndex("SolicitanteId");

                    b.ToTable("BienesSolicitante");
                });

            modelBuilder.Entity("Modelo.Entidades.CapacidadPago", b =>
                {
                    b.Property<int>("CapacidadPagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CapcidadPago")
                        .HasColumnType("real");

                    b.Property<float>("Declaracion")
                        .HasColumnType("real");

                    b.Property<int>("DeclaracionImpId")
                        .HasColumnType("int");

                    b.Property<int>("GastosId")
                        .HasColumnType("int");

                    b.Property<float>("GastosTotal")
                        .HasColumnType("real");

                    b.Property<int>("RolPagosId")
                        .HasColumnType("int");

                    b.Property<float>("RolPagosTotal")
                        .HasColumnType("real");

                    b.HasKey("CapacidadPagoId");

                    b.HasIndex("DeclaracionImpId");

                    b.HasIndex("GastosId");

                    b.HasIndex("RolPagosId");

                    b.ToTable("CapacidadPagos");
                });

            modelBuilder.Entity("Modelo.Entidades.DeclaracionImp", b =>
                {
                    b.Property<int>("DeclaracionImpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AporteIESS")
                        .HasColumnType("real");

                    b.Property<float>("GastosVarios")
                        .HasColumnType("real");

                    b.Property<float>("PrestamosIESS")
                        .HasColumnType("real");

                    b.Property<int>("SolicitanteId")
                        .HasColumnType("int");

                    b.Property<float>("TotalIngresos")
                        .HasColumnType("real");

                    b.Property<float>("VentasAnuales")
                        .HasColumnType("real");

                    b.HasKey("DeclaracionImpId");

                    b.HasIndex("SolicitanteId");

                    b.ToTable("DeclaracionImps");
                });

            modelBuilder.Entity("Modelo.Entidades.DetalleDeudas", b =>
                {
                    b.Property<int>("DetalleDeudasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreditosLineaBlanca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PagoPendienteCreditos")
                        .HasColumnType("real");

                    b.Property<float>("PagoPendienteTargetas")
                        .HasColumnType("real");

                    b.Property<int>("SolicitanteId")
                        .HasColumnType("int");

                    b.Property<float>("TotalPendienteDeudas")
                        .HasColumnType("real");

                    b.Property<string>("TragetasCredito")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetalleDeudasId");

                    b.HasIndex("SolicitanteId");

                    b.ToTable("DetalleDeudas");
                });

            modelBuilder.Entity("Modelo.Entidades.Gastos", b =>
                {
                    b.Property<int>("GastosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Arriendo")
                        .HasColumnType("real");

                    b.Property<float>("Comida")
                        .HasColumnType("real");

                    b.Property<float>("Educacion")
                        .HasColumnType("real");

                    b.Property<float>("GastosVarios")
                        .HasColumnType("real");

                    b.Property<float>("ServiciosBasicos")
                        .HasColumnType("real");

                    b.Property<int>("SolicitanteId")
                        .HasColumnType("int");

                    b.Property<float>("TotalGastos")
                        .HasColumnType("real");

                    b.Property<float>("Transporte")
                        .HasColumnType("real");

                    b.HasKey("GastosId");

                    b.HasIndex("SolicitanteId");

                    b.ToTable("Gastos");
                });

            modelBuilder.Entity("Modelo.Entidades.HistorialCrediticio", b =>
                {
                    b.Property<int>("HistorialCrediticioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BienesSolicitanteId")
                        .HasColumnType("int");

                    b.Property<bool>("CentralRiesgos")
                        .HasColumnType("bit");

                    b.Property<int>("DetalleDeudasId")
                        .HasColumnType("int");

                    b.Property<float>("DeudasBienes")
                        .HasColumnType("real");

                    b.Property<float>("DeudasDet")
                        .HasColumnType("real");

                    b.Property<bool>("EstadoHistorial")
                        .HasColumnType("bit");

                    b.Property<bool>("PagosPendientes")
                        .HasColumnType("bit");

                    b.HasKey("HistorialCrediticioId");

                    b.HasIndex("BienesSolicitanteId");

                    b.HasIndex("DetalleDeudasId");

                    b.ToTable("HistorialCrediticios");
                });

            modelBuilder.Entity("Modelo.Entidades.RolPagos", b =>
                {
                    b.Property<int>("RolPagosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Anticipo")
                        .HasColumnType("real");

                    b.Property<float>("AporteIESS")
                        .HasColumnType("real");

                    b.Property<float>("PrestamosIESS")
                        .HasColumnType("real");

                    b.Property<int>("SolicitanteId")
                        .HasColumnType("int");

                    b.Property<float>("Sueldo")
                        .HasColumnType("real");

                    b.Property<float>("TotalIngresos")
                        .HasColumnType("real");

                    b.HasKey("RolPagosId");

                    b.HasIndex("SolicitanteId");

                    b.ToTable("RolPagos");
                });

            modelBuilder.Entity("Modelo.Entidades.Solicitante", b =>
                {
                    b.Property<int>("SolicitanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Discapacidad")
                        .HasColumnType("bit");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SolicitanteId");

                    b.ToTable("Solicitantes");
                });

            modelBuilder.Entity("Modelo.Entidades.Solicitud", b =>
                {
                    b.Property<int>("SolicitudId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AfiliadoId")
                        .HasColumnType("int");

                    b.Property<int>("BienAdquirirId")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadPagoId")
                        .HasColumnType("int");

                    b.Property<float>("CuatoSeguro")
                        .HasColumnType("real");

                    b.Property<float>("CuotaDesgrav")
                        .HasColumnType("real");

                    b.Property<float>("CuotaMensual")
                        .HasColumnType("real");

                    b.Property<string>("DiscapacidadDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HistorialCrediticioId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroPagos")
                        .HasColumnType("int");

                    b.Property<float>("TNA")
                        .HasColumnType("real");

                    b.Property<int>("TiempoCredtio")
                        .HasColumnType("int");

                    b.Property<string>("TipoCredito")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalCredito")
                        .HasColumnType("real");

                    b.Property<float>("TotalCuota")
                        .HasColumnType("real");

                    b.HasKey("SolicitudId");

                    b.HasIndex("AfiliadoId");

                    b.HasIndex("BienAdquirirId");

                    b.HasIndex("CapacidadPagoId");

                    b.HasIndex("HistorialCrediticioId");

                    b.ToTable("Solicitud");
                });

            modelBuilder.Entity("Modelo.Entidades.Afiliado", b =>
                {
                    b.HasOne("Modelo.Entidades.Solicitante", "Solicitante")
                        .WithOne("Afiliado")
                        .HasForeignKey("Modelo.Entidades.Afiliado", "SolicitanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Solicitante");
                });

            modelBuilder.Entity("Modelo.Entidades.Amortizacion", b =>
                {
                    b.HasOne("Modelo.Entidades.Solicitud", "Solicitud")
                        .WithMany()
                        .HasForeignKey("SolicitudId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Solicitud");
                });

            modelBuilder.Entity("Modelo.Entidades.BienesSolicitante", b =>
                {
                    b.HasOne("Modelo.Entidades.Solicitante", "Solicitante")
                        .WithMany("BienesSolicitantes")
                        .HasForeignKey("SolicitanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Solicitante");
                });

            modelBuilder.Entity("Modelo.Entidades.CapacidadPago", b =>
                {
                    b.HasOne("Modelo.Entidades.DeclaracionImp", "DeclaracionImp")
                        .WithMany("capacidadPagos")
                        .HasForeignKey("DeclaracionImpId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Gastos", "Gastos")
                        .WithMany("capacidadPagos")
                        .HasForeignKey("GastosId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.RolPagos", "RolPagos")
                        .WithMany("capacidadPagos")
                        .HasForeignKey("RolPagosId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DeclaracionImp");

                    b.Navigation("Gastos");

                    b.Navigation("RolPagos");
                });

            modelBuilder.Entity("Modelo.Entidades.DeclaracionImp", b =>
                {
                    b.HasOne("Modelo.Entidades.Solicitante", "Solicitante")
                        .WithMany("DeclaracionImps")
                        .HasForeignKey("SolicitanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Solicitante");
                });

            modelBuilder.Entity("Modelo.Entidades.DetalleDeudas", b =>
                {
                    b.HasOne("Modelo.Entidades.Solicitante", "Solicitante")
                        .WithMany("DetalleDeudas")
                        .HasForeignKey("SolicitanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Solicitante");
                });

            modelBuilder.Entity("Modelo.Entidades.Gastos", b =>
                {
                    b.HasOne("Modelo.Entidades.Solicitante", "Solicitante")
                        .WithMany("Gastos")
                        .HasForeignKey("SolicitanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Solicitante");
                });

            modelBuilder.Entity("Modelo.Entidades.HistorialCrediticio", b =>
                {
                    b.HasOne("Modelo.Entidades.BienesSolicitante", "BienesSolicitante")
                        .WithMany("HistorialCrediticios")
                        .HasForeignKey("BienesSolicitanteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.DetalleDeudas", "DetalleDeudas")
                        .WithMany("HistorialCrediticios")
                        .HasForeignKey("DetalleDeudasId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BienesSolicitante");

                    b.Navigation("DetalleDeudas");
                });

            modelBuilder.Entity("Modelo.Entidades.RolPagos", b =>
                {
                    b.HasOne("Modelo.Entidades.Solicitante", "Solicitante")
                        .WithMany("RolPagos")
                        .HasForeignKey("SolicitanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Solicitante");
                });

            modelBuilder.Entity("Modelo.Entidades.Solicitud", b =>
                {
                    b.HasOne("Modelo.Entidades.Afiliado", "Afiliado")
                        .WithMany("Solicituds")
                        .HasForeignKey("AfiliadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.BienAdquirir", "BienAdquirir")
                        .WithMany("Solicitud")
                        .HasForeignKey("BienAdquirirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.CapacidadPago", "CapacidadPago")
                        .WithMany("Solicituds")
                        .HasForeignKey("CapacidadPagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.HistorialCrediticio", "HistorialCrediticio")
                        .WithMany("Solicituds")
                        .HasForeignKey("HistorialCrediticioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Afiliado");

                    b.Navigation("BienAdquirir");

                    b.Navigation("CapacidadPago");

                    b.Navigation("HistorialCrediticio");
                });

            modelBuilder.Entity("Modelo.Entidades.Afiliado", b =>
                {
                    b.Navigation("Solicituds");
                });

            modelBuilder.Entity("Modelo.Entidades.BienAdquirir", b =>
                {
                    b.Navigation("Solicitud");
                });

            modelBuilder.Entity("Modelo.Entidades.BienesSolicitante", b =>
                {
                    b.Navigation("HistorialCrediticios");
                });

            modelBuilder.Entity("Modelo.Entidades.CapacidadPago", b =>
                {
                    b.Navigation("Solicituds");
                });

            modelBuilder.Entity("Modelo.Entidades.DeclaracionImp", b =>
                {
                    b.Navigation("capacidadPagos");
                });

            modelBuilder.Entity("Modelo.Entidades.DetalleDeudas", b =>
                {
                    b.Navigation("HistorialCrediticios");
                });

            modelBuilder.Entity("Modelo.Entidades.Gastos", b =>
                {
                    b.Navigation("capacidadPagos");
                });

            modelBuilder.Entity("Modelo.Entidades.HistorialCrediticio", b =>
                {
                    b.Navigation("Solicituds");
                });

            modelBuilder.Entity("Modelo.Entidades.RolPagos", b =>
                {
                    b.Navigation("capacidadPagos");
                });

            modelBuilder.Entity("Modelo.Entidades.Solicitante", b =>
                {
                    b.Navigation("Afiliado");

                    b.Navigation("BienesSolicitantes");

                    b.Navigation("DeclaracionImps");

                    b.Navigation("DetalleDeudas");

                    b.Navigation("Gastos");

                    b.Navigation("RolPagos");
                });
#pragma warning restore 612, 618
        }
    }
}

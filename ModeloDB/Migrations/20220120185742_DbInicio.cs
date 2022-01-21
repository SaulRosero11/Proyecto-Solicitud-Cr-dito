using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class DbInicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BienAdquirirs",
                columns: table => new
                {
                    BienAdquirirId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Propietario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avaluo = table.Column<float>(type: "real", nullable: false),
                    PagoIMP = table.Column<bool>(type: "bit", nullable: false),
                    Hipoteca = table.Column<bool>(type: "bit", nullable: false),
                    Escrituras = table.Column<bool>(type: "bit", nullable: false),
                    EstadoBien = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BienAdquirirs", x => x.BienAdquirirId);
                });

            migrationBuilder.CreateTable(
                name: "Solicitantes",
                columns: table => new
                {
                    SolicitanteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discapacidad = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitantes", x => x.SolicitanteId);
                });

            migrationBuilder.CreateTable(
                name: "Afiliado",
                columns: table => new
                {
                    AfiliadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoAfiliado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RucEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodoDesde = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodoHasta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAportaciones = table.Column<int>(type: "int", nullable: false),
                    SolicitanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afiliado", x => x.AfiliadoId);
                    table.ForeignKey(
                        name: "FK_Afiliado_Solicitantes_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Solicitantes",
                        principalColumn: "SolicitanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BienesSolicitante",
                columns: table => new
                {
                    BienesSolicitanteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Automovil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PagoPendienteAutomovil = table.Column<float>(type: "real", nullable: false),
                    Casa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PagoPendienteCasa = table.Column<float>(type: "real", nullable: false),
                    Terreno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PagoPendienteTerreno = table.Column<float>(type: "real", nullable: false),
                    TotalPendienteBienes = table.Column<float>(type: "real", nullable: false),
                    SolicitanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BienesSolicitante", x => x.BienesSolicitanteId);
                    table.ForeignKey(
                        name: "FK_BienesSolicitante_Solicitantes_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Solicitantes",
                        principalColumn: "SolicitanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeclaracionImps",
                columns: table => new
                {
                    DeclaracionImpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VentasAnuales = table.Column<float>(type: "real", nullable: false),
                    AporteIESS = table.Column<float>(type: "real", nullable: false),
                    PrestamosIESS = table.Column<float>(type: "real", nullable: false),
                    GastosVarios = table.Column<float>(type: "real", nullable: false),
                    TotalIngresos = table.Column<float>(type: "real", nullable: false),
                    SolicitanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeclaracionImps", x => x.DeclaracionImpId);
                    table.ForeignKey(
                        name: "FK_DeclaracionImps_Solicitantes_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Solicitantes",
                        principalColumn: "SolicitanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleDeudas",
                columns: table => new
                {
                    DetalleDeudasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TragetasCredito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PagoPendienteTargetas = table.Column<float>(type: "real", nullable: false),
                    CreditosLineaBlanca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PagoPendienteCreditos = table.Column<float>(type: "real", nullable: false),
                    TotalPendienteDeudas = table.Column<float>(type: "real", nullable: false),
                    SolicitanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleDeudas", x => x.DetalleDeudasId);
                    table.ForeignKey(
                        name: "FK_DetalleDeudas_Solicitantes_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Solicitantes",
                        principalColumn: "SolicitanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gastos",
                columns: table => new
                {
                    GastosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Arriendo = table.Column<float>(type: "real", nullable: false),
                    ServiciosBasicos = table.Column<float>(type: "real", nullable: false),
                    Comida = table.Column<float>(type: "real", nullable: false),
                    Transporte = table.Column<float>(type: "real", nullable: false),
                    Educacion = table.Column<float>(type: "real", nullable: false),
                    GastosVarios = table.Column<float>(type: "real", nullable: false),
                    TotalGastos = table.Column<float>(type: "real", nullable: false),
                    SolicitanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastos", x => x.GastosId);
                    table.ForeignKey(
                        name: "FK_Gastos_Solicitantes_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Solicitantes",
                        principalColumn: "SolicitanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolPagos",
                columns: table => new
                {
                    RolPagosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sueldo = table.Column<float>(type: "real", nullable: false),
                    AporteIESS = table.Column<float>(type: "real", nullable: false),
                    PrestamosIESS = table.Column<float>(type: "real", nullable: false),
                    Anticipo = table.Column<float>(type: "real", nullable: false),
                    TotalIngresos = table.Column<float>(type: "real", nullable: false),
                    SolicitanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolPagos", x => x.RolPagosId);
                    table.ForeignKey(
                        name: "FK_RolPagos_Solicitantes_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Solicitantes",
                        principalColumn: "SolicitanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistorialCrediticios",
                columns: table => new
                {
                    HistorialCrediticioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BienesSolicitanteId = table.Column<int>(type: "int", nullable: false),
                    DeudasBienes = table.Column<float>(type: "real", nullable: false),
                    DetalleDeudasId = table.Column<int>(type: "int", nullable: false),
                    DeudasDet = table.Column<float>(type: "real", nullable: false),
                    CentralRiesgos = table.Column<bool>(type: "bit", nullable: false),
                    PagosPendientes = table.Column<bool>(type: "bit", nullable: false),
                    EstadoHistorial = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialCrediticios", x => x.HistorialCrediticioId);
                    table.ForeignKey(
                        name: "FK_HistorialCrediticios_BienesSolicitante_BienesSolicitanteId",
                        column: x => x.BienesSolicitanteId,
                        principalTable: "BienesSolicitante",
                        principalColumn: "BienesSolicitanteId");
                    table.ForeignKey(
                        name: "FK_HistorialCrediticios_DetalleDeudas_DetalleDeudasId",
                        column: x => x.DetalleDeudasId,
                        principalTable: "DetalleDeudas",
                        principalColumn: "DetalleDeudasId");
                });

            migrationBuilder.CreateTable(
                name: "CapacidadPagos",
                columns: table => new
                {
                    CapacidadPagoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeclaracionImpId = table.Column<int>(type: "int", nullable: false),
                    Declaracion = table.Column<float>(type: "real", nullable: false),
                    RolPagosId = table.Column<int>(type: "int", nullable: false),
                    RolPagosTotal = table.Column<float>(type: "real", nullable: false),
                    GastosId = table.Column<int>(type: "int", nullable: false),
                    GastosTotal = table.Column<float>(type: "real", nullable: false),
                    CapcidadPago = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapacidadPagos", x => x.CapacidadPagoId);
                    table.ForeignKey(
                        name: "FK_CapacidadPagos_DeclaracionImps_DeclaracionImpId",
                        column: x => x.DeclaracionImpId,
                        principalTable: "DeclaracionImps",
                        principalColumn: "DeclaracionImpId");
                    table.ForeignKey(
                        name: "FK_CapacidadPagos_Gastos_GastosId",
                        column: x => x.GastosId,
                        principalTable: "Gastos",
                        principalColumn: "GastosId");
                    table.ForeignKey(
                        name: "FK_CapacidadPagos_RolPagos_RolPagosId",
                        column: x => x.RolPagosId,
                        principalTable: "RolPagos",
                        principalColumn: "RolPagosId");
                });

            migrationBuilder.CreateTable(
                name: "Solicitud",
                columns: table => new
                {
                    SolicitudId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCredito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscapacidadDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TNA = table.Column<float>(type: "real", nullable: false),
                    TiempoCredtio = table.Column<int>(type: "int", nullable: false),
                    TotalCredito = table.Column<float>(type: "real", nullable: false),
                    NumeroPagos = table.Column<int>(type: "int", nullable: false),
                    CuotaDesgrav = table.Column<float>(type: "real", nullable: false),
                    CuatoSeguro = table.Column<float>(type: "real", nullable: false),
                    CuotaMensual = table.Column<float>(type: "real", nullable: false),
                    TotalCuota = table.Column<float>(type: "real", nullable: false),
                    AfiliadoId = table.Column<int>(type: "int", nullable: false),
                    CapacidadPagoId = table.Column<int>(type: "int", nullable: false),
                    HistorialCrediticioId = table.Column<int>(type: "int", nullable: false),
                    BienAdquirirId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitud", x => x.SolicitudId);
                    table.ForeignKey(
                        name: "FK_Solicitud_Afiliado_AfiliadoId",
                        column: x => x.AfiliadoId,
                        principalTable: "Afiliado",
                        principalColumn: "AfiliadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Solicitud_BienAdquirirs_BienAdquirirId",
                        column: x => x.BienAdquirirId,
                        principalTable: "BienAdquirirs",
                        principalColumn: "BienAdquirirId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Solicitud_CapacidadPagos_CapacidadPagoId",
                        column: x => x.CapacidadPagoId,
                        principalTable: "CapacidadPagos",
                        principalColumn: "CapacidadPagoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Solicitud_HistorialCrediticios_HistorialCrediticioId",
                        column: x => x.HistorialCrediticioId,
                        principalTable: "HistorialCrediticios",
                        principalColumn: "HistorialCrediticioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Amortizacion",
                columns: table => new
                {
                    ValorCredito = table.Column<float>(type: "real", nullable: false),
                    TotalInteres = table.Column<float>(type: "real", nullable: false),
                    TotalCuota = table.Column<float>(type: "real", nullable: false),
                    EstadoCredito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolicitudId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Amortizacion_Solicitud_SolicitudId",
                        column: x => x.SolicitudId,
                        principalTable: "Solicitud",
                        principalColumn: "SolicitudId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Afiliado_SolicitanteId",
                table: "Afiliado",
                column: "SolicitanteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Amortizacion_SolicitudId",
                table: "Amortizacion",
                column: "SolicitudId");

            migrationBuilder.CreateIndex(
                name: "IX_BienesSolicitante_SolicitanteId",
                table: "BienesSolicitante",
                column: "SolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_CapacidadPagos_DeclaracionImpId",
                table: "CapacidadPagos",
                column: "DeclaracionImpId");

            migrationBuilder.CreateIndex(
                name: "IX_CapacidadPagos_GastosId",
                table: "CapacidadPagos",
                column: "GastosId");

            migrationBuilder.CreateIndex(
                name: "IX_CapacidadPagos_RolPagosId",
                table: "CapacidadPagos",
                column: "RolPagosId");

            migrationBuilder.CreateIndex(
                name: "IX_DeclaracionImps_SolicitanteId",
                table: "DeclaracionImps",
                column: "SolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleDeudas_SolicitanteId",
                table: "DetalleDeudas",
                column: "SolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_SolicitanteId",
                table: "Gastos",
                column: "SolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialCrediticios_BienesSolicitanteId",
                table: "HistorialCrediticios",
                column: "BienesSolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialCrediticios_DetalleDeudasId",
                table: "HistorialCrediticios",
                column: "DetalleDeudasId");

            migrationBuilder.CreateIndex(
                name: "IX_RolPagos_SolicitanteId",
                table: "RolPagos",
                column: "SolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_AfiliadoId",
                table: "Solicitud",
                column: "AfiliadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_BienAdquirirId",
                table: "Solicitud",
                column: "BienAdquirirId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_CapacidadPagoId",
                table: "Solicitud",
                column: "CapacidadPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_HistorialCrediticioId",
                table: "Solicitud",
                column: "HistorialCrediticioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amortizacion");

            migrationBuilder.DropTable(
                name: "Solicitud");

            migrationBuilder.DropTable(
                name: "Afiliado");

            migrationBuilder.DropTable(
                name: "BienAdquirirs");

            migrationBuilder.DropTable(
                name: "CapacidadPagos");

            migrationBuilder.DropTable(
                name: "HistorialCrediticios");

            migrationBuilder.DropTable(
                name: "DeclaracionImps");

            migrationBuilder.DropTable(
                name: "Gastos");

            migrationBuilder.DropTable(
                name: "RolPagos");

            migrationBuilder.DropTable(
                name: "BienesSolicitante");

            migrationBuilder.DropTable(
                name: "DetalleDeudas");

            migrationBuilder.DropTable(
                name: "Solicitantes");
        }
    }
}

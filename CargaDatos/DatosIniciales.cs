using System;
using Modelo.Entidades;
using System.Collections.Generic;

namespace CargaDatos
{
    public class DatosIniciales
    {
        public Dictionary<string, object> Carga()
        {
            //Agregar datos en Solicitante
            Solicitante Soli_Anthony = new Solicitante()
            {
                Nombres = "Anthony Saul",
                Apellidos = "Rosero Borja",
                Cedula = "1725152274",
                EstadoCivil = EstadoCivil.Soltero,
                FechaNac = new DateTime(1999, 10, 19),
                Discapacidad = false,
            };

            Solicitante Soli_Francisco = new Solicitante()
            {
                Nombres = "Francisco Xavier",
                Apellidos = "Benavides Solis",
                Cedula = "1713442703",
                EstadoCivil = EstadoCivil.Casado,
                FechaNac = new DateTime(1989, 1, 20),
                Discapacidad = false,
            };

            Solicitante Soli_Maria = new Solicitante()
            {
                Nombres = "Maria Belen",
                Apellidos = "Rojas Tipan",
                Cedula = "1725684895",
                EstadoCivil = EstadoCivil.Soltero,
                FechaNac = new DateTime(2000, 5, 5),
                Discapacidad = true,
            };

            Solicitante Soli_Elkin = new Solicitante()
            {
                Nombres = "Elkin David",
                Apellidos = "Romero Torres",
                Cedula = "1723213615",
                EstadoCivil = EstadoCivil.Casado,
                FechaNac = new DateTime(2000, 07, 20),
                Discapacidad = false
            };

            Solicitante Soli_Adrian = new Solicitante()
            {
                Nombres = "Adrian Sebastian",
                Apellidos = "Siguencia Remachi",
                Cedula = "1725698956",
                EstadoCivil = EstadoCivil.Viudo,
                FechaNac = new DateTime(1985, 05, 07),
                Discapacidad = false
            };

            List<Solicitante> listaSolicitante = new List<Solicitante>()
            {
                Soli_Anthony,Soli_Francisco,Soli_Maria, Soli_Elkin, Soli_Adrian
            };

            //Agregar datos Afiliado
            Afiliado Af_001 = new Afiliado()
            {
                TipoAfiliado = "Voluntario",
                RucEmpresa = "1725152274",
                NombreEmpresa = "Anthony Rosero",
                PeriodoDesde = new DateTime(2020, 12, 1),
                PeriodoHasta = new DateTime(2022, 01, 31),
                TotalAportaciones = 13,
                Solicitante = Soli_Anthony
            };

            Afiliado Af_002 = new Afiliado()
            {
                TipoAfiliado = "Patronato",
                RucEmpresa = "1326549805",
                NombreEmpresa = "Seguros Norte",
                PeriodoDesde = new DateTime(2015, 5, 1),
                PeriodoHasta = new DateTime(2022, 1, 31),
                TotalAportaciones = 80,
                Solicitante = Soli_Francisco,
            };

            Afiliado Af_003 = new Afiliado()
            {
                TipoAfiliado = "Patronato",
                RucEmpresa = "1736369454",
                NombreEmpresa = "SERCOP",
                PeriodoDesde = new DateTime(2000, 09, 08),
                PeriodoHasta = new DateTime(2022, 1, 31),
                TotalAportaciones = 256,
                Solicitante = Soli_Maria
            };

            Afiliado Af_004 = new Afiliado()
            {
                TipoAfiliado = "Patronato",
                RucEmpresa = "1736251695",
                NombreEmpresa = "La Favorita",
                PeriodoDesde = new DateTime(2019, 01, 08),
                PeriodoHasta = new DateTime(2022, 01, 31),
                TotalAportaciones = 36,
                Solicitante = Soli_Elkin
            };

            Afiliado Af_005 = new Afiliado()
            {
                TipoAfiliado = "Patronato",
                RucEmpresa = "1766339966",
                NombreEmpresa = "Nestle",
                PeriodoDesde = new DateTime(2019, 02, 08),
                PeriodoHasta = new DateTime(2022, 01, 31),
                TotalAportaciones = 35,
                Solicitante = Soli_Adrian
            };

            List<Afiliado> listaAfiliado = new List<Afiliado>()
            {
                Af_001, Af_002, Af_003
            };

            //Agregar datos RolPagos
            RolPagos RP_001 = new RolPagos()
            {
                Sueldo = 0f,
                AporteIESS = 0f,
                PrestamosIESS = 0f,
                Anticipo = 0f,
                TotalIngresos = 0f,
                Solicitante = Soli_Anthony
            };

            RolPagos RP_002 = new RolPagos()
            {
                Sueldo = 900.00f,
                AporteIESS = 49.50f,
                PrestamosIESS = 150.00f,
                Anticipo = 0f,
                TotalIngresos = 700.50f,
                Solicitante = Soli_Francisco
            };

            RolPagos RP_003 = new RolPagos()
            {
                Sueldo = 1500.00f,
                AporteIESS = 82.50f,
                PrestamosIESS = 300.00f,
                Anticipo = 200.00f,
                TotalIngresos = 917.50f,
                Solicitante = Soli_Maria
            };

            RolPagos RP_004 = new RolPagos()
            {
                Sueldo = 2000.00f,
                AporteIESS = 110.00f,
                PrestamosIESS = 0.00f,
                Anticipo = 300.00f,
                TotalIngresos = 1590.00f,
                Solicitante = Soli_Elkin
            };
            RolPagos RP_005 = new RolPagos()
            {
                Sueldo = 1200.00f,
                AporteIESS = 66.00f,
                PrestamosIESS = 100.00f,
                Anticipo = 0.00f,
                TotalIngresos = 1034.00f,
                Solicitante = Soli_Adrian
            };

            List<RolPagos> listaRolPagos = new List<RolPagos>()
            {
                RP_001, RP_002, RP_003, RP_004, RP_005
            };

            //Agregar datos Declaracion
            DeclaracionImp DI_001 = new DeclaracionImp()
            {
                VentasAnuales = 6000.00f,
                AporteIESS = 70.04f,
                PrestamosIESS = 0f,
                GastosVarios = 4000.00f,
                TotalIngresos = 1929.96f,
                Solicitante = Soli_Anthony
            };

            DeclaracionImp DI_002 = new DeclaracionImp()
            {
                VentasAnuales = 0f,
                AporteIESS = 0f,
                PrestamosIESS = 0f,
                GastosVarios = 0f,
                TotalIngresos = 0f,
                Solicitante = Soli_Francisco
            };

            DeclaracionImp DI_003 = new DeclaracionImp()
            {
                VentasAnuales = 0f,
                AporteIESS = 0f,
                PrestamosIESS = 0f,
                GastosVarios = 0f,
                TotalIngresos = 0f,
                Solicitante = Soli_Maria
            };

            DeclaracionImp DI_004 = new DeclaracionImp()
            {
                VentasAnuales = 0f,
                AporteIESS = 0f,
                PrestamosIESS = 0f,
                GastosVarios = 0f,
                TotalIngresos = 0f,
                Solicitante = Soli_Elkin
            };

            DeclaracionImp DI_005 = new DeclaracionImp()
            {
                VentasAnuales = 0f,
                AporteIESS = 0f,
                PrestamosIESS = 0f,
                GastosVarios = 0f,
                TotalIngresos = 0f,
                Solicitante = Soli_Adrian
            };

            List<DeclaracionImp> listDeclaracionImps = new List<DeclaracionImp>()
            {
                DI_001, DI_002, DI_003, DI_004, DI_005
            };

            //Agregar datos Gastos
            Gastos G_001 = new Gastos()
            {
                Arriendo = 250.00f,
                ServiciosBasicos = 70.00f,
                Comida = 70.00f,
                Transporte = 25.00f,
                Educacion = 0f,
                GastosVarios = 50.00f,
                TotalGastos = 465.00f,
                Solicitante = Soli_Anthony
            };

            Gastos G_002 = new Gastos()
            {
                Arriendo = 0f,
                ServiciosBasicos = 150.00f,
                Comida = 150.00f,
                Transporte = 50.00f,
                Educacion = 20.00f,
                GastosVarios = 20.00f,
                TotalGastos = 390.00f,
                Solicitante = Soli_Francisco
            };

            Gastos G_003 = new Gastos()
            {
                Arriendo = 100.00f,
                ServiciosBasicos = 50.00f,
                Comida = 50.00f,
                Transporte = 25.00f,
                Educacion = 0f,
                GastosVarios = 70.00f,
                TotalGastos = 295.00f,
                Solicitante = Soli_Maria
            };

            Gastos G_004 = new Gastos()
            {
                Arriendo = 0.00f,
                ServiciosBasicos = 75.00f,
                Comida = 100.00f,
                Transporte = 50.00f,
                Educacion = 0f,
                GastosVarios = 200.00f,
                TotalGastos = 425.00f,
                Solicitante = Soli_Elkin
            };

            Gastos G_005 = new Gastos()
            {
                Arriendo = 0.00f,
                ServiciosBasicos = 50.00f,
                Comida = 100.00f,
                Transporte = 25.00f,
                Educacion = 100f,
                GastosVarios = 50.00f,
                TotalGastos = 275.00f,
                Solicitante = Soli_Adrian
            };

            List<Gastos> listaGastos = new List<Gastos>()
            {
                G_001,G_002,G_003, G_004, G_005
            };

            //Agregar datos capcidadPagos
            CapacidadPago CP_001 = new CapacidadPago()
            {
                DeclaracionImp = DI_001,
                Declaracion = 1929.96f,
                RolPagos = RP_001,
                RolPagosTotal =0f,
                Gastos = G_001,
                GastosTotal = 465.00f,
                CapcidadPago = 1464.96f
            };

            CapacidadPago CP_002 = new CapacidadPago()
            {
                DeclaracionImp = DI_002,
                Declaracion = 0f,
                RolPagos = RP_002,
                RolPagosTotal = 700.50f,
                Gastos = G_002,
                GastosTotal = 390.00f,
                CapcidadPago = 310.50f
            };

            CapacidadPago CP_003 = new CapacidadPago()
            {
                DeclaracionImp = DI_003,
                Declaracion = 0f,
                RolPagos = RP_003,
                RolPagosTotal = 917.50f,
                Gastos = G_003,
                GastosTotal = 295.00f,
                CapcidadPago = 622.50f
            };

            CapacidadPago CP_004 = new CapacidadPago()
            {
                DeclaracionImp = DI_004,
                Declaracion = 0f,
                RolPagos = RP_004,
                RolPagosTotal = 1590.00f,
                Gastos = G_004,
                GastosTotal = 425.00f,
                CapcidadPago = 1165.00f
            };

            CapacidadPago CP_005 = new CapacidadPago()
            {
                DeclaracionImp = DI_005,
                Declaracion = 0f,
                RolPagos = RP_005,
                RolPagosTotal = 1034.00f,
                Gastos = G_005,
                GastosTotal = 275.00f,
                CapcidadPago = 759.00f
            };

            List<CapacidadPago> listaCapcidadPago = new List<CapacidadPago>()
            {
                CP_001, CP_002,CP_003, CP_004, CP_005
            };

            //Agregar dats Bienes Solicitante
            BienesSolicitante BS_001 = new BienesSolicitante()
            {
                Automovil= Automovil.Si,
                PagoPendienteAutomovil = 0f,
                Casa = Casa.No,
                PagoPendienteCasa = 0f,
                Terreno = Terreno.No,
                PagoPendienteTerreno = 0f,
                TotalPendienteBienes = 0f,
                Solicitante = Soli_Anthony
            };

            BienesSolicitante BS_002 = new BienesSolicitante()
            {
                Automovil = Automovil.Si,
                PagoPendienteAutomovil = 150.00f,
                Casa = Casa.Si,
                PagoPendienteCasa = 0f,
                Terreno = Terreno.No,
                PagoPendienteTerreno = 0f,
                TotalPendienteBienes = 150.00f,
                Solicitante = Soli_Francisco
            };

            BienesSolicitante BS_003 = new BienesSolicitante()
            {
                Automovil = Automovil.No,
                PagoPendienteAutomovil = 0f,
                Casa = Casa.No,
                PagoPendienteCasa = 0f,
                Terreno = Terreno.No,
                PagoPendienteTerreno = 0f,
                TotalPendienteBienes = 0f,
                Solicitante = Soli_Maria
            };

            BienesSolicitante BS_004 = new BienesSolicitante()
            {
                Automovil = Automovil.Si,
                PagoPendienteAutomovil = 1500f,
                Casa = Casa.Si,
                PagoPendienteCasa = 0f,
                Terreno = Terreno.No,
                PagoPendienteTerreno = 0f,
                TotalPendienteBienes = 1500f,
                Solicitante = Soli_Elkin
            };

            BienesSolicitante BS_005 = new BienesSolicitante()
            {
                Automovil = Automovil.No,
                PagoPendienteAutomovil = 0f,
                Casa = Casa.Si,
                PagoPendienteCasa = 0f,
                Terreno = Terreno.No,
                PagoPendienteTerreno = 0f,
                TotalPendienteBienes = 0f,
                Solicitante = Soli_Adrian
            };

            List<BienesSolicitante> listaBienesSolicitante = new List<BienesSolicitante>()
            {
                BS_001,BS_002, BS_003, BS_004, BS_005
            };

            //Agregar datos DetalleDeudas
            DetalleDeudas DD_001 = new DetalleDeudas()
            {
                TragetasCredito = Targetas.Si,
                PagoPendienteTargetas = 0f,
                CreditosLineaBlanca = CreditosLineaBlanca.No,
                PagoPendienteCreditos = 0f,
                TotalPendienteDeudas = 0f, 
                Solicitante = Soli_Anthony
            };

            DetalleDeudas DD_002 = new DetalleDeudas()
            {
                TragetasCredito = Targetas.Si,
                PagoPendienteTargetas = 0f,
                CreditosLineaBlanca = CreditosLineaBlanca.No,
                PagoPendienteCreditos = 0f,
                TotalPendienteDeudas = 0f,
                Solicitante = Soli_Francisco
            };

            DetalleDeudas DD_003 = new DetalleDeudas()
            {
                TragetasCredito = Targetas.No,
                PagoPendienteTargetas = 0f,
                CreditosLineaBlanca = CreditosLineaBlanca.No,
                PagoPendienteCreditos = 0f,
                TotalPendienteDeudas = 0f,
                Solicitante = Soli_Maria
            };

            DetalleDeudas DD_004 = new DetalleDeudas()
            {
                TragetasCredito = Targetas.Si,
                PagoPendienteTargetas = 0f,
                CreditosLineaBlanca = CreditosLineaBlanca.No,
                PagoPendienteCreditos = 0f,
                TotalPendienteDeudas = 0f,
                Solicitante = Soli_Elkin
            };

            DetalleDeudas DD_005 = new DetalleDeudas()
            {
                TragetasCredito = Targetas.No,
                PagoPendienteTargetas = 0f,
                CreditosLineaBlanca = CreditosLineaBlanca.No,
                PagoPendienteCreditos = 0f,
                TotalPendienteDeudas = 0f,
                Solicitante = Soli_Adrian
            };

            List<DetalleDeudas> listaDetalleDeudas = new List<DetalleDeudas>()
            {
                DD_001,DD_002,DD_003, DD_004, DD_005
            };

            //Agregar datos Historial Crediticio
            HistorialCrediticio HC_001 = new HistorialCrediticio()
            {
                BienesSolicitante = BS_001,
                DeudasBienes = 0f,
                DetalleDeudas = DD_001,
                DeudasDet = 0f,
                CentralRiesgos = CentralRiesgos.No,
                PagosPendientes = PagosPendientes.No,
                EstadoHistorial = EstadoHistorial.Aprobo
            };

            HistorialCrediticio HC_002 = new HistorialCrediticio()
            {
                BienesSolicitante = BS_002,
                DeudasBienes = 150.00f,
                DetalleDeudas = DD_002,
                DeudasDet = 0f,
                CentralRiesgos = CentralRiesgos.Si,
                PagosPendientes = PagosPendientes.No,
                EstadoHistorial = EstadoHistorial.NoAprobo
            };

            HistorialCrediticio HC_003 = new HistorialCrediticio()
            {
                BienesSolicitante = BS_003,
                DeudasBienes = 0f,
                DetalleDeudas = DD_003,
                DeudasDet = 0f,
                CentralRiesgos = CentralRiesgos.No,
                PagosPendientes = PagosPendientes.No,
                EstadoHistorial = EstadoHistorial.Aprobo
            };

            HistorialCrediticio HC_004 = new HistorialCrediticio()
            {
                BienesSolicitante = BS_004,
                DeudasBienes = 1500f,
                DetalleDeudas = DD_004,
                DeudasDet = 0f,
                CentralRiesgos = CentralRiesgos.No,
                PagosPendientes = PagosPendientes.No,
                EstadoHistorial = EstadoHistorial.NoAprobo
            };

            HistorialCrediticio HC_005 = new HistorialCrediticio()
            {
                BienesSolicitante = BS_005,
                DeudasBienes = 0f,
                DetalleDeudas = DD_005,
                DeudasDet = 0f,
                CentralRiesgos = CentralRiesgos.No,
                PagosPendientes = PagosPendientes.No,
                EstadoHistorial = EstadoHistorial.Aprobo
            };

            List<HistorialCrediticio> listaHistorialCrediticio = new List<HistorialCrediticio>()
            {
                HC_001,HC_002,HC_003, HC_004, HC_005
            };

            //Agregar datos BienAdquirir
            BienAdquirir BA_001 = new BienAdquirir()
            {
                Propietario = "Augusto Salazar",
                TipoVivienda = "OTROS BIENES INMUEBLES",
                Avaluo = 90000.00f,
                PagoIMP = PagoImp.Si,
                Hipoteca = Hipoteca.No,
                Escrituras = Escrituras.Si,
                EstadoBien = EstadoBien.Aprovado
            };

            BienAdquirir BA_002 = new BienAdquirir()
            {
                Propietario = "Carolina Borja",
                TipoVivienda = "TERRENO",
                Avaluo = 30000.00f,
                PagoIMP = PagoImp.Si,
                Hipoteca = Hipoteca.No,
                Escrituras = Escrituras.Si,
                EstadoBien = EstadoBien.Aprovado
            };

            BienAdquirir BA_003 = new BienAdquirir()
            {
                Propietario = "Mario Toapanta",
                TipoVivienda = "VIVIENDA DE INTERÉS PÚBLICO",
                Avaluo = 40000.00f,
                PagoIMP = PagoImp.Si,
                Hipoteca = Hipoteca.No,
                Escrituras = Escrituras.Si,
                EstadoBien = EstadoBien.Aprovado
            };

            BienAdquirir BA_004 = new BienAdquirir()
            {
                Propietario = "Nanci Cardenas",
                TipoVivienda = "TERRENO",
                Avaluo = 75000.00f,
                PagoIMP = PagoImp.Si,
                Hipoteca = Hipoteca.No,
                Escrituras = Escrituras.Si,
                EstadoBien = EstadoBien.Aprovado
            };

            BienAdquirir BA_005 = new BienAdquirir()
            {
                Propietario = "Luis Lopez",
                TipoVivienda = "Terreno",
                Avaluo = 50000.00f,
                PagoIMP = PagoImp.No,
                Hipoteca = Hipoteca.No,
                Escrituras = Escrituras.Si,
                EstadoBien = EstadoBien.Reporbado
            };

            List<BienAdquirir> listaBienAdquirir = new List<BienAdquirir>()
            {
                BA_001,BA_002,BA_003, BA_004, BA_005
            };

            //Agregar datos Solicitud
            Solicitud S_001 = new Solicitud()
            {
                TipoCredito = "OTROS BIENES INMUEBLES",
                DiscapacidadDesc = false,
                TNA= "6.70%",
                TiempoCredito = 25,
                TotalCredito = 90000.00f,
                NumeroPagos = 300, 
                CuotaDesgrav = 21.13f,
                CuatoSeguro = 6.93f, 
                CuotaMensual = 618.98f,
                TotalCuota = 647.04f,
                Afiliado = Af_001,
                CapacidadPago = CP_001,
                HistorialCrediticio = HC_001,
                BienAdquirir = BA_001
            };

            Solicitud S_002 = new Solicitud()
            {
                TipoCredito = "TERRENO",
                DiscapacidadDesc = false,
                TNA = "6.70%",
                TiempoCredito = 20,
                TotalCredito = 30000.00f,
                NumeroPagos = 240,
                CuotaDesgrav = 21.13f,
                CuatoSeguro = 6.93f,
                CuotaMensual = 227.22f,
                TotalCuota = 255.28f,
                Afiliado = Af_002,
                CapacidadPago = CP_002,
                HistorialCrediticio = HC_002,
                BienAdquirir = BA_002
            };

            Solicitud S_003 = new Solicitud()
            {
                TipoCredito = "VIVIENDA DE INTERÉS PÚBLICO",
                DiscapacidadDesc = true,
                TNA = "6.70%",
                TiempoCredito = 18,
                TotalCredito = 20000.00f,
                NumeroPagos = 216,
                CuotaDesgrav = 21.13f,
                CuatoSeguro = 6.93f,
                CuotaMensual = 159.61f,
                TotalCuota = 187.67f,
                Afiliado = Af_003,
                CapacidadPago = CP_003,
                HistorialCrediticio = HC_003,
                BienAdquirir = BA_003
            };

            Solicitud S_004 = new Solicitud()
            {
                TipoCredito = "TERRENO",
                DiscapacidadDesc = false,
                TNA = "6.70%",
                TiempoCredito = 25,
                TotalCredito = 75000.00f,
                NumeroPagos = 300,
                CuotaDesgrav = 21.13f,
                CuatoSeguro = 6.93f,
                CuotaMensual = 515.82f,
                TotalCuota = 543.88f,
                Afiliado = Af_004,
                CapacidadPago = CP_004,
                HistorialCrediticio = HC_004,
                BienAdquirir = BA_004
            };

            Solicitud S_005 = new Solicitud()
            {
                TipoCredito = "Terreno",
                DiscapacidadDesc = false,
                TNA = "6.70%",
                TiempoCredito = 20,
                TotalCredito = 50000.00f,
                NumeroPagos = 240,
                CuotaDesgrav = 21.13f,
                CuatoSeguro = 6.93f,
                CuotaMensual = 378.70f,
                TotalCuota = 406.76f,
                Afiliado = Af_005,
                CapacidadPago = CP_005,
                HistorialCrediticio = HC_005,
                BienAdquirir = BA_005
            };

            List<Solicitud> listaSolicitud = new List<Solicitud>()
            {
                S_001, S_002, S_003, S_004, S_005
            };

            //Agregar datos Amortizacion
            Amortizacion A_001 = new Amortizacion()
            {
                ValorCredito = 90000.00f,
                PagoMensual = 647.04f,
                Estado = Estado.Aprobada
            };

            Amortizacion A_002 = new Amortizacion()
            {
                ValorCredito = 30000.00f,
                PagoMensual = 255.28f,
                Estado = Estado.Rechazada
            };

            Amortizacion A_003 = new Amortizacion()
            {
                ValorCredito = 20000.00f,
                PagoMensual = 187.67f,
                Estado = Estado.Pendiente
            };

            Amortizacion A_004 = new Amortizacion()
            {
                ValorCredito = 50000.00f,
                PagoMensual = 543.88f,
                Estado = Estado.Pendiente
            };

            Amortizacion A_005 = new Amortizacion()
            {
                ValorCredito = 50000.00f,
                PagoMensual = 406.76f,
                Estado = Estado.Pendiente
            };

            List<Amortizacion> listaAmortizacion = new List<Amortizacion>()
            {
                A_001, A_002, A_003, A_004, A_005
            };

            //Agregar datos Solicitud Detalle
            Solicitud_Det SD_001 = new Solicitud_Det()
            {
                Solicitud = S_001,
                Amortizacion = A_001
            };

            Solicitud_Det SD_002 = new Solicitud_Det()
            {
                Solicitud = S_002,
                Amortizacion = A_002
            };

            Solicitud_Det SD_003 = new Solicitud_Det()
            {
                Solicitud = S_003,
                Amortizacion = A_003
            };

            Solicitud_Det SD_004 = new Solicitud_Det()
            {
                Solicitud = S_004,
                Amortizacion = A_004
            };

            Solicitud_Det SD_005 = new Solicitud_Det()
            {
                Solicitud = S_005,
                Amortizacion = A_005
            };

            List<Solicitud_Det> listaSolic_Det = new List<Solicitud_Det>()
            {
                SD_001,SD_002,SD_003, SD_004, SD_005
            };

            //Agregar Configuracion
            Configuracion Configuracion = new Configuracion()
            {
                Entidad="BIESS",
                PorcentajeSueldo = 0.35f
            };

            List<Configuracion> listConfiguracion = new List<Configuracion>()
            {
                Configuracion
            };

            //Diccionario contiene todas las listas
            Dictionary<string, object> dicListaDatos = new Dictionary<string, object>()
            {
                {"Solicitantes", listaSolicitante},
                {"Afiliados", listaAfiliado},
                {"RolPagos", listaRolPagos},
                {"DeclaracionImps", listDeclaracionImps},
                {"Gastos", listaGastos},
                {"CapacidadPagos", listaCapcidadPago},
                {"BienesSolicitantes", listaBienesSolicitante},
                {"DetalleDeudas", listaDetalleDeudas},
                {"HistorialCrediticios", listaHistorialCrediticio},
                {"BienAdquirir", listaBienAdquirir},
                {"Solicitud", listaSolicitud},
                {"Amortizacion", listaAmortizacion},
                {"Solicitud_Det", listaSolic_Det},
                {"Configuracion", listConfiguracion},
            };

            return dicListaDatos;
        }       
    }
}

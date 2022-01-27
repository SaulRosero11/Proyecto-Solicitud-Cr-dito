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
                EstadoCivil = "Soltero",
                FechaNac = new DateTime(1999, 10, 19),
                Discapacidad = false,
            };

            Solicitante Soli_Francisco = new Solicitante()
            {
                Nombres = "Francisco Xavier",
                Apellidos = "Benavides Solis",
                Cedula = "1713442703",
                EstadoCivil = "Casado",
                FechaNac = new DateTime(1989, 1, 20),
                Discapacidad = false,
            };

            Solicitante Soli_Maria = new Solicitante()
            {
                Nombres = "Maria Belen",
                Apellidos = "Rojas Tipan",
                Cedula = "1725684895",
                EstadoCivil = "Soltero",
                FechaNac = new DateTime(2000, 5, 5),
                Discapacidad = true,
            };

            List<Solicitante> listaSolicitante = new List<Solicitante>()
            {
                Soli_Anthony,Soli_Francisco,Soli_Maria
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
                PeriodoDesde = new DateTime(2019, 09, 08),
                PeriodoHasta = new DateTime(2022, 1, 31),
                TotalAportaciones = 28,
                Solicitante = Soli_Maria
            };

            List<Afiliado> listaAfiliado = new List<Afiliado>()
            {
                Af_001, Af_002, Af_003
            };

            //Agregar datos RolPagos
            RolPagos RP_001 = new RolPagos()
            {
                Sueldo = 900.00f,
                AporteIESS = 49.50f,
                PrestamosIESS = 150.00f,
                Anticipo = 0f,
                TotalIngresos = 700.50f,
                Solicitante = Soli_Francisco
            };

            RolPagos RP_002 = new RolPagos()
            {
                Sueldo = 1500.00f,
                AporteIESS = 82.50f,
                PrestamosIESS = 300.00f,
                Anticipo = 200.00f,
                TotalIngresos = 917.50f,
                Solicitante = Soli_Francisco
            };

            List<RolPagos> listaRolPagos = new List<RolPagos>()
            {
                RP_001, RP_002
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

            List<DeclaracionImp> listDeclaracionImps = new List<DeclaracionImp>()
            {
                DI_001
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

            List<Gastos> listaGastos = new List<Gastos>()
            {
                G_001,G_002,G_003
            };

            //Agregar datos capcidadPagos
            CapacidadPago CP_001 = new CapacidadPago()
            {
                DeclaracionImp = DI_001,
                Declaracion = 1929.96f,
                RolPagosTotal =0f,
                GastosTotal = 465.00f,
                CapcidadPago = 1464.96f
            };

            CapacidadPago CP_002 = new CapacidadPago()
            {
                Declaracion = 0f,
                RolPagos = RP_001,
                RolPagosTotal = 700.50f,
                GastosTotal = 390.00f,
                CapcidadPago = 310.50f
            };

            CapacidadPago CP_003 = new CapacidadPago()
            {
                Declaracion = 0f,
                RolPagos = RP_002,
                RolPagosTotal = 917.50f,
                GastosTotal = 295.00f,
                CapcidadPago = 622.50f
            };

            List<CapacidadPago> listaCapcidadPago = new List<CapacidadPago>()
            {
                CP_001, CP_002,CP_003
            };

            //Agregar dats Bienes Solicitante
            BienesSolicitante BS_001 = new BienesSolicitante()
            {
                Automovil= true,
                PagoPendienteAutomovil = 0f,
                Casa = false,
                PagoPendienteCasa = 0f,
                Terreno = false,
                PagoPendienteTerreno = 0f,
                TotalPendienteBienes = 0f,
                Solicitante = Soli_Anthony
            };

            BienesSolicitante BS_002 = new BienesSolicitante()
            {
                Automovil = true,
                PagoPendienteAutomovil = 150.00f,
                Casa = true,
                PagoPendienteCasa = 0f,
                Terreno = false,
                PagoPendienteTerreno = 0f,
                TotalPendienteBienes = 150.00f,
                Solicitante = Soli_Francisco
            };

            BienesSolicitante BS_003 = new BienesSolicitante()
            {
                Automovil = false,
                PagoPendienteAutomovil = 0f,
                Casa = false,
                PagoPendienteCasa = 0f,
                Terreno = false,
                PagoPendienteTerreno = 0f,
                TotalPendienteBienes = 0f,
                Solicitante = Soli_Anthony
            };

            List<BienesSolicitante> listaBienesSolicitante = new List<BienesSolicitante>()
            {
                BS_001,BS_002, BS_003
            };

            //Agregar datos DetalleDeudas
            DetalleDeudas DD_001 = new DetalleDeudas()
            {
                TragetasCredito = true,
                PagoPendienteTargetas = 0f,
                CreditosLineaBlanca = false,
                PagoPendienteCreditos = 0f,
                TotalPendienteDeudas = 0f, 
                Solicitante = Soli_Anthony
            };

            DetalleDeudas DD_002 = new DetalleDeudas()
            {
                TragetasCredito = false,
                PagoPendienteTargetas = 0f,
                CreditosLineaBlanca = false,
                PagoPendienteCreditos = 0f,
                TotalPendienteDeudas = 0f,
                Solicitante = Soli_Francisco
            };

            DetalleDeudas DD_003 = new DetalleDeudas()
            {
                TragetasCredito = false,
                PagoPendienteTargetas = 0f,
                CreditosLineaBlanca = false,
                PagoPendienteCreditos = 0f,
                TotalPendienteDeudas = 0f,
                Solicitante = Soli_Maria
            };

            List<DetalleDeudas> listaDetalleDeudas = new List<DetalleDeudas>()
            {
                DD_001,DD_002,DD_003
            };

            //Agregar datos Historial Crediticio
            HistorialCrediticio HC_001 = new HistorialCrediticio()
            {
                BienesSolicitante = BS_001,
                DeudasBienes = 0f,
                DetalleDeudas = DD_001,
                DeudasDet = 0f,
                CentralRiesgos = false,
                PagosPendientes = false,
                EstadoHistorial = true
            };

            HistorialCrediticio HC_002 = new HistorialCrediticio()
            {
                BienesSolicitante = BS_002,
                DeudasBienes = 150.00f,
                DetalleDeudas = DD_002,
                DeudasDet = 0f,
                CentralRiesgos = false,
                PagosPendientes = false,
                EstadoHistorial = false
            };

            HistorialCrediticio HC_003 = new HistorialCrediticio()
            {
                BienesSolicitante = BS_003,
                DeudasBienes = 0f,
                DetalleDeudas = DD_003,
                DeudasDet = 0f,
                CentralRiesgos = false,
                PagosPendientes = false,
                EstadoHistorial = true
            };

            List<HistorialCrediticio> listaHistorialCrediticio = new List<HistorialCrediticio>()
            {
                HC_001,HC_002,HC_003
            };

            //Agregar datos BienAdquirir
            BienAdquirir BA_001 = new BienAdquirir()
            {
                Propietario = "Augusto Salazar",
                Avaluo = 90000.00f,
                PagoIMP = true,
                Hipoteca = false,
                Escrituras = true,
                EstadoBien = true
            };

            BienAdquirir BA_002 = new BienAdquirir()
            {
                Propietario = "Carolina Borja",
                Avaluo = 30000.00f,
                PagoIMP = true,
                Hipoteca = false,
                Escrituras = true,
                EstadoBien = true
            };

            BienAdquirir BA_003 = new BienAdquirir()
            {
                Propietario = "Mario Toapanta",
                Avaluo = 40000.00f,
                PagoIMP = true,
                Hipoteca = false,
                Escrituras = true,
                EstadoBien = true
            };

            List<BienAdquirir> listaBienAdquirir = new List<BienAdquirir>()
            {
                BA_001,BA_002,BA_003
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

            List<Solicitud> listaSolicitud = new List<Solicitud>()
            {
                S_001, S_002, S_003
            };

            //Agregar datos Amortizacion
            Amortizacion A_001 = new Amortizacion()
            {
                ValorCredito = 90000.00f,
                TotalInteres = 150750.00f,
                TotalCuota = 34944.52f,
                EstadoCredito = true,
                Solicitud = S_001
            };

            Amortizacion A_002 = new Amortizacion()
            {
                ValorCredito = 30000.00f,
                TotalInteres = 40200.00f,
                TotalCuota = 14332.39f,
                EstadoCredito = false,
                Solicitud = S_002
            };

            Amortizacion A_003 = new Amortizacion()
            {
                ValorCredito = 20000.00f,
                TotalInteres = 24120.00f,
                TotalCuota = 10356.76f,
                EstadoCredito = true,
                Solicitud = S_003
            };

            List<Amortizacion> listaAmortizacion = new List<Amortizacion>()
            {
                A_001, A_002, A_003
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
                {"Amortizacion", listaAmortizacion}
            };

            return dicListaDatos;
        }       
    }
}

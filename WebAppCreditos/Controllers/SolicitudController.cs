using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCreditos.Controllers
{
    public class SolicitudController : Controller
    {
        private readonly DBCreditos db;

        public SolicitudController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar Solicitud
        public IActionResult Index()
        {
            IEnumerable<Solicitud> listaSolicitud = db.Solicitud
                .Include(afi => afi.Afiliado)
                    .ThenInclude(soli => soli.Solicitante);

            return View(listaSolicitud);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Lista de Afiliados
            var listaAfiliado = db.Afiliado
                .Include(sol => sol.Solicitante)
                .Select(afi => new
                {
                    AfiliadoId = afi.AfiliadoId,
                    Nombres = afi.Solicitante.Nombres,
                    Apellidos = afi.Solicitante.Apellidos
                }).ToList();
            // Lista de Detalle CapcidadPagos
            var listaCap = db.CapacidadPagos
                .Include(ga => ga.Gastos)
                    .ThenInclude(sol => sol.Solicitante)
                .Select(cap => new
                {
                    CapacidadId = cap.CapacidadPagoId,
                    Nombres = cap.Gastos.Solicitante.Nombres,
                    Apellidos = cap.Gastos.Solicitante.Apellidos
                }).ToList();
            // Lista de Detalle BienAdquirir
            var listaBien = db.BienAdquirirs
                .Select(bien => new
                {
                    BienId = bien.BienAdquirirId,
                    Nombres = bien.Propietario
                }).ToList();
            // Lista de Detalle Historial Crediticio
            var listaHistorial = db.HistorialCrediticios
                .Include(bien => bien.BienesSolicitante)
                    .ThenInclude(sol => sol.Solicitante)
                .Select(dets => new
                {
                    HistorialId = dets.HistorialCrediticioId,
                    Nombres = dets.BienesSolicitante.Solicitante.Nombres,
                    Apellidos = dets.BienesSolicitante.Solicitante.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaAfiliado = new SelectList(listaAfiliado, "AfiliadoId", "Nombres", "Apellidos");
            var selectListaCap = new SelectList(listaCap, "CapacidadId", "Nombres", "Apellidos");
            var selectListaBien = new SelectList(listaBien, "BienId", "Nombres");
            var selectListaHistorial = new SelectList(listaHistorial, "HistorialId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListAfiliado = selectListaAfiliado;
            ViewBag.selectListCap = selectListaCap;
            ViewBag.selectListBien = selectListaBien;
            ViewBag.selectListHistorial = selectListaHistorial;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Solicitud soli)
        {
            //Consulta Tipo Credito
            var tmpadquirr = db.BienAdquirirs
                .Single(add => add.BienAdquirirId == soli.BienAdquirirId);

            soli.TipoCredito = tmpadquirr.TipoVivienda;
            soli.TotalCredito = tmpadquirr.Avaluo;

            // Consulta Solicitante
            var tmpSoli = db.Afiliado
                .Include(soli => soli.Solicitante)
                .Single(afi => afi.AfiliadoId == soli.AfiliadoId);

            soli.DiscapacidadDesc = tmpSoli.Solicitante.Discapacidad;

            //Caclulo tiempo de pago
            soli.NumeroPagos = soli.TiempoCredito * 12;

            //Calculo Cuota mensual
            double mensual = (soli.TotalCredito * 0.067)/12;
            soli.CuotaMensual = (float)mensual;

            //Caculo Cuota Mensual Total
            soli.TotalCuota = soli.CuotaDesgrav + soli.CuotaMensual + soli.CuatoSeguro;

            db.Solicitud.Add(soli);
            db.SaveChanges();

            TempData["mensaje"] = $"La Solicitud se ha creado correctamente";

            return RedirectToAction("Index");
        }

        //Edicion de BieneSolicitante
        //Presenta el formulario lleno con los datos del Bien
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Lista de Afiliados
            var listaAfiliado = db.Afiliado
                .Include(sol => sol.Solicitante)
                .Select(afi => new
                {
                    AfiliadoId = afi.AfiliadoId,
                    Nombres = afi.Solicitante.Nombres,
                    Apellidos = afi.Solicitante.Apellidos
                }).ToList();
            // Lista de Detalle CapcidadPagos
            var listaCap = db.CapacidadPagos
                .Include(sol => sol.Gastos)
                    .ThenInclude(sol => sol.Solicitante)
                .Select(cap => new
                {
                    CapacidadId = cap.CapacidadPagoId,
                    Nombres = cap.Gastos.Solicitante.Nombres,
                    Apellidos = cap.Gastos.Solicitante.Apellidos
                }).ToList();
            // Lista de Detalle BienAdquirir
            var listaBien = db.BienAdquirirs
                .Select(bien => new
                {
                    BienId = bien.BienAdquirirId,
                    Nombres = bien.Propietario
                }).ToList();
            // Lista de Detalle Historial Crediticio
            var listaHistorial = db.HistorialCrediticios
                .Include(bien => bien.BienesSolicitante)
                    .ThenInclude(sol => sol.Solicitante)
                .Select(dets => new
                {
                    HistorialId = dets.HistorialCrediticioId,
                    Nombres = dets.BienesSolicitante.Solicitante.Nombres,
                    Apellidos = dets.BienesSolicitante.Solicitante.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaAfiliado = new SelectList(listaAfiliado, "AfiliadoId", "Nombres", "Apellidos");
            var selectListaCap = new SelectList(listaCap, "CapacidadId", "Nombres", "Apellidos");
            var selectListaBien = new SelectList(listaBien, "BienId", "Nombres");
            var selectListaHistorial = new SelectList(listaHistorial, "HistorialId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListAfiliado = selectListaAfiliado;
            ViewBag.selectListCap = selectListaCap;
            ViewBag.selectListBien = selectListaBien;
            ViewBag.selectListHistorial = selectListaHistorial;

            var solicitud = db.Solicitud
                .Include(rol => rol.Afiliado)
                    .ThenInclude(sol => sol.Solicitante)
                .Single(afili => afili.SolicitudId == id);

            return View(solicitud);
        }

        //Actualiza BienSolicitante
        [HttpPost]
        public IActionResult Edit(Solicitud soli)
        {
            db.Solicitud.Update(soli);
            db.SaveChanges();

            TempData["mensaje"] = $"La solicitud se ha editado correctamente";

            return RedirectToAction("Index");
        }

        //Eliminar Bien
        //Presenta el formulario lleno con los datos del bien seleccionado
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Lista de Afiliados
            var listaAfiliado = db.Afiliado
                .Include(sol => sol.Solicitante)
                .Select(afi => new
                {
                    AfiliadoId = afi.AfiliadoId,
                    Nombres = afi.Solicitante.Nombres,
                    Apellidos = afi.Solicitante.Apellidos
                }).ToList();
            // Lista de Detalle CapcidadPagos
            var listaCap = db.CapacidadPagos
                .Include(sol => sol.Gastos)
                    .ThenInclude(sol => sol.Solicitante)
                .Select(cap => new
                {
                    CapacidadId = cap.CapacidadPagoId,
                    Nombres = cap.Gastos.Solicitante.Nombres,
                    Apellidos = cap.Gastos.Solicitante.Apellidos
                }).ToList();
            // Lista de Detalle BienAdquirir
            var listaBien = db.BienAdquirirs
                .Select(bien => new
                {
                    BienId = bien.BienAdquirirId,
                    Nombres = bien.Propietario
                }).ToList();
            // Lista de Detalle Historial Crediticio
            var listaHistorial = db.HistorialCrediticios
                .Include(bien => bien.BienesSolicitante)
                    .ThenInclude(sol => sol.Solicitante)
                .Select(dets => new
                {
                    HistorialId = dets.HistorialCrediticioId,
                    Nombres = dets.BienesSolicitante.Solicitante.Nombres,
                    Apellidos = dets.BienesSolicitante.Solicitante.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaAfiliado = new SelectList(listaAfiliado, "AfiliadoId", "Nombres", "Apellidos");
            var selectListaCap = new SelectList(listaCap, "CapacidadId", "Nombres", "Apellidos");
            var selectListaBien = new SelectList(listaBien, "BienId", "Nombres");
            var selectListaHistorial = new SelectList(listaHistorial, "HistorialId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListAfiliado = selectListaAfiliado;
            ViewBag.selectListCap = selectListaCap;
            ViewBag.selectListBien = selectListaBien;
            ViewBag.selectListHistorial = selectListaHistorial;

            var solicitud = db.Solicitud
                .Include(rol => rol.Afiliado)
                    .ThenInclude(sol => sol.Solicitante)
                .Single(afili => afili.SolicitudId == id);

            return View(solicitud);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(Solicitud soli)
        {
            db.Solicitud.Remove(soli);
            db.SaveChanges();

            TempData["mensaje"] = $"La Solicitud se ha eliminado correctamente";

            return RedirectToAction("Index");
        }
    }
}

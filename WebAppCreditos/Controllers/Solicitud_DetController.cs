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
    public class Solicitud_DetController : Controller
    {
        private readonly DBCreditos db;

        public Solicitud_DetController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar Solicitud Det
        public IActionResult Index()
        {
            IEnumerable<Solicitud_Det> listaSoliDet = db.Solicitud_Dets
                .Include(sol => sol.Solicitud)
                    .ThenInclude(afi => afi.Afiliado)
                        .ThenInclude(sol => sol.Solicitante);

            return View(listaSoliDet);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Lista de Amortizacion
            var listaAmortizacion = db.Amortizacion
                .Select(bien => new
                {
                    AmortizacionId = bien.AmortizacionId,
                    Valor = bien.ValorCredito
                }).ToList();
            // Lista de Solicitud
            var listaSolicitud = db.Solicitud
                .Include(afi => afi.Afiliado)
                    .ThenInclude(soli => soli.Solicitante)
                .Select(dets => new
                {
                    SolicitudId = dets.SolicitudId,
                    Nombres = dets.Afiliado.Solicitante.Nombres,
                    Valor = dets.TotalCredito
                }).ToList();

            // Prepara las listas
            var selectListaAmortizacion = new SelectList(listaAmortizacion, "AmortizacionId", "Valor");
            var selectListaSolicitud = new SelectList(listaSolicitud, "SolicitudId", "Nombres" , "Valor");

            // Ingreso a ViewBag
            ViewBag.selectListAmortizacion = selectListaAmortizacion;
            ViewBag.selectListSolicitud = selectListaSolicitud;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Solicitud_Det soli)
        {
            db.Solicitud_Dets.Add(soli);
            db.SaveChanges();

            TempData["mensaje"] = $"La Solicitud Detalle se ha creado correctamente";

            return RedirectToAction("Index");
        }

        //Edicion de BieneSolicitante
        //Presenta el formulario lleno con los datos del Bien
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Lista de Amortizacion
            var listaAmortizacion = db.Amortizacion
                .Select(bien => new
                {
                    AmortizacionId = bien.AmortizacionId,
                    Valor = bien.ValorCredito
                }).ToList();
            // Lista de Solicitud
            var listaSolicitud = db.Solicitud
                .Include(afi => afi.Afiliado)
                    .ThenInclude(soli => soli.Solicitante)
                .Select(dets => new
                {
                    SolicitudId = dets.SolicitudId,
                    Nombres = dets.Afiliado.Solicitante.Nombres,
                    Apellidos = dets.Afiliado.Solicitante.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaAmortizacion = new SelectList(listaAmortizacion, "AmortizacionId", "Valor");
            var selectListaSolicitud = new SelectList(listaSolicitud, "SolicitudId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListAmortizacion = selectListaAmortizacion;
            ViewBag.selectListSolicitud = selectListaSolicitud;

            var soliDets = db.Solicitud_Dets
                .Include(rol => rol.Solicitud)
                    .ThenInclude(sol => sol.Afiliado)
                        .ThenInclude(sol => sol.Solicitante)
                .Single(afili => afili.Solicitud_DetId == id);

            return View(soliDets);
        }

        //Actualiza BienSolicitante
        [HttpPost]
        public IActionResult Edit(Solicitud_Det soli)
        {
            db.Solicitud_Dets.Update(soli);
            db.SaveChanges();

            TempData["mensaje"] = $"El detalle de la solicitud se ha editado correctamente";

            return RedirectToAction("Index");
        }

        //Eliminar Bien
        //Presenta el formulario lleno con los datos del bien seleccionado
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Lista de Amortizacion
            var listaAmortizacion = db.Amortizacion
                .Select(bien => new
                {
                    AmortizacionId = bien.AmortizacionId,
                    Valor = bien.ValorCredito
                }).ToList();
            // Lista de Solicitud
            var listaSolicitud = db.Solicitud
                .Include(afi => afi.Afiliado)
                    .ThenInclude(soli => soli.Solicitante)
                .Select(dets => new
                {
                    SolicitudId = dets.SolicitudId,
                    Nombres = dets.Afiliado.Solicitante.Nombres,
                    Apellidos = dets.Afiliado.Solicitante.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaAmortizacion = new SelectList(listaAmortizacion, "AmortizacionId", "Valor");
            var selectListaSolicitud = new SelectList(listaSolicitud, "SolicitudId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListAmortizacion = selectListaAmortizacion;
            ViewBag.selectListSolicitud = selectListaSolicitud;

            var soliDets = db.Solicitud_Dets
                .Include(rol => rol.Solicitud)
                    .ThenInclude(sol => sol.Afiliado)
                        .ThenInclude(sol => sol.Solicitante)
                .Single(afili => afili.Solicitud_DetId == id);

            return View(soliDets);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(Solicitud_Det soli)
        {
            db.Solicitud_Dets.Remove(soli);
            db.SaveChanges();

            TempData["mensaje"] = $"El detalle de la solicitud se ha eliminado correctamente";

            return RedirectToAction("Index");
        }
    }
}

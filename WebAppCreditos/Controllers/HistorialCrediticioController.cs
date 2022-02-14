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
    public class HistorialCrediticioController : Controller
    {
        private readonly DBCreditos db;

        public HistorialCrediticioController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar Historial Crediticio
        public IActionResult Index()
        {
            IEnumerable<HistorialCrediticio> listaHistorialCrediticio = db.HistorialCrediticios
                .Include(rol => rol.BienesSolicitante)
                    .ThenInclude(sol => sol.Solicitante);

            return View(listaHistorialCrediticio);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Lista de BienSolicitante
            var listaBien = db.BienesSolicitante
                .Include(sol => sol.Solicitante)
                .Select(bien => new
                {
                    BienId = bien.BienesSolicitanteId,
                    Nombres = bien.Solicitante.Nombres,
                    Apellidos = bien.Solicitante.Apellidos
                }).ToList();
            // Lista de Detalle Deudas
            var listaDet = db.DetalleDeudas
                .Include(sol => sol.Solicitante)
                .Select(dets => new
                {
                    DetalleId = dets.DetalleDeudasId,
                    Nombres = dets.Solicitante.Nombres,
                    Apellidos = dets.Solicitante.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaDet = new SelectList(listaDet, "DetalleId", "Nombres", "Apellidos");
            var selectListaBien = new SelectList(listaBien, "BienId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListDet = selectListaDet;
            ViewBag.selectListBien = selectListaBien;

            return View();
        }

        [HttpPost]
        public IActionResult Create(HistorialCrediticio historial)
        {
            //Consulta Detalle deudas
            var tmpdetalle = db.DetalleDeudas
                .Single(detalle => detalle.DetalleDeudasId == historial.DetalleDeudasId);
            
            historial.DeudasBienes = tmpdetalle.TotalPendienteDeudas;

            //Consulta BienSolicitante
            var tmpbien = db.BienesSolicitante
                .Single(bien => bien.BienesSolicitanteId == historial.BienesSolicitanteId);

            historial.DeudasBienes = tmpbien.TotalPendienteBienes;

            //Validamos el estado del historial
            if (historial.DeudasBienes <= 0 && historial.DeudasDet <= 0 && historial.CentralRiesgos  == CentralRiesgos.No && historial.PagosPendientes == PagosPendientes.No)
            {
                historial.EstadoHistorial = EstadoHistorial.Aprobo;
            }          
            else
            {
                historial.EstadoHistorial = EstadoHistorial.NoAprobo;
            }

            db.HistorialCrediticios.Add(historial);
            db.SaveChanges();

            TempData["mensaje"] = $"El Historial Crediticio se ha creado correctamente";

            return RedirectToAction("Index");
        }

        //Edicion de BieneSolicitante
        //Presenta el formulario lleno con los datos del Bien
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Lista de BienSolicitante
            var listaBien = db.BienesSolicitante
                .Include(sol => sol.Solicitante)
                .Select(bien => new
                {
                    BienId = bien.BienesSolicitanteId,
                    Nombres = bien.Solicitante.Nombres,
                    Apellidos = bien.Solicitante.Apellidos
                }).ToList();
            // Lista de Detalle Deudas
            var listaDet = db.DetalleDeudas
                .Include(sol => sol.Solicitante)
                .Select(dets => new
                {
                    DetalleId = dets.DetalleDeudasId,
                    Nombres = dets.Solicitante.Nombres,
                    Apellidos = dets.Solicitante.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaDet = new SelectList(listaDet, "DetalleId", "Nombres", "Apellidos");
            var selectListaBien = new SelectList(listaBien, "BienId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListDet = selectListaDet;
            ViewBag.selectListBien = selectListaBien;

            var historial = db.HistorialCrediticios
                .Include(rol => rol.BienesSolicitante)
                    .ThenInclude(sol => sol.Solicitante)
                .Single(afili => afili.HistorialCrediticioId == id);

            return View(historial);
        }

        //Actualiza BienSolicitante
        [HttpPost]
        public IActionResult Edit(HistorialCrediticio historial)
        {
            //Consulta Detalle deudas
            var tmpdetalle = db.DetalleDeudas
                .Single(detalle => detalle.DetalleDeudasId == historial.DetalleDeudasId);

            historial.DeudasBienes = tmpdetalle.TotalPendienteDeudas;

            //Consulta BienSolicitante
            var tmpbien = db.BienesSolicitante
                .Single(bien => bien.BienesSolicitanteId == historial.BienesSolicitanteId);

            historial.DeudasBienes = tmpbien.TotalPendienteBienes;

            //Validamos el estado del historial
            if (historial.DeudasBienes <= 0 && historial.DeudasDet <= 0 && historial.CentralRiesgos == CentralRiesgos.No && historial.PagosPendientes == PagosPendientes.No)
            {
                historial.EstadoHistorial = EstadoHistorial.Aprobo;
            }
            else
            {
                historial.EstadoHistorial = EstadoHistorial.NoAprobo;
            }

            db.HistorialCrediticios.Update(historial);
            db.SaveChanges();

            TempData["mensaje"] = $"LEl Historial se ha editado correctamente";

            return RedirectToAction("Index");
        }

        //Eliminar Bien
        //Presenta el formulario lleno con los datos del bien seleccionado
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Lista de BienSolicitante
            var listaBien = db.BienesSolicitante
                .Include(sol => sol.Solicitante)
                .Select(bien => new
                {
                    BienId = bien.BienesSolicitanteId,
                    Nombres = bien.Solicitante.Nombres,
                    Apellidos = bien.Solicitante.Apellidos
                }).ToList();
            // Lista de Detalle Deudas
            var listaDet = db.DetalleDeudas
                .Include(sol => sol.Solicitante)
                .Select(dets => new
                {
                    DetalleId = dets.DetalleDeudasId,
                    Nombres = dets.Solicitante.Nombres,
                    Apellidos = dets.Solicitante.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaDet = new SelectList(listaDet, "DetalleId", "Nombres", "Apellidos");
            var selectListaBien = new SelectList(listaBien, "BienId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListDet = selectListaDet;
            ViewBag.selectListBien = selectListaBien;

            var historial = db.HistorialCrediticios
                .Include(rol => rol.BienesSolicitante)
                    .ThenInclude(sol => sol.Solicitante)
                .Single(afili => afili.HistorialCrediticioId == id);

            return View(historial);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(HistorialCrediticio historial)
        {
            db.HistorialCrediticios.Remove(historial);
            db.SaveChanges();

            TempData["mensaje"] = $"El Historial se ha eliminado correctamente";

            return RedirectToAction("Index");
        }
    }
}

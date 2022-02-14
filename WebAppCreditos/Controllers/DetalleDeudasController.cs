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
    public class DetalleDeudasController : Controller
    {
        private readonly DBCreditos db;

        public DetalleDeudasController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar Detalles Deudas
        public IActionResult Index()
        {
            IEnumerable<DetalleDeudas> listaDetalleDeudas = db.DetalleDeudas
                .Include(afiliado => afiliado.Solicitante);

            return View(listaDetalleDeudas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Lista de Solicitantes
            var listaSoli = db.Solicitantes
                .Select(Soli => new
                {
                    SolicitanteId = Soli.SolicitanteId,
                    Nombres = Soli.Nombres,
                    Apellidos = Soli.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaSolicitantes = new SelectList(listaSoli, "SolicitanteId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListSolicitantes = selectListaSolicitantes;

            return View();
        }

        [HttpPost]
        public IActionResult Create(DetalleDeudas detalle)
        {
            //Calculo total de deudas pendientes
            detalle.TotalPendienteDeudas = detalle.PagoPendienteTargetas + detalle.PagoPendienteCreditos;

            db.DetalleDeudas.Add(detalle);
            db.SaveChanges();

            TempData["mensaje"] = $"El detalle de deudas del solicitante {detalle.SolicitanteId} se ha creado correctamente";

            return RedirectToAction("Index");
        }

        //Edicion de Detalle
        //Presenta el formulario lleno con los datos del detalle
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Lista de Solicitantes
            var listaSoli = db.Solicitantes
                .Select(Soli => new
                {
                    SolicitanteId = Soli.SolicitanteId,
                    Nombres = Soli.Nombres,
                    Apellidos = Soli.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaSolicitantes = new SelectList(listaSoli, "SolicitanteId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListSolicitantes = selectListaSolicitantes;

            var detalle = db.DetalleDeudas
               .Include(soli => soli.Solicitante)
               .Single(afili => afili.DetalleDeudasId== id);

            return View(detalle);
        }

        //Actualiza DetalleDeudas
        [HttpPost]
        public IActionResult Edit(DetalleDeudas detalle)
        {
            //Calculo total de deudas pendientes
            detalle.TotalPendienteDeudas = detalle.PagoPendienteTargetas + detalle.PagoPendienteCreditos;

            db.DetalleDeudas.Update(detalle);
            db.SaveChanges();

            TempData["mensaje"] = $"El detalle deuda del solicitante {detalle.SolicitanteId} se ha editada correctamente";

            return RedirectToAction("Index");
        }

        //Eliminar Detalle deudas
        //Presenta el formulario lleno con los datos del detalle deudas
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Lista de Solicitantes
            var listaSoli = db.Solicitantes
                .Select(Soli => new
                {
                    SolicitanteId = Soli.SolicitanteId,
                    Nombres = Soli.Nombres,
                    Apellidos = Soli.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaSolicitantes = new SelectList(listaSoli, "SolicitanteId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListSolicitantes = selectListaSolicitantes;

            var detalle = db.DetalleDeudas
               .Include(soli => soli.Solicitante)
               .Single(afili => afili.DetalleDeudasId == id);

            return View(detalle);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(DetalleDeudas detalle)
        {
            db.DetalleDeudas.Remove(detalle);
            db.SaveChanges();

            TempData["mensaje"] = $"El afiliado se ha eliminado correctamente";

            return RedirectToAction("Index");
        }
    }
}

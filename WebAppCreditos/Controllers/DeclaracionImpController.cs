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
    public class DeclaracionImpController : Controller
    {
        private readonly DBCreditos db;

        public DeclaracionImpController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar Rol Pagos
        public IActionResult Index()
        {
            IEnumerable<DeclaracionImp> listaDeclaracionImp = db.DeclaracionImps
                .Include(afiliado => afiliado.Solicitante);

            return View(listaDeclaracionImp);
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
        public IActionResult Create(DeclaracionImp declaracion)
        {
            //Total de Declaracion 
            declaracion.TotalIngresos = declaracion.VentasAnuales - (declaracion.AporteIESS + declaracion.PrestamosIESS + declaracion.GastosVarios);

            db.DeclaracionImps.Add(declaracion);
            db.SaveChanges();

            TempData["mensaje"] = $"La declaracion del solicitante {declaracion.SolicitanteId} se ha creado correctamente";

            return RedirectToAction("Index");
        }

        //Edicion de Declaracion
        //Presenta el formulario lleno con los datos del declaracion
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

            var declaracion = db.DeclaracionImps
               .Include(soli => soli.Solicitante)
               .Single(afili => afili.DeclaracionImpId == id);

            return View(declaracion);
        }

        //Actualiza declaracion
        [HttpPost]
        public IActionResult Edit(DeclaracionImp declaracion)
        {
            //Total de Declaracion 
            declaracion.TotalIngresos = declaracion.VentasAnuales - (declaracion.AporteIESS + declaracion.PrestamosIESS + declaracion.GastosVarios);

            db.DeclaracionImps.Update(declaracion);
            db.SaveChanges();

            TempData["mensaje"] = $"La declaracion del solicitante {declaracion.SolicitanteId} se ha editada correctamente";

            return RedirectToAction("Index");
        }

        //Eliminar Declaracion
        //Presenta el formulario lleno con los datos del Declraracion
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

            var declaracion = db.DeclaracionImps
               .Include(soli => soli.Solicitante)
               .Single(afili => afili.DeclaracionImpId == id);

            return View(declaracion);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(DeclaracionImp declaracion)
        {
            db.DeclaracionImps.Remove(declaracion);
            db.SaveChanges();

            TempData["mensaje"] = $"El afiliado se ha eliminado correctamente";

            return RedirectToAction("Index");
        }
    }
}

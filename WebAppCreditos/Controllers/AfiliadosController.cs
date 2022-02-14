using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAppCreditos.Controllers
{
    public class AfiliadosController : Controller
    {
        private readonly DBCreditos db;

        public AfiliadosController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar Afiliados
        public IActionResult Index()
        {
            IEnumerable<Afiliado> listaAfiliados = db.Afiliado
                .Include(afiliado => afiliado.Solicitante);

            return View(listaAfiliados);
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
        public IActionResult Create(Afiliado afiliado)
        {
            //Se obtiene el número de aportes al IESS
            afiliado.TotalAportaciones = (((afiliado.PeriodoHasta - afiliado.PeriodoDesde).Days)*12)/365;
        
            db.Afiliado.Add(afiliado);
            db.SaveChanges();

            TempData["mensaje"] = $"El afiliado de la empresa {afiliado.NombreEmpresa} se ha creado correctamente";

            return RedirectToAction("Index");
        }

        //Edicion de Afiliado
        //Presenta el formulario lleno con los datos del Afiliado seleccionada
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

            var afiliado = db.Afiliado
                .Include(soli =>soli.Solicitante)
                .Single(afili => afili.AfiliadoId == id);

            return View(afiliado);
        }

        //Actualiza Solicitante
        [HttpPost]
        public IActionResult Edit(Afiliado afiliado)
        {
            //Se obtiene el número de aportes al IESS
            afiliado.TotalAportaciones = (((afiliado.PeriodoHasta - afiliado.PeriodoDesde).Days) * 12) / 365;

            db.Afiliado.Update(afiliado);
            db.SaveChanges();

            TempData["mensaje"] = $"El afiliado de la empresa {afiliado.NombreEmpresa} se ha editado correctamente";

            return RedirectToAction("Index");
        }

        //Eliminar Afiliado
        //Presenta el formulario lleno con los datos del afiliado seleccionado
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

            var afiliado = db.Afiliado
               .Include(soli => soli.Solicitante)
               .Single(afili => afili.AfiliadoId == id);

            return View(afiliado);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(Afiliado afiliado)
        {
            db.Afiliado.Remove(afiliado);
            db.SaveChanges();

            TempData["mensaje"] = $"El afiliado se ha eliminado correctamente";

            return RedirectToAction("Index");
        }
    }
}

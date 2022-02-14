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
    public class BienesSolicitanteController : Controller
    {
        private readonly DBCreditos db;

        public BienesSolicitanteController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar Afiliados
        public IActionResult Index()
        {
            IEnumerable<BienesSolicitante> listaBienesSolicitante = db.BienesSolicitante
                .Include(afiliado => afiliado.Solicitante); 

            return View(listaBienesSolicitante);
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
        public IActionResult Create(BienesSolicitante bienes)
        {
            //Calculo total deudas bienes
            bienes.TotalPendienteBienes = bienes.PagoPendienteAutomovil + bienes.PagoPendienteCasa + bienes.PagoPendienteTerreno;

            db.BienesSolicitante.Add(bienes);
            db.SaveChanges();

            TempData["mensaje"] = $"El bien del solicitante {bienes.SolicitanteId} se ha creado correctamente";

            return RedirectToAction("Index");
        }

        //Edicion de BieneSolicitante
        //Presenta el formulario lleno con los datos del Bien
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

            var bienSolicitante = db.BienesSolicitante
                .Include(soli => soli.Solicitante)
                .Single(afili => afili.BienesSolicitanteId == id);

            return View(bienSolicitante);
        }

        //Actualiza BienSolicitante
        [HttpPost]
        public IActionResult Edit(BienesSolicitante bienes)
        {
            //Calculo total deudas bienes
            bienes.TotalPendienteBienes = bienes.PagoPendienteAutomovil + bienes.PagoPendienteCasa + bienes.PagoPendienteTerreno;

            db.BienesSolicitante.Update(bienes);
            db.SaveChanges();

            TempData["mensaje"] = $"El bien del solicitante  {bienes.SolicitanteId} se ha editado correctamente";

            return RedirectToAction("Index");
        }

        //Eliminar Bien
        //Presenta el formulario lleno con los datos del bien seleccionado
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

            var bienSolicitante = db.BienesSolicitante
                .Include(soli => soli.Solicitante)
                .Single(afili => afili.BienesSolicitanteId == id);

            return View(bienSolicitante);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(BienesSolicitante bienes)
        {
            db.BienesSolicitante.Remove(bienes);
            db.SaveChanges();

            TempData["mensaje"] = $"El Bien se ha eliminado correctamente";

            return RedirectToAction("Index");
        }
    }
}

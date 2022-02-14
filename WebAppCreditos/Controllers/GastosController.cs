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
    public class GastosController : Controller
    {
        private readonly DBCreditos db;

        public GastosController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar Afiliados
        public IActionResult Index()
        {
            IEnumerable<Gastos> listaGastos = db.Gastos
                .Include(afiliado => afiliado.Solicitante);

            return View(listaGastos);
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
        public IActionResult Create(Gastos gastos)
        {
            //Calculo gastos Totales
            gastos.TotalGastos = gastos.Arriendo + gastos.ServiciosBasicos + gastos.Comida + gastos.Transporte + gastos.Educacion + gastos.GastosVarios;

            db.Gastos.Add(gastos);
            db.SaveChanges();

            TempData["mensaje"] = $"Los gastos del solicitante {gastos.SolicitanteId} se ha creado correctamente";

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

            var gastos = db.Gastos
               .Include(soli => soli.Solicitante)
               .Single(afili => afili.GastosId == id);

            return View(gastos);
        }

        //Actualiza DetalleDeudas
        [HttpPost]
        public IActionResult Edit(Gastos gastos)
        {
            //Calculo gastos Totales
            gastos.TotalGastos = gastos.Arriendo + gastos.ServiciosBasicos + gastos.Comida + gastos.Transporte + gastos.Educacion + gastos.GastosVarios;

            db.Gastos.Update(gastos);
            db.SaveChanges();

            TempData["mensaje"] = $"Los gastos del solicitante {gastos.SolicitanteId} se ha editada correctamente";

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

            var gastos = db.Gastos
               .Include(soli => soli.Solicitante)
               .Single(afili => afili.GastosId == id);

            return View(gastos);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(Gastos gastos)
        {
            db.Gastos.Remove(gastos);
            db.SaveChanges();

            TempData["mensaje"] = $"El afiliado se ha eliminado correctamente";

            return RedirectToAction("Index");
        }
    }
}

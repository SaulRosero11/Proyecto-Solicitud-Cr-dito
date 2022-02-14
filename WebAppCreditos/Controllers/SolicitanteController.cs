using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCreditos.Controllers
{
    public class SolicitanteController : Controller
    {
        private readonly DBCreditos db;

        public SolicitanteController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar Rol Pagos
        public IActionResult Index()
        {
            IEnumerable<Solicitante> listaSolicitante = db.Solicitantes;

            return View(listaSolicitante);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Creamos Solicitante
        [HttpPost]
        public IActionResult Create(Solicitante solicitante)
        {
            db.Solicitantes.Add(solicitante);
            db.SaveChanges();

            TempData["mensaje"] = $"El registro ha sido ingresado correctamente exitosamente";

            return RedirectToAction("Index");
        }

        //Edicion de Solicitante
        //Presenta el formulario lleno con los datos del solicitante seleccionada
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Solicitante solicitante = db.Solicitantes.Find(id);

            return View(solicitante);
        }

        //Actualiza Solicitante
        [HttpPost]
        public IActionResult Edit(Solicitante solicitante)
        {
            db.Solicitantes.Update(solicitante);
            db.SaveChanges();

            TempData["mensaje"] = $"El Solicitante {solicitante.Nombres} {solicitante.Apellidos} ha sido actualizada exitosamente";

            return RedirectToAction("Index");
        }

        //Eliminar Solicitante
        //Presenta el formulario lleno con los datos del solicitante seleccionada
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Solicitante solicitante = db.Solicitantes.Find(id);

            return View(solicitante);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(Solicitante solicitante)
        {
            db.Solicitantes.Remove(solicitante);
            db.SaveChanges();

            TempData["mensaje"] = $"El Solicitante ha sido eliminado exitosamente";

            return RedirectToAction("Index");
        }
    }
}

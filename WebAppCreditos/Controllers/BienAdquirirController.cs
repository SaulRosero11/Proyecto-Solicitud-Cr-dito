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
    public class BienAdquirirController : Controller
    {
        private readonly DBCreditos db;

        public BienAdquirirController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar BienAdquirir
        public IActionResult Index()
        {
            IEnumerable<BienAdquirir> listaBienAdquirir = db.BienAdquirirs;

            return View(listaBienAdquirir);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Creamos Solicitante
        [HttpPost]
        public IActionResult Create(BienAdquirir bien)
        {
            //Aprobacion del Bien
            if (bien.PagoIMP == PagoImp.Si && bien.Hipoteca == Hipoteca.No && bien.Escrituras == Escrituras.Si)
            {
                bien.EstadoBien = EstadoBien.Aprovado;
            }
            else
            {
                bien.EstadoBien = EstadoBien.Reporbado;
            }

            db.BienAdquirirs.Add(bien);
            db.SaveChanges();

            TempData["mensaje"] = $"El registro ha sido ingresado correctamente exitosamente";

            return RedirectToAction("Index");
        }

        //Edicion de Solicitante
        //Presenta el formulario lleno con los datos 
        [HttpGet]
        public IActionResult Edit(int id)
        {
            BienAdquirir bien = db.BienAdquirirs.Find(id);

            return View(bien);
        }

        //Actualiza 
        [HttpPost]
        public IActionResult Edit(BienAdquirir bien)
        {
            //Aprobacion del Bien
            if (bien.PagoIMP == PagoImp.Si && bien.Hipoteca == Hipoteca.No && bien.Escrituras == Escrituras.Si)
            {
                bien.EstadoBien = EstadoBien.Aprovado;
            }
            else
            {
                bien.EstadoBien = EstadoBien.Reporbado;
            }

            db.BienAdquirirs.Update(bien);
            db.SaveChanges();

            TempData["mensaje"] = $"La propiedad de {bien.Propietario} ha sido actualizada exitosamente";

            return RedirectToAction("Index");
        }

        //Eliminar Solicitante
        //Presenta el formulario lleno con los datos 
        [HttpGet]
        public IActionResult Delete(int id)
        {
            BienAdquirir bien = db.BienAdquirirs.Find(id);

            return View(bien);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(BienAdquirir bien)
        {
            db.BienAdquirirs.Remove(bien);
            db.SaveChanges();

            TempData["mensaje"] = $"El Solicitante ha sido eliminado exitosamente";

            return RedirectToAction("Index");
        }
    }
}

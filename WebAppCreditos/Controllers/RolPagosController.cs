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
    public class RolPagosController : Controller
    {
        private readonly DBCreditos db;

        public RolPagosController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar Rol Pagos
        public IActionResult Index()
        {
            IEnumerable<RolPagos> listaRolPagos = db.RolPagos
                .Include(afiliado => afiliado.Solicitante);

            return View(listaRolPagos);
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
        public IActionResult Create(RolPagos rol)
        {
            //Calculo Total Ingresos
            rol.AporteIESS = rol.Sueldo - (rol.Sueldo * 0.945f);
            rol.TotalIngresos = rol.Sueldo - (rol.AporteIESS + rol.PrestamosIESS + rol.Anticipo);

            db.RolPagos.Add(rol);
            db.SaveChanges();

            TempData["mensaje"] = $"E Rol de pagos del solicitante {rol.SolicitanteId} se ha creado correctamente";

            return RedirectToAction("Index");
        }

        //Edicion de Rol Pagos
        //Presenta el formulario lleno con los datos del RolPagos
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

            var rol = db.RolPagos
               .Include(soli => soli.Solicitante)
               .Single(afili => afili.RolPagosId == id);

            return View(rol);
        }

        //Actualiza DetalleDeudas
        [HttpPost]
        public IActionResult Edit(RolPagos rol)
        {
            //Calculo Total Ingresos
            rol.AporteIESS = rol.Sueldo - rol.Sueldo * 0.945f;
            rol.TotalIngresos = rol.Sueldo - (rol.AporteIESS + rol.PrestamosIESS + rol.Anticipo);

            db.RolPagos.Update(rol);
            db.SaveChanges();

            TempData["mensaje"] = $"El Rol de Pagos del solicitante {rol.SolicitanteId} se ha editada correctamente";

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

            var rol = db.RolPagos
               .Include(soli => soli.Solicitante)
               .Single(afili => afili.RolPagosId == id);

            return View(rol);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(RolPagos rol)
        {
            db.RolPagos.Remove(rol);
            db.SaveChanges();

            TempData["mensaje"] = $"El afiliado se ha eliminado correctamente";

            return RedirectToAction("Index");
        }
    }
}

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
    public class CapacidadPagosController : Controller
    {
        private readonly DBCreditos db;

        public CapacidadPagosController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar Capcidad Pagos
        public IActionResult Index()
        {
            IEnumerable<CapacidadPago> listaCapacidadPago = db.CapacidadPagos
                .Include(rol => rol.RolPagos)
                    .ThenInclude(sol => sol.Solicitante);

            return View(listaCapacidadPago);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Lista de RoldePagos
            var listaRol = db.RolPagos
                .Include(sol => sol.Solicitante)
                .Select(Rol => new
                {
                    RolPagosId = Rol.RolPagosId,
                    Nombres = Rol.Solicitante.Nombres,
                    Apellidos = Rol.Solicitante.Apellidos
                }).ToList();
            // Lista de Gastos
            var listaGastos = db.Gastos
                .Include(sol => sol.Solicitante)
                .Select(gas => new
                {
                    GastosId = gas.GastosId,
                    Nombres = gas.Solicitante.Nombres,
                    Apellidos = gas.Solicitante.Apellidos
                }).ToList();
            // Lista de Declaracion Imp
            var listaDeImp = db.DeclaracionImps
                .Include(sol => sol.Solicitante)
                .Select(dec => new
                {
                    DeclaracionId = dec.DeclaracionImpId,
                    Nombres = dec.Solicitante.Nombres,
                    Apellidos = dec.Solicitante.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaRol = new SelectList(listaRol, "RolPagosId", "Nombres", "Apellidos");
            var selectListaDecla = new SelectList(listaDeImp, "DeclaracionId", "Nombres", "Apellidos");
            var selectListaGastos = new SelectList(listaGastos, "GastosId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListRol = selectListaRol;
            ViewBag.selectListDecla = selectListaDecla;
            ViewBag.selectListGastos = selectListaGastos;

            return View();
        }

        [HttpPost]
        public IActionResult Create(CapacidadPago capacidad)
        {
            //Consulta delcaracion
            var tmpdec = db.DeclaracionImps
                .Single(dec => dec.DeclaracionImpId == capacidad.DeclaracionImpId);

            capacidad.Declaracion = tmpdec.TotalIngresos;

            //Consulta RolPagos
            var tmpRol = db.RolPagos
                .Single(rol => rol.RolPagosId == capacidad.RolPagosId);

            capacidad.RolPagosTotal = tmpRol.TotalIngresos;

            //Consulta Gastos
            var tmpGastos = db.Gastos
                .Single(gas => gas.GastosId == capacidad.GastosId);

            capacidad.GastosTotal = tmpGastos.TotalGastos;

            //Calculo total de la capcidad pago
            capacidad.CapcidadPago = (capacidad.Declaracion + capacidad.RolPagosTotal) - capacidad.GastosTotal;

            db.CapacidadPagos.Add(capacidad);
            db.SaveChanges();

            TempData["mensaje"] = $"La capacida de pago se ha creado correctamente";

            return RedirectToAction("Index");
        }

        //Edicion de BieneSolicitante
        //Presenta el formulario lleno con los datos del Bien
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Lista de RoldePagos
            var listaRol = db.RolPagos
                .Include(sol => sol.Solicitante)
                .Select(Rol => new
                {
                    RolPagosId = Rol.RolPagosId,
                    Nombres = Rol.Solicitante.Nombres,
                    Apellidos = Rol.Solicitante.Apellidos
                }).ToList();
            // Lista de Gastos
            var listaGastos = db.Gastos
                .Include(sol => sol.Solicitante)
                .Select(gas => new
                {
                    GastosId = gas.GastosId,
                    Nombres = gas.Solicitante.Nombres,
                    Apellidos = gas.Solicitante.Apellidos
                }).ToList();
            // Lista de Declaracion Imp
            var listaDeImp = db.DeclaracionImps
                .Include(sol => sol.Solicitante)
                .Select(dec => new
                {
                    DeclaracionId = dec.DeclaracionImpId,
                    Nombres = dec.Solicitante.Nombres,
                    Apellidos = dec.Solicitante.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaRol = new SelectList(listaRol, "RolPagosId", "Nombres", "Apellidos");
            var selectListaDecla = new SelectList(listaDeImp, "DeclaracionId", "Nombres", "Apellidos");
            var selectListaGastos = new SelectList(listaGastos, "GastosId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListRol = selectListaRol;
            ViewBag.selectListDecla = selectListaDecla;
            ViewBag.selectListGastos = selectListaGastos;

            var CapPago = db.CapacidadPagos
                .Include(rol => rol.RolPagos)
                    .ThenInclude(sol => sol.Solicitante)
                .Single(afili => afili.CapacidadPagoId == id);

            return View(CapPago);
        }

        //Actualiza BienSolicitante
        [HttpPost]
        public IActionResult Edit(CapacidadPago capacidad)
        {
            //Consulta delcaracion
            var tmpdec = db.DeclaracionImps
                .Single(dec => dec.DeclaracionImpId == capacidad.DeclaracionImpId);

            capacidad.Declaracion = tmpdec.TotalIngresos;

            //Consulta RolPagos
            var tmpRol = db.RolPagos
                .Single(rol => rol.RolPagosId == capacidad.RolPagosId);

            capacidad.RolPagosTotal = tmpRol.TotalIngresos;

            //Consulta Gastos
            var tmpGastos = db.Gastos
                .Single(gas => gas.GastosId == capacidad.GastosId);

            capacidad.GastosTotal = tmpGastos.TotalGastos;

            //Calculo total de la capcidad pago
            capacidad.CapcidadPago = (capacidad.Declaracion + capacidad.RolPagosTotal) - capacidad.GastosTotal;

            db.CapacidadPagos.Update(capacidad);
            db.SaveChanges();

            TempData["mensaje"] = $"La capacidad de pago se ha editado correctamente";

            return RedirectToAction("Index");
        }

        //Eliminar Bien
        //Presenta el formulario lleno con los datos del bien seleccionado
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Lista de RoldePagos
            var listaRol = db.RolPagos
                .Include(sol => sol.Solicitante)
                .Select(Rol => new
                {
                    RolPagosId = Rol.RolPagosId,
                    Nombres = Rol.Solicitante.Nombres,
                    Apellidos = Rol.Solicitante.Apellidos
                }).ToList();
            // Lista de Gastos
            var listaGastos = db.Gastos
                .Include(sol => sol.Solicitante)
                .Select(gas => new
                {
                    GastosId = gas.GastosId,
                    Nombres = gas.Solicitante.Nombres,
                    Apellidos = gas.Solicitante.Apellidos
                }).ToList();
            // Lista de Declaracion Imp
            var listaDeImp = db.DeclaracionImps
                .Include(sol => sol.Solicitante)
                .Select(dec => new
                {
                    DeclaracionId = dec.DeclaracionImpId,
                    Nombres = dec.Solicitante.Nombres,
                    Apellidos = dec.Solicitante.Apellidos
                }).ToList();

            // Prepara las listas
            var selectListaRol = new SelectList(listaRol, "RolPagosId", "Nombres", "Apellidos");
            var selectListaDecla = new SelectList(listaDeImp, "DeclaracionId", "Nombres", "Apellidos");
            var selectListaGastos = new SelectList(listaGastos, "GastosId", "Nombres", "Apellidos");

            // Ingreso a ViewBag
            ViewBag.selectListRol = selectListaRol;
            ViewBag.selectListDecla = selectListaDecla;
            ViewBag.selectListGastos = selectListaGastos;

            var CapPago = db.CapacidadPagos
                 .Include(rol => rol.RolPagos)
                     .ThenInclude(sol => sol.Solicitante)
                 .Single(afili => afili.CapacidadPagoId == id);

            return View(CapPago);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(CapacidadPago capacidad)
        {
            db.CapacidadPagos.Remove(capacidad);
            db.SaveChanges();

            TempData["mensaje"] = $"El Bien se ha eliminado correctamente";

            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Modelo.Operaciones;
using ModeloDB;
using Proceso;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Procesos;

namespace WebAppCreditos.Controllers
{
    public class AmortizacionController : Controller
    {
        private readonly DBCreditos db;

        public AmortizacionController(DBCreditos db)
        {
            this.db = db;
        }

        //Listar Amortizacion
        public IActionResult Index()
        {
            //Consulta referenciando solicitante  
            var listaAmortizacion = db.Amortizacion
                .Include(sol => sol.Solicitud_Dets)
                    .ThenInclude(sol => sol.Solicitud)
                        .ThenInclude(afi => afi.Afiliado)
                            .ThenInclude(sol => sol.Solicitante)
                ;
            return View(listaAmortizacion);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Creamos Solicitante
        [HttpPost]
        public IActionResult Create(Amortizacion amor)
        {
            db.Amortizacion.Add(amor);
            db.SaveChanges();

            TempData["mensaje"] = $"El registro ha sido ingresado correctamente exitosamente";

            return RedirectToAction("Index");
        }

        [HttpGet]
        // Pantalla para la validación del credito
        public IActionResult Validar(int id)
        {
            //Consulta referenciando a todas las clases desde amortizacion
            var amortizacionModel = db.Amortizacion
                .Include(solDet => solDet.Solicitud_Dets)
                    .ThenInclude(sol => sol.Solicitud)
                        .ThenInclude(afi => afi.Afiliado)
                            .ThenInclude(solicitante => solicitante.Solicitante)
                .Include(solDet => solDet.Solicitud_Dets)
                    .ThenInclude(sol => sol.Solicitud)
                        .ThenInclude(cap => cap.CapacidadPago)
                            .ThenInclude(de => de.DeclaracionImp)
                .Include(solDet => solDet.Solicitud_Dets)
                    .ThenInclude(sol => sol.Solicitud)
                        .ThenInclude(cap => cap.CapacidadPago)
                            .ThenInclude(gas => gas.Gastos)
                .Include(solDet => solDet.Solicitud_Dets)
                    .ThenInclude(sol => sol.Solicitud)
                        .ThenInclude(cap => cap.CapacidadPago)
                            .ThenInclude(rol => rol.RolPagos)
                .Include(solDet => solDet.Solicitud_Dets)
                    .ThenInclude(sol => sol.Solicitud)
                        .ThenInclude(hist => hist.HistorialCrediticio)
                            .ThenInclude(bien => bien.BienesSolicitante)
                .Include(solDet => solDet.Solicitud_Dets)
                    .ThenInclude(sol => sol.Solicitud)
                        .ThenInclude(hist => hist.HistorialCrediticio)
                            .ThenInclude(det => det.DetalleDeudas)
                .Single(amor => amor.AmortizacionId == id)   // Consulta la Amortizacion id
                ;

            //Consulta para poder extraer Capacidad Pago desde ID
            var modelSolicDet = db.Solicitud_Dets
                .Include(soli => soli.Solicitud)
                    .ThenInclude(cap => cap.CapacidadPago)
                .Single(amor => amor.Amortizacion.AmortizacionId == id);

            // Preparar la clase para el cálculo 
            var configuracion = db.Configuracions.Single();
            var capacidadPago = db.CapacidadPagos
                .Include(soli => soli.Solicituds)
                    .ThenInclude(soldet => soldet.Solicitud_Dets)
                        .ThenInclude(amorti => amorti.Amortizacion)
                .Single(capPago => capPago.CapacidadPagoId == modelSolicDet.Solicitud.CapacidadPago.CapacidadPagoId);

            Calculo Calculo = new Calculo(configuracion, capacidadPago);

            ViewBag.Calculo = Calculo;

            return View(amortizacionModel);
        }

        //Editar
        [HttpPost]
        public IActionResult Validar(Amortizacion amor)
        {
            //Validar 
            ProValidacion pro = new ProValidacion(db);

            if(pro.ValidarCredito(amor.AmortizacionId) == true)
            {
                amor.Estado = Estado.Aprobada;
                TempData["mensaje"] = $"Felicidades su crédito a sido Aprobado.";
            }
            else
            {
                amor.Estado = Estado.Rechazada;
                TempData["mensaje"] = $"Lo sentimos su crédito fue Rechazado.";
            }

            db.Amortizacion.Update(amor);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Amortizacion amortizacion = db.Amortizacion.Find(id);

            return View(amortizacion);
        }

        //Confirmar eliminacion
        [HttpPost]
        public IActionResult Delete(Amortizacion amor)
        {
            db.Amortizacion.Remove(amor);
            db.SaveChanges();

            TempData["mensaje"] = $"El registro se ha sido eliminado exitosamente";

            return RedirectToAction("Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjercicioCoches.Models;

namespace EjercicioCoches.Controllers
{
    public class ConductoresController : Controller
    {

        VehiculosEntities db=new VehiculosEntities();
        // GET: Conductores
        public ActionResult Detalle(int id)
        {
            var c = db.Conductor.Find(id);

            return View(c);
        }

        public ActionResult DetalleAjax(int id)

        {

            db.Configuration.LazyLoadingEnabled = false;
            var c = db.Conductor.Find(id);

            return Json(c,JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pet.Entity;
using System.Data;
using Pet.Service;
using Pet.Entity;

using log4net;
using Pet.Service.MANTENIMIENTO;

namespace Pet.Web.Controllers
{
    public class SolicitudMantenimientoController : Controller
    {
        //
        // GET: /SolicitudMantenimiento/
        //Log4Net
        public log4net.ILog log;

        public SolicitudMantenimientoController()
        {
            log = log4net.LogManager.GetLogger("LogSolicitudMantenimiento");
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult listarSolicitudMantenimiento(Nullable<int> codigoSolicitud, string descripcion, Nullable<int> codigoTipoMantenimiento, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<int> estado, Nullable<int> codigoSede, Nullable<int> codigoArea)
        {
            //log.Info("Function: [listarSolicitudMantenimiento("+p_codSol+","+p_desc+","+p_codTipMant+","+p_fecini+","+p_fecfin+","+p_estado+","+p_codSede+","+p_codArea+")] ");

            return Json(SolicitudMantenimiento.ConsultarSolicitud(codigoSolicitud, descripcion, codigoTipoMantenimiento, fechaInicio, fechaFin, estado, codigoSede, codigoArea), JsonRequestBehavior.AllowGet);
        }


        public ActionResult Adicionar()
        {
            return View();
        }




    }
}

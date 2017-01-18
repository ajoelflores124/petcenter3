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
        public JsonResult listarSolicitudMantenimiento(int p_codSol,String p_desc ,int p_codTipMant, String p_fecini, String p_fecfin, String p_estado, String p_codSede,String p_codArea   )
        {
            log.Info("Function: [listarSolicitudMantenimiento("+p_codSol+","+p_desc+","+p_codTipMant+","+p_fecini+","+p_fecfin+","+p_estado+","+p_codSede+","+p_codArea+")] ");
            return Json(SolicitudMantenimiento.ConsultarSolicitud (), JsonRequestBehavior.AllowGet);
        }




    }
}

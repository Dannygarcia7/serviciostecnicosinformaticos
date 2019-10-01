using ServiciosTecnicosBL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiciosTecnicos.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var listadeproductos = productosBL.ObtenerProductosActivos();


            ViewBag.AdminWebSiteUrl = ConfigurationManager.AppSettings["AdminWebSiteUrl"];

            return View(listadeproductos);
        }
    }
}
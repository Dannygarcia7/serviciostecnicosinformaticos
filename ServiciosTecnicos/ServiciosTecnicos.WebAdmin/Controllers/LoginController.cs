using ServiciosTecnicosBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ServiciosTecnicos.WebAdmin.Controllers
{
    public class LoginController : Controller
    {
        SeguridadBL _seguridadBL;

        public LoginController()
        {
            _seguridadBL = new SeguridadBL();
        }


        // GET: Login
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            return View();
        }


        [HttpPost]
        public ActionResult Index(FormCollection data)
        {

            var NombreUsuario = data["username"];
            var contrasena = data["password"];
            var usuarioValido =  _seguridadBL.Autorizar(NombreUsuario, contrasena);

            if (usuarioValido)
            {
                FormsAuthentication.SetAuthCookie(NombreUsuario,true);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("","Usuario o Contraseña no Valida");

            return View();
            
        }
    }
}
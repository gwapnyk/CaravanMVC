using CaravanMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using CaravanBLL;
using Model;

namespace CaravanMVC.Controllers
{
    public class RegistrarController : Controller
    {
        Usuario objUsuario;

        // GET: Registrar
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registrar(Registrar registro) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    objUsuario = new Usuario();


                    //chamar a BLL para cadastrar
                    objUsuario.Registrar(registro.UsuarioModel);


                    ModelState.Clear();
                    registro = null;
                }
                return View("Index", registro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
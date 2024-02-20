using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ReTurnoWeb_.Models;

namespace ReTurnoWeb_.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: UsuarioController
        public ActionResult Index()
        {
            return View("~/Views/Usuario/Index.cshtml", ProgramSession.logueado);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            Usuario usr = new Usuario();
            usr = Usuario_Controller.obtenerPorId(id);
            return View("~/Views/Usuario/Edit.cshtml", usr);
        }

        public ActionResult UpdateUser (String telefono, String mail, String pwd)
        {
            ProgramSession.logueado.Telefono = telefono;
            ProgramSession.logueado.Email = mail;
            ProgramSession.logueado.Contrasenia = pwd;
            Usuario_Controller.editarUsuario(ProgramSession.logueado);
            ProgramSession.logueado = Usuario_Controller.obtenerPorId(ProgramSession.logueado.Id);
            return View("~/Views/Usuario/Index.cshtml", ProgramSession.logueado);
        }

        public ActionResult EditDireccion(int id)
        {
            Usuario usr = new Usuario();
            usr = Usuario_Controller.obtenerPorId(id);
            return View("~/Views/Direccion/Edit.cshtml", usr);
        }

        public ActionResult UpdateDireccion(String provincia, String ciudad, String calle, String altura, String piso, String departamento, String codpos)
        {
            ProgramSession.logueado.Direccion.Provincia = provincia;
            ProgramSession.logueado.Direccion.Ciudad=ciudad;
            ProgramSession.logueado.Direccion.Calle = calle;
            ProgramSession.logueado.Direccion.Altura = int.Parse(altura);
            ProgramSession.logueado.Direccion.Piso = int.Parse(piso);
            ProgramSession.logueado.Direccion.Departamento = departamento;
            ProgramSession.logueado.Direccion.CodigoPostal = codpos;
            Direccion_Controller.editarDireccion(ProgramSession.logueado.Direccion, calle, int.Parse(altura), codpos, int.Parse(piso), provincia, ciudad, departamento);
            ProgramSession.logueado = Usuario_Controller.obtenerPorId(ProgramSession.logueado.Id);
            return View("~/Views/Usuario/Index.cshtml", ProgramSession.logueado);
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

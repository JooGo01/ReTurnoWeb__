using Microsoft.AspNetCore.Mvc;

using ReTurnoWeb_.Models;
using ReTurnoWeb_.Recursos;
using ReTurnoWeb_.Servicios.Contrato;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Abstractions;

namespace ReTurnoWeb_.Controllers
{
    public class InicioController : Controller
    {
        private readonly IUsuario _usuarioServicio;
        public InicioController(IUsuario p_usuarioServicio) {
            _usuarioServicio = p_usuarioServicio;

        }
        public IActionResult Registrarse()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrarse(Usuario p_usuario)
        {
            //esto es para enctriptar la contraseña
            //p_usuario.Contrasenia = Utilidades.EncriptarClave(p_usuario.Contrasenia);

            Usuario usuario_creado = await _usuarioServicio.GuardarUsuario(p_usuario);
            if (usuario_creado.Id > 0) {
                return RedirectToAction("IniciarSesion", "Inicio");
            }

            ViewData["Mensaje"] = "No se pudo crear el usuario";

            return View();
        }

        public IActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IniciarSesion(String mail, String pwd)
        {
            //si utilizamos la encriptacion del pwd del usuario
            //Usuario usuario_login = await _usuarioServicio.GetUsuario(mail, Utilidades.EncriptarClave(pwd));
            Usuario usuario_login = await _usuarioServicio.GetUsuario(mail, pwd);
            if (usuario_login == null)
            {
                ViewData["Mensaje"] = "No se encontraron coincidencias";
                return View();
            }

            List<Claim> listClaims = new List<Claim>() {
                new Claim(ClaimTypes.Name, usuario_login.Nombre)
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(listClaims, CookieAuthenticationDefaults.AuthenticationScheme);
            AuthenticationProperties propiedades = new AuthenticationProperties() {
                AllowRefresh = true
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                propiedades
                );

            return RedirectToAction("Index", "Home");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReTurnoWeb_.Models;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReTurnoWeb_.Controllers
{
    public class TurnoController : Controller
    {
        // GET: Turno_Controller
        public ActionResult Index()
        {
            List<Turno> listaTurno = new List<Turno>();
            DB_Controller.initialize();
            listaTurno=Calendario_Controller.obtenerPorUsuarioTurnoActivo(DateTime.Now, ProgramSession.logueado);
            return View("~/Views/Turno/Index.cshtml", listaTurno);
        }

        // GET: Turno_Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Turno_Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turno_Controller/Create
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

        // GET: Turno_Controller/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            DB_Controller.initialize();
            Calendario_Controller.bajarTurno(id);
            List<Turno> listaTurno = new List<Turno>();
            listaTurno = Calendario_Controller.obtenerTodos();
            return View("~/Views/Turno/Index.cshtml", listaTurno);
        }

        // POST: Turno_Controller/Edit/5
        /*
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
        */

        // GET: Turno_Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Turno_Controller/Delete/5
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

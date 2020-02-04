using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSGestion.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSGestion.Controllers
{
    public class RegistroSolicitudController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        //public ActionResult Agregar()
        //{ 
        //    var model = new RegistroSolicitudViewModel();

        //    return PartialView(model);
        //}

        public async Task<ActionResult> Agregar()
        {

            var t = await Task.Run(() =>
            {

                var model = new RegistroSolicitudViewModel();

                return model;
            }).ConfigureAwait(false);

            return PartialView(t);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Agregar(RegistroSolicitudViewModel model)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    throw new Exception("error forzado");
                }
                else
                {
                    return PartialView(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Un error cualquiera: " + e.Message);
                model.WithError = true;

                return PartialView(model);
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    //TODO: mtoroc, se recomienda mantener codigo para reutilizarlo en comportamiento estatico de vistas a traves de viewcomponente
    //public class RegistroSolicitudComponent : ViewComponent
    //{
    //    public IViewComponentResult Invoke(string view)
    //    {
    //        var model = new RegistroSolicitudViewModel();

    //        return View(view, model);
    //    }
    //}
}
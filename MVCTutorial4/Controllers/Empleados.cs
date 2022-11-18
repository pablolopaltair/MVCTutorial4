using Microsoft.AspNetCore.Mvc;
using MVCTutorial4.Models;

namespace MVCTutorial4.Controllers
{
    public class Empleados : Controller
    {
        public MVCTutorial4.Models.Tutorial4Context db = new Models.Tutorial4Context();

        public IActionResult Index()
        {
            var empleados = db.Empleados.ToList();
            
            //Almacenaje en ViewBag lista
            ViewBag.Nombre = empleados;

            return View(empleados);
        }
        

      
    }
}

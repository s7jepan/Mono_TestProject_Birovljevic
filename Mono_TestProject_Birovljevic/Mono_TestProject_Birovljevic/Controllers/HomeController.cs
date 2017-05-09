using Project.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mono_TestProject_Birovljevic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var make = new VehicleMake { Name = "BMW", Abrv = "BMW" };
            var model = new VehicleModel { VehicleMakeId = make.Id, Name = "128", Abrv = "128" };

            make.VehicleModels.Add(model);

            var service = new VehicleService();
            service.InsertVehicleMake(make);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
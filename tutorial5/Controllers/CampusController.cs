using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tutorial5.Models;

namespace tutorial5.Controllers
{
    public class CampusController : Controller
    {
        // GET: Campus
         public string Overview()
        {
            return "This page provides an overview of our campus.";
        }

        // GET: Campus/Locations
        public ActionResult Locations()
        {
            var campuses = new List<Campus>
            {
                new Campus { Id = 1, Name = "Main Campus", Location = "123 Main St, Springfield" },
                new Campus { Id = 2, Name = "West Campus", Location = "456 Elm St, Shelbyville" },
                new Campus { Id = 3, Name = "Downtown Campus", Location = "789 Oak St, Capital City" }
            };

            return View(campuses);
        }
    }
}
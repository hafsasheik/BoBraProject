using BoBra_Kund_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BoBra_Kund_MVC.Controllers
{
    public class PropertyController : Controller
    {
        // GET: PropertyController
        public async Task<ActionResult> Index()
        {
            IList<PropertyViewModel> properties = null;

            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://localhost:44392/api/properties");

                if (result.IsSuccessStatusCode)
                {
                    properties = await result.Content.ReadAsAsync<IList<PropertyViewModel>>();
                }
                else
                {
                    return NotFound();
                }
            }

            return View(properties);
        }

        // GET: PropertyController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            PropertyViewModel property = null;

            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://localhost:44392/api/properties/" + id);

                if (result.IsSuccessStatusCode)
                {
                    property = await result.Content.ReadAsAsync<PropertyViewModel>();
                }
                else
                {
                    return NotFound();
                }
            }

            return View(property);
        }

    }
}

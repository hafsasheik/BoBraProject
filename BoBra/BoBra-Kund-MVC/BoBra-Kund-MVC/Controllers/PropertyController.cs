using BoBra_Kund_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BoBra_Kund_MVC.Controllers
{
    public class PropertyController : Controller
    {

        //private iconfiguration _config;
        //private string _apiurl;

        //public propertycontroller(iconfiguration config)
        //{
        //    _config = config;
        //    _apiurl = _config.getvalue<string>("apiurl");
        //}

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

        // POST: BookController/Details/5
        public async Task<ActionResult> Registration(PropertyViewModel property)
        {
            if (!ModelState.IsValid)
            {
                return View("Details", property);
            }

            using var client = new HttpClient();
            var result = await client.PostAsJsonAsync("https://localhost:44392/api/" + "properties/" + property.PropertyID + "/Subscribe", property);

            if (result.IsSuccessStatusCode)
            {
                ViewData["Message"] = "Good job on subscribing!";
                return View("Registered");
            }
            else if (result.StatusCode == HttpStatusCode.Conflict)
            {
                ViewData["Message"] = "You're already subscribed!";
                return View("Registered");
            }

            return NotFound();
        }

    }
}

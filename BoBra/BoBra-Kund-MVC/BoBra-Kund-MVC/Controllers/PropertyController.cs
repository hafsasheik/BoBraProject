using BoBra_Kund_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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

        private readonly IConfiguration _config;
        private readonly string API_URL;

        public PropertyController(IConfiguration config)
        {
            _config = config;
            API_URL = _config.GetValue<string>("API_URL");
        }

        // GET: PropertyController
        public async Task<ActionResult> Index()
        {
            IList<PropertyViewModel> properties = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(API_URL);
                var result = await client.GetAsync(API_URL+"properties");

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
                client.BaseAddress = new Uri(API_URL);
                var result = await client.GetAsync(API_URL + "properties/" + id);

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

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(API_URL);

                var result = await client.PostAsJsonAsync(API_URL + "properties/" + property.PropertyID + "/Subscribe", property);

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
            }

            return NotFound();
        }

    }
}

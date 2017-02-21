using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UsingAutofac.Abstract;

namespace UsingAutofc.Web.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(IRepository<IOrganization> organization, HttpSessionStateBase session)
        {

        }

        public async Task< ActionResult> Index()
        {
            ViewBag.Title = "Home Page";

            HttpClient client = new HttpClient();

            var response = await client.GetAsync("http://localhost/UsingAutofc.Web/api/Values");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsAsync<string[]>();
            }

            return View();
        }
    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Ingrain.Services.Controllers
{
    [Produces("application/json")]
   // [Route("api/Services")]
    public class ServicesController : Controller
    {
        [Route("api/services")]
        public IActionResult Get()
        {
            var listofServices = new List<string>();
            listofServices.Add("DEPLOYMENT");
            listofServices.Add("IT SERVICES");
            listofServices.Add("Implementation");
            listofServices.Add("PROFSERV");
            listofServices.Add("TRAINING");

            // Pending integration with Services , to store data in database
            return Ok(listofServices);
        }

        [Route("api/products")]
        public IActionResult products()
        {
            var listofServices = new List<string>();
            listofServices.Add("EVENT APP");
            listofServices.Add("POLLING PORTAL");
            listofServices.Add("PUSH NOTIFICATION");
            listofServices.Add("PROFSERV");
            listofServices.Add("WEB MIDDLEWARE MONITORING");

            // Pending integration with Services , to store data in database
            return Ok(listofServices);
        }

    }
}
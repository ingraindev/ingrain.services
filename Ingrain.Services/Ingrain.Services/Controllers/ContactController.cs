using Ingrain.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ingrain.Services.Controllers
{
    [Produces("application/json")]
  
    public class ContactController :Controller
    {
        [Route("api/Contact")]
        public IActionResult Get()
        {
            var resp = new Response();
            // Pending integration with Services , to store data in database
            return Ok(resp);
        }

        [HttpPost]
        [Route("api/Contact")]
        public IActionResult Post([FromBody] Employee emp)
        {
            var resp = new Response();
            return Ok(resp);
        }
    }

   
}
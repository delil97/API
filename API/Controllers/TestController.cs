using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            List<string> listOfstrings = new List<string>();
            listOfstrings.Add("Hej");
            listOfstrings.Add("Test");
            listOfstrings.Add("Lista");
            listOfstrings.Add("Test");
            listOfstrings.Add("Hej");

            return Ok(listOfstrings);
        }
    }
}

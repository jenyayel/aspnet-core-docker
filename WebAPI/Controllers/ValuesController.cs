using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("/")]
    public class ValuesController : Controller
    {
        private readonly IHostingEnvironment _environment;

        public ValuesController(IHostingEnvironment environment)
        {
            this._environment = environment;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World", $"from {_environment.EnvironmentName}", "!" };
        }
    }
}

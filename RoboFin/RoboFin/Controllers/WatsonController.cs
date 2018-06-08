using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace RoboFin.Controllers
{

    [Route("api/watson")]
    public class WatsonController : Controller
    {
        private readonly IWatsonService _service;
        private IHostingEnvironment _hostingEnvironment;

        public WatsonController(IWatsonService watsonService, IHostingEnvironment environment)
        {
            _service = watsonService;
            _hostingEnvironment = environment;
        }

        [HttpPost("processMessage")]
        public IActionResult ProcessMessage([FromBody]WatsonModel message, string workSpaceId, string authCredentials)
        {
            return Ok(_service.ProcessMessage(message, _hostingEnvironment.WebRootPath, workSpaceId, authCredentials));
        }
    }
}

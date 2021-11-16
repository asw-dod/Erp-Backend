using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ErpBackend.Models;
using ErpBackend.Repository;
using ErpBackend.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ErpBackend.Controllers.Devices
{
    [ApiController]
    [Route("/devices/arduino")]
    public class ArdunioController : Controller
    {
        private readonly IRepository<ArduinoModel, int> repository;
        private readonly ILogger<ArdunioController> _logger;

        // The Web API will only accept tokens 1) for users, and 2) having the "access_as_user" scope for this API

        public ArdunioController(ILogger<ArdunioController> logger, ErpContext context)
        {
            //this.repository = new ArduinoRepository(context);
            this._logger = logger;

        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Json(new { result = true });
        }

        [HttpGet("{id}/status")]
        public IActionResult GetStatus(string id)
        {
            return Json(new { result = true });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            return Json(new { result = true });
        }

        [HttpPost("{id}/status")]
        public IActionResult PostStatus([FromBody] JsonDocument json, string id)
        {
            return Json(new { result = true });
        }
    }
}

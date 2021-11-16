using System;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace ErpBackend.Controllers.Devices
{
    public partial class RaspberryController : Controller
    {
        [HttpPost("/devices/raspberry/{id}/arduino")]
        public IActionResult PostArduino([FromBody] JsonDocument json, string id)
        {
            return Json(new
            {
                result = id
            });
        }

        [HttpGet("{id}/arduino")]
        public IActionResult GetArduino(string id)
        {
            return Json(new
            {
                result = id
            });
        }

        [HttpDelete("/devices/raspberry/{id}/arduino")]
        public IActionResult DeleteArduino([FromBody] JsonDocument json, string id)
        {
            return Json(new
            {
                result = id
            });
        }

        [HttpGet("/devices/raspberry/{id}/arduino/status")]
        public IActionResult GetArduinoStatus(string id)
        {
            return Json(new
            {
                result = id
            });
        }


    }
}

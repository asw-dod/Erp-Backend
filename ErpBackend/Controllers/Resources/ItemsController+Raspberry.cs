using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ErpBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ErpBackend.Controllers.Resources
{
    [ApiController]
    [Route("/devices/raspberry/")]
    public partial class ItemsController : Controller
    {
        private readonly ErpContext _context;
        private readonly ILogger<ItemsController> _logger;

        public ItemsController(ILogger<ItemsController> logger, ErpContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("{id}/items")]
        public IActionResult Get(long id)
        {
            return Json(new { result = id });
        }

        [HttpPost("{id}/items")]
        public IActionResult ADD(long id)
        {
            return Json(new { result = id });
        }

        [HttpGet("{rasp}/items/{item}")]
        public IActionResult infoItem(string rasp, string item)
        {
            return Json(new { rasp = rasp, item = item });
        }

        [HttpDelete("{rasp}/items")]
        public IActionResult DeleteItem(
            string rasp, [FromBody] JsonDocument json)
        {
            return Json(new { rasp = rasp, item = json});
        }

        [HttpPut("{rasp}/items/{item}")]
        public IActionResult UpdateItem(string rasp, string item)
        {
            return Json(new { rasp = rasp, item = item });
        }

        [HttpDelete("{rasp}/items/{item}")]
        public IActionResult DeleteItem(string rasp, string item)
        {
            return Json(new { rasp = rasp, item = item });
        }


    }
}

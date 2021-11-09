using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ErpBackend.Controllers.Resources
{
    [ApiController]
    [Route("/devices/raspberry/")]
    public class ItemsController : Controller
    {
        private readonly ErpContext _context;
        private readonly ILogger<ItemsController> _logger;

        ///devices/raspberry/{raspberry pi}/items

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

        [HttpGet("{id}/newitems")]
        public IActionResult NewItem(long id)
        {
            var r = new Random();

            var item = new ItemModel
            {
                Count = r.Next(3, 10),
                Description = "wowowowowo",
                ItemCode = r.Next(),
                Name = "차차 아이템!",
                Raspberry = 0,
                Resources = "1213,1222,333",
                Transaction = DateTime.Now.ToString(),
            };

            _context.Items.Add(item);
            _context.SaveChanges();
            //https://localhost:5001/devices/raspberry/1234/newitems            _context.SaveChanges();

            return Json(new { result = _context.Items.OrderBy(item => item.Id).Last() });
        }

    }
}

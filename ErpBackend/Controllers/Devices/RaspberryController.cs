using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ErpBackend.Controllers.Devices
{
    [ApiController]
    public class RaspberryController : ControllerBase
    {

        private readonly TodoContext _context;
        private readonly ILogger<ArdunioController> _logger;

        public RaspberryController(ILogger<ArdunioController> logger, TodoContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("/devices/raspberry")]
        public IEnumerable<Todo> Get()
        {
            _context.Todo.Add(new Todo
            {
                status = "hi!",
                DoneAt = "Doit!",
                context = "AAAA"

            });

            _context.SaveChanges();
            return _context.Todo.ToArray();
        }
    }
}

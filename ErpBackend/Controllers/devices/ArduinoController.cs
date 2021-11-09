using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErpBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ErpBackend.Controllers.Devices
{
    //[ApiController]
    //public class ArdunioController : ControllerBase
    //{
    //    private readonly TodoContext _context;
    //    private readonly ILogger<ArdunioController> _logger;

    //    // The Web API will only accept tokens 1) for users, and 2) having the "access_as_user" scope for this API

    //    public ArdunioController(ILogger<ArdunioController> logger, TodoContext context)
    //    {
    //        _context = context;
    //        _logger = logger;
    //    }

    //    [HttpGet("/devices/arduino")]
    //    public IEnumerable<Todsso> Get()
    //    {
    //        return _context.Todo.ToArray();
    //    }
    //}
}

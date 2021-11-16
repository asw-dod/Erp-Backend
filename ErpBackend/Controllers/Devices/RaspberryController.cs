using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ErpBackend.Models;
using ErpBackend.Repository;
using ErpBackend.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ErpBackend.Controllers.Devices
{
    [ApiController]
    public class RaspberryController : Controller
    {

        private readonly IRepository<RaspberryModel, int> repository;
        private readonly ILogger<RaspberryController> _logger;


        public RaspberryController(ILogger<RaspberryController> logger, ErpContext context)
        {
            this.repository = new RaspberryRepository(context);
            this._logger = logger;
        }


        [HttpGet("/devices/raspberry")]
        public IEnumerable<RaspberryModel> Get()
        {
            _logger.Log(LogLevel.Trace, "hgahaha");
            return repository.Get().ToArray();
        }

        [HttpGet("/devices/raspberry/{id}")]
        public RaspberryModel Get(string id)
        {
            _logger.Log(LogLevel.Trace, "hgahaha");
            return repository.Get().FirstOrDefault(data => data.Uuid == id) ?? new RaspberryModel();
        }

        [HttpPost("/devices/raspberry")]
        public IActionResult eeeee([FromBody] JsonDocument json)
        {
            return Json(new
            {
                result = "wowowow!"
            });
        }

        [HttpPut("/devices/raspberry/{id}")]
        public IActionResult Post([FromBody] JsonDocument json, string id)
        {
            return Json(new
            {
                result = id
            });
        }

        [HttpDelete("/devices/raspberry/{id}")]
        public IActionResult Delete(string id)
        {
            if (int.TryParse(id, out int num))
            {
                if (repository.Delete(num) == true) {

                    return Json(new
                    {
                        result = true
                    });
                }
                else
                {
                    return Json(new
                    {
                        result = false,
                        code = "1:해당 라즈베리파이 아이디는 존재하지 않습니다."
                    });
                }
            }
            else
            {
                return Json(new
                {
                    result = false,
                    code = "0:URL에서 숫자가 아닌, 문자열이 입력 되었습니다."
                });
            }
        }

        [HttpPost("/devices/raspberry/{id}/status")]
        public IActionResult UpdateStatus([FromBody] JsonDocument json, string id)
        {
            return Json(new
            {
                result = true
            });
        }

        [HttpGet("/devices/raspberry/{id}/status")]
        public IActionResult GetStatus(string id)
        {
            return Json(new
            {
                result = true
            });
        }


    }
}

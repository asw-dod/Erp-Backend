using System;
using System.Collections.Generic;
using System.Linq;
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

        [HttpPut("/devices/raspberry/{id}")]
        public IActionResult Post(string id)
        {
            return Json(new
            {
                result = id
            });
        }

        [HttpPost("/devices/raspberry")]
        public IActionResult eeeee(string json)
        {
            //Request.BodyReader.
            return Json(new
            {
                result = json
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
    }
}

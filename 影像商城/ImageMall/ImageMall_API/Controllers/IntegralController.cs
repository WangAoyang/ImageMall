using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace ImageMall_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegralController : ControllerBase
    {

        private readonly IIntegralService _integralService;

        public IntegralController(IIntegralService integralService)
        {
            _integralService = integralService;
        }

        [HttpGet]
        public List<Integral> GetIntegral()
        {
            var list = _integralService.Index();
            return list;
        }
    }
}
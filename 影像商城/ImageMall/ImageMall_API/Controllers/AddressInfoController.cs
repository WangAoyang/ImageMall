using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace ImageMall_API.Controllers
{
    /// <summary>
    /// 地址
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AddressInfoController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IAddressInfoService _addressInfoService;

        public AddressInfoController(IAddressInfoService addressInfoService)
        {
            _addressInfoService = addressInfoService;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost("Add")]
        public int Add(AddressInfo addressInfo)
        {
            int i = _addressInfoService.Insert(addressInfo);
            return i;
        }

        [HttpGet]
        public List<AddressInfo> GetAddressInfo()
        {
            var list = _addressInfoService.Index();
            return list;
        }
    }
}
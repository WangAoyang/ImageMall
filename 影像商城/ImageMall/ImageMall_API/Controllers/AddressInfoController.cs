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
        /// <param name="addressInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public int Add(AddressInfo addressInfo)
        {
            int i = _addressInfoService.Insert(addressInfo);
            return i;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<AddressInfo> GetAddressInfo()
        {
            var list = _addressInfoService.Index();
            return list;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpDelete]
        public int Delete(int ids)
        {
            var i = _addressInfoService.Delete(ids);
            return i;
        }
        
        //[HttpPut]
        //public AddressInfo Find(int id)
        //{
        //    var i = _addressInfoService.GetModelById(id);
        //    return i;
        //}

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="addressInfo"></param>
        /// <returns></returns>
        [HttpPut]
        public int Update(AddressInfo addressInfo)
        {
            var i = _addressInfoService.Update(addressInfo);
            return i;
        }
    }
}
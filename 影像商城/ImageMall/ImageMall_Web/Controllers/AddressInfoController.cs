using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IService;
using Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;

namespace ImageMall_Web.Controllers
{
    public class AddressInfoController : Controller
    {
        private readonly IAddressInfoService _addressInfoService;

        public AddressInfoController(IAddressInfoService addressInfoService)
        {
            _addressInfoService = addressInfoService;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        public IActionResult Adds()
        {
            return View();
        }
        public JsonResult Add(AddressInfo addressInfo)
        {
            string jsonm = Newtonsoft.Json.JsonConvert.SerializeObject(addressInfo);
            var result = HelperHttpClient.GetAll("post", "/api/addressInfo", jsonm);
            return Json(result);
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

        public IActionResult Update()
        {
            var result = HelperHttpClient.GetAll("post", "/api/addressInfo");
            return View();
        }
    }
}
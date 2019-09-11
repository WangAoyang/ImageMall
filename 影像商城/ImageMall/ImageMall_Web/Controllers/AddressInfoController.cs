using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace ImageMall_Web.Controllers
{
    public class AddressInfoController : Controller
    {
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
    }
}
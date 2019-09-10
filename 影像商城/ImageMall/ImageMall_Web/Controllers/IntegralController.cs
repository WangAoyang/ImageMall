using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Service;

namespace ImageMall_Web.Controllers
{
    public class IntegralController : Controller
    {
        public IActionResult Index()
        {
            //DataDbContext context = new DataDbContext();

            //var list = context.Integral.Include("Picture").ToList();


            //var query13 = from s in context.Integral
            //              join c in context.Picture on s.PictureId equals c.Id
            //              select new
            //              {
            //                  照片 = c.PictureUrl,
            //                  标题= s.IntegralName,
            //                  积分数= s.NeedIntegral,
            //                  原市场价格= s.OriginalPrice
            //              };
            //return View(query13);

            return View();
        }
    }
}
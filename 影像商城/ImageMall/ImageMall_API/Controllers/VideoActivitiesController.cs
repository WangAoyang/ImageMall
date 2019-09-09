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
    [Route("api/[controller]")]
    [ApiController]
    public class VideoActivitiesController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IVideoActivities _videoActivities;

        public VideoActivitiesController(IVideoActivities videoActivities)
        {
            _videoActivities = videoActivities;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost("Add")]
        public int Add(Activity activity)
        {
            int i = _videoActivities.Insert(activity);
            return i;
        }

        [HttpGet]
        public List<Activity> GetActivities()
        {
            var list = _videoActivities.Index();
            return list;
        }
    }
}
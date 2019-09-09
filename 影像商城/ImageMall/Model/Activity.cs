using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 活动表
    /// </summary>
    public class Activity: BaseEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        public string ActivityName { get; set; }

        /// <summary>
        /// 出发地
        /// </summary>
        public string Starting { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string ContactType { get; set; }

        /// <summary>
        /// 活动天数
        /// </summary>
        public string ActivityDays { get; set; }

        /// <summary>
        /// 集合地点(犯罪地点)
        /// </summary>
        public string Venue { get; set; }

        /// <summary>
        /// 报名时间截止(到期时间)
        /// </summary>
        public DateTime Deadline { get; set; }

        /// <summary>
        /// 出行时间
        /// </summary>
        public DateTime TravelTime { get; set; }

        /// <summary>
        /// 已报名名额(已注册的)
        /// </summary>
        public int Registered { get; set; }

        /// <summary>
        /// 总名额
        /// </summary>
        public int Places { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Intro { get; set; }

        /// <summary>
        /// 行程详情
        /// </summary>
        public string Journey { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }

    }
}

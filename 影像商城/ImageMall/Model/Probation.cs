using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// 试用表
    /// </summary>
    public class Probation: BaseEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        public decimal MarketPrice { get; set; }

        /// <summary>
        /// 会员价
        /// </summary>
        public decimal MemberPrice { get; set; }

        /// <summary>
        /// 限购数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 积分限制
        /// </summary>
        public int Integral { get; set; }

        /// <summary>
        /// 物品类别Id
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// 图片Id
        /// </summary>
        public int PictureId { get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        public DateTime Deadline { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public string Particulars { get; set; }

        /// <summary>
        /// 商品简介
        /// </summary>
        public string Intro { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }


    }
}

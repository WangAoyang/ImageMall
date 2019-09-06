using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Seckill
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
        /// 秒杀价
        /// </summary>
        public decimal MemberPrice { get; set; }

        /// <summary>
        /// 限量
        /// </summary>
        public int Sales { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Surplus { get; set; }

        /// <summary>
        /// 店铺Id
        /// </summary>
        public int DictionariesId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Integral
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 积分名称
        /// </summary>
        public string IntegralName { get; set; }

        /// <summary>
        /// 原市场价格
        /// </summary>
        public decimal OriginalPrice { get; set; }

        /// <summary>
        /// 所需积分
        /// </summary>
        public int NeedIntegral { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        public int Sales { get; set; }

        /// <summary>
        /// 库存量
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// 店铺Id
        /// </summary>
        public int StoreId { get; set; }

        /// <summary>
        /// 服务
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// 图片Id
        /// </summary>
        public int PictureId { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public string Particulars { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }


    }
}

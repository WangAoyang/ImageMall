using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 主数据表
    /// </summary>
    public class MasterInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        public decimal MarketPrice { get; set; }

        /// <summary>
        /// 会员价
        /// </summary>
        public decimal MemberPrice { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        public int Sales { get; set; }

        /// <summary>
        /// 剩余库存量
        /// </summary>
        public int Surplus { get; set; }

        /// <summary>
        /// 品牌Id
        /// </summary>
        public int BrandId { get; set; }

        /// <summary>
        /// 商铺Id
        /// </summary>
        public int DictionariesId { get; set; }

        /// <summary>
        /// 服务
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// 
        /// 图片Id 
        /// </summary>
        public int PictureId { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public string Particulars { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        public string TypeInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
         


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 申请表
    /// </summary>
    public class Application
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
        /// 商品类别Id
        /// </summary>
        public int TypeInfoId { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int ShopNumber { get; set; }

        /// <summary>
        /// 商品店铺Id(字典)
        /// </summary>
        public int DictionariesId { get; set; }

        /// <summary>
        /// 交易状态Id
        /// </summary>
        public int CurrencyType { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
    }
}

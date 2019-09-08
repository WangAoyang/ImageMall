using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class Indent
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
        /// 商品类型Id
        /// </summary>
        public int TypeInfoId { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Surplus { get; set; }

        /// <summary>
        /// 商品店铺Id(字典表)
        /// </summary>
        public int DictionariesId { get; set; }

        /// <summary>
        /// 交易(金额/积分)
        /// </summary>
        public decimal Currency { get; set; }

        /// <summary>
        /// 交易状态Id
        /// </summary>
        public int CurrencyTypeId { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 租赁表
    /// </summary>
    public class Lease: BaseEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>',,
        public string ShopName { get; set; }

        /// <summary>
        /// 押金
        /// </summary>
        public decimal Pledge { get; set; }

        /// <summary>
        /// 租用费
        /// </summary>
        public decimal Charges { get; set; }

        /// <summary>
        /// 店铺Id
        /// </summary>
        public int StoreId { get; set; }

        /// <summary>
        /// 租用联系人
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 租用人联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 其他信息
        /// </summary>
        public string Information { get; set; }

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

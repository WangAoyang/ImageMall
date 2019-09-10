using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 购物车
    /// </summary>
    public class Shopping: BaseEntity
    {
        /// <summary>
        /// 购物车Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 主数据Id
        /// </summary>
        public int Masterd { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 主表Id
        /// </summary>
        public int UserId { get; set; }


    }
}

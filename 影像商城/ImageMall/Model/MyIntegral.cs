using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 我的积分
    /// </summary>
   public  class MyIntegral: BaseEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 总积分
        /// </summary>
        public int IntegralCount { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime ExpendTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 支出/收入
        /// </summary>
        public int ExpendIntegral { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }


    }
}

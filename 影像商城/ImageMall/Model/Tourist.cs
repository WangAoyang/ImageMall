using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tourist
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 景点名称
        /// </summary>
        public string TouristName { get; set; }

        /// <summary>
        /// 景点信息
        /// </summary>
        public string TouristMessage { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 交易币(金额/积分)
        /// </summary>
        public decimal Currency { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        public int CurrencyType { get; set; }

    }
}

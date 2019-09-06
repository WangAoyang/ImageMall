using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// 热门搜素
    /// </summary>
    public class Search
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 热门名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商品类别ID
        /// </summary>
        public int TypeInfoId { get; set; }
    }
}

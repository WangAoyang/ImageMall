using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// 图片表
    /// </summary>
   public class Picture : BaseEntity
    {
        /// <summary>
        /// 图片表编号
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// 主数据Id
        /// </summary>
        public int MasterId { get; set; }

        /// <summary>
        /// 缩略图Url
        /// </summary>
        public string BreviaryUrl { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 咨询表
    /// </summary>
    public class Information : BaseEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 咨询名称
        /// </summary>
        public string InformationName { get; set; }

        /// <summary>
        /// 咨询类别名称
        /// </summary>
        public int InformationTypeId { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 图片Id
        /// </summary>
        public int PictureId { get; set; }

        /// <summary>
        /// 详细咨询介绍Id
        /// </summary>
        public int VerboseId { get; set; }

    }
}

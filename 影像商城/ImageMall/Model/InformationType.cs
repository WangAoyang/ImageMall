using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// 咨询类别表
    /// </summary>
    public class InformationType : BaseEntity
    {
        /// <summary>
        /// 咨询ID
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 咨询名称
        /// </summary>
        public string informationName { get; set; }

    }
}

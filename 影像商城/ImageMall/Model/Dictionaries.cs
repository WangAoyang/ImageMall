using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// 字典表
    /// </summary>
    public class Dictionaries : BaseEntity
    {
        /// <summary>
        /// 字典编号
        /// </summary>
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// 类别Id
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// 字典名称
        /// </summary>
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// 字典类型表
    /// </summary>
    public class DictionariesType
    {
        /// <summary>
        /// 字典类别表Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 字典类别名称
        /// </summary>
        public string Name { get; set; }

    }
}

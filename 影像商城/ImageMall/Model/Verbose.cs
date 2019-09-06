using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Verbose
    {
        /// <summary>
        /// 详细咨询ID
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 详细咨询内容
        /// </summary>
        public string VerboseName { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }
    }
}

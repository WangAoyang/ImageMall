using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Evaluate
    {
        /// <summary>
        /// 评价Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 评价内容
        /// </summary>
        public string EvaluateName { get; set; }

        /// <summary>
        /// 父级Id
        /// </summary>
        public int Pid { get; set; }

    }
}

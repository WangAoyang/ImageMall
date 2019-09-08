﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 地址表
    /// </summary>
    public class AddressInfo: BaseEntity
    {

        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int  Id { get; set; }

        /// <summary>
        /// 地区名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public int Pid { get; set; }

    }
}

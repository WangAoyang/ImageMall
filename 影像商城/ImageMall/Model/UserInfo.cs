using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserInfo
    {

        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string TrueName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public int PictureId { get; set; }

        /// <summary>
        /// 地区Id
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string Detailed { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
        public int Integral { get; set; }

        /// <summary>
        /// 身份
        /// </summary>
        public string Identity { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get; set; }
        
    }
}

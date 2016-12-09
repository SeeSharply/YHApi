using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Domain.Model
{
    public class User
    {
        public int ID { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public string Password { get; set; }
        [MaxLength(200)]
        public string Comment { get; set; }
        /// <summary>
        /// 用户类型
        /// </summary>
        public int Type{ get; set; }

    }
}
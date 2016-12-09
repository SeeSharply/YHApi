using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Domain.Model
{
    public class MemberType
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        /// <summary>
        /// 简洁
        /// </summary>
        public string Profile { get; set; }
    }
}
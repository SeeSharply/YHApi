using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Domain.Model
{
    public class Member
    {
        public int ID { get; set; }
        /// <summary>
        /// 会员名字
        /// </summary>
        [Required(ErrorMessage="姓名必填")]
        public string Name { get; set; }
       /// <summary>
       /// 性别
       /// </summary>
        public string Gender { get; set; }
        [MaxLength(30)]
        /// <summary>
        /// 淘宝账号
        /// </summary>
        public string TBAccount { get; set; }
        /// <summary>
        /// 淘宝昵称
        /// </summary>
        public string TBName { get; set; }
        /// <summary>
        /// 会员电话号码
        /// </summary>
        [Required(ErrorMessage="联系方式必填")]
        [MaxLength(20)]
        public string  Phone { get; set; }
        /// <summary>
        /// 会员的qq号码
        /// </summary>
        [MaxLength(12)]
        public string  QQ { get; set; }
        [MaxLength(25)]
        public string Provence { get; set; }
        public string ProvenceId { get; set; }
        [MaxLength(25)]
        public string City { get; set; }
        public string CityId { get; set; }
        [MaxLength(25)]
        public string Town { get; set; }
        public string TownId { get; set; }
        /// <summary>
        /// 具体地址
        /// </summary>
        [MaxLength(25)]
        [Required]
        public string Adress { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        [MaxLength(25)]
        [Required]
        public string ZipCode { get; set; }
        /// <summary>
        /// 会员注册日期，由系统自动生成
        /// </summary>
        public DateTime RegistTime { get; set; }
        /// <summary>
        /// 配送开始的日期
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 配送结束日期
        /// </summary>
        public DateTime EndTime { get; set; }
        [DefaultValue(false)]
        public bool Deleted { get; set; }

        public virtual List<Product> Products { get; set; }
        [ForeignKey("MemberTypes")]
        public virtual int MemberTypeID { get; set; }
        public virtual MemberType MemberTypes { get; set; }
    }
}
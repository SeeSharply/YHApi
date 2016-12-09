using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Domain.Model
{
    public class Cook
    {
        public int ID { get; set; }
        /// <summary>
        /// 烹饪方法名字
        /// </summary>
       [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Profile { get; set; }
        /// <summary>
        /// 营养价值分析：用图文文章的形式展现
        /// </summary>
        public string Nutrition { get; set; }
        /// <summary>
        /// 具体烹饪方法
        /// </summary>
        public string Method { get; set; }
        public DateTime EditTime { get; set; }
        [DefaultValue(0)]
        public int ReadTimes { get; set; }
        /// <summary>
        /// 发表者名字，默认为 “禾益生态农业”
        /// </summary>
        [DefaultValue("禾益生态农业")]
        [MaxLength(20)]
        public string Publisher { get; set; }
        [DefaultValue(false)]
        public bool Deleted { get; set; }
        [ForeignKey("Season")]
        public virtual int SeasonId { get;set; }
        public virtual Season Season { get; set; }
        [ForeignKey("Product")]
        public virtual int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public string Image { get; set; }
    }
}
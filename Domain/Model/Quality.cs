using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Domain.Model
{
    public class Quality
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        public string Detail { get; set; }
        /// <summary>
        /// 发表者名字，默认为 “禾益生态农业”
        /// </summary>
        [DefaultValue("禾益生态农业")]
        [MaxLength(20)]
        public string Publisher { get; set; }
        [DefaultValue(false)]
        public bool Deleted { get; set; }
        [ForeignKey("Product")]
        public virtual int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public DateTime EditTime { get; set; }

        public int ReadTimes { get; set; }

        public string Image { get; set; }

        public string Profile { get; set; }
    }
}
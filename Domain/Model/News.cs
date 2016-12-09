using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Domain.Model
{
    public class News
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Profile { get; set; }
        public string Details { get; set; }
        public DateTime EditTime { get; set; }
        public string Picture { get; set; }
        /// <summary>
        /// 发表者名字，默认为 “禾益生态农业”
        /// </summary>
        [DefaultValue("禾益生态农业")]
        [MaxLength(20)]
        public string Publisher { get; set; }
        public int ReadTimes { get; set; }
        [DefaultValue(false)]
        public bool Deleted { get; set; }
    }
}
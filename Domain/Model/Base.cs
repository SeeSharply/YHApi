using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Domain.Model
{
    public class Base
    {
        public int ID { get; set; }
        [Required(ErrorMessage="基地名字必填")]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Profile { get; set; }
        [MaxLength(25)]
        public string Province { get; set; }
        public int ProvinceId { get; set; }
        [MaxLength(25)]
        public string City { get; set; }
        public int CityId { get; set; }
        [MaxLength(25)]
        public string Town { get; set; }
        public int TownId { get; set; }
        /// <summary>
        /// 基地地址
        /// </summary>
        public string Adress { get; set; }
        /// <summary>
        /// 百度地图的json数据，在页面动态渲染
        /// </summary>
        public string Map { get; set; }
        /// <summary>
        /// 是否展示地图
        /// </summary>
        public bool UseMap { get; set; }
        public string Detail { get; set; }
        public String EditTime { get; set; }
        public DateTime CreateTime { get; set; }
        [DefaultValue(false)]
        public bool Deleted { get; set; }
        public string Image { get; set; }
    }
}
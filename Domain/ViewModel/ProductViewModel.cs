using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string Profile { get; set; }
        /// <summary>
        /// 展示图片
        /// </summary>
        public string TileImage { get; set; }
        /// <summary>
        /// 详细内容
        /// </summary>
        public string Detail { get; set; }
        public DateTime EditTime { get; set; }
        /// <summary>
        /// 浏览量
        /// </summary>
        public int ReadTimes { get; set; }
        /// <summary>
        /// 淘宝链接
        /// </summary>
        public string TbLink { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public Decimal Price { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 发表者名字，默认为 “禾益生态农业”
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// 是否展示或供应
        /// </summary>
        public bool Enable { get; set; }
        public bool Deleted { get; set; }
        /// <summary>
        /// 类型外键
        /// </summary>
        public virtual int ProductTypeId { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string ProductTypeName { get; set; }
    }
}

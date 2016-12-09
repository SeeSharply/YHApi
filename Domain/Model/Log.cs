using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Model
{
    public class Log
    {
        public int id { get; set; }
        public string ActionName { get; set; }
        public string OperationName { get; set; }
        public DateTime Time{get;set;}
        public string Message { get; set; }
        public bool Success { get; set; }
    }

    public enum FarmEntityType
    {
        /// <summary>
        /// 会员
        /// </summary>
        Member=1,
        /// <summary>
        /// 产品
        /// </summary>
        Product=2,
        /// <summary>
        /// 营养价值分析
        /// </summary>
        Cook=3,
        /// <summary>
        /// 质量监控
        /// </summary>
        Quality=4,
        /// <summary>
        /// 基地管理
        /// </summary>
        Base = 5,
        /// <summary>
        /// 用户管理
        /// </summary>
        User = 6,
        /// <summary>
        /// 新闻管理
        /// </summary>
        News =7
    }
}
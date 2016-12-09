using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Model
{
    public class Season
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public enum SeasonType
    {
        Spring=1,
        Summer=2,
        Autumn=3,
        Winter=4
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Domain.Model
{
    public class ProductType
    {
        [Key]
        public int ID { get; set; }
        public int BelongID { get; set; }
        public string Name { get; set; }
    }
}
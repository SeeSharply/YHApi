using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class BaseResult
    {
        public ResultType resultType { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }
    }
    public enum ResultType
    {
        Success=1,
        Failed=-1,
        NotFound=-2,
        Excption=-3
    }
}

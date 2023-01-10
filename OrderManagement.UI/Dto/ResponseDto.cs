using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.UI.Dto
{
    public class ResponseDto<T> 
    {
        public T Data { get; set; }
        public int? StatusCode { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public int? Records { get; set; }
        public object Error { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Api.Dto
{
    public class ResponseModelDto<T> 
    {
        public T Data { get; set; }
        public int? StatusCode { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public int? Records { get; set; }
        public object Error { get; set; }
        public ResponseModelDto(T Data, string Message, int? StatusCode, string Description = null, int? Records = null, object Error = null)
        {
            this.Data = Data;
            this.StatusCode = StatusCode;
            this.Message = Message;
            this.Description = Description;
            this.Records = Records;
            this.Error = Error;
        }
        public static ResponseModelDto<T> GetResponseModel(T Data, string Message, int? StatusCode, string Description = null, int? Records = null, object Error = null)
        {
            return new ResponseModelDto<T>(Data, Message, StatusCode, Description, Records, Error);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiWithJWT.Common
{
    public class ResponseModel
    {
        public bool HasError { get; set; }
        public int ErrorCode { get; set; }
        public Enums.ResponseType type { get; set; }
        public string message { get; set; }
        public int RecordCount { get; set; }
        public object Data { get; set; }
        public List<object> DataList { get; set; }
        public long ModelId { get; set; }
        public string ModelField { get; set; }
        public string ModelStatus { get; set; }
        public List<ErrorModel> Error { get; set; }
        public string token { get; set; }
    }
}

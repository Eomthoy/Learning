using System.Collections.Generic;

namespace Common.Basics
{
    public class AjaxResult<T>
    {
        public bool? IsSuccess { get; set; }
        public string Message { get; set; }
        public IEnumerable<T> Data { get; set; }
        public AjaxResult()
        {
        }
        public AjaxResult(IEnumerable<T> data)
        {
            this.IsSuccess = true;
            this.Data = data;
        }
        public AjaxResult(bool isSuccess, string message)
        {
            this.IsSuccess = isSuccess;
            this.Message = message;
        }
        public AjaxResult(bool isSuccess, IEnumerable<T> data)
        {
            this.IsSuccess = isSuccess;
            this.Data = data;
        }
        public AjaxResult(bool isSuccess, string message, IEnumerable<T> data)
        {
            this.IsSuccess = isSuccess;
            this.Message = message;
            this.Data = data;
        }
    }
    public class AjaxResult
    {
        public bool? IsSuccess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public AjaxResult()
        {
        }
        public AjaxResult(object data)
        {
            this.IsSuccess = true;
            this.Data = data;
        }
        public AjaxResult(bool isSuccess, string message)
        {
            this.IsSuccess = isSuccess;
            this.Message = message;
        }
        public AjaxResult(bool isSuccess, object data)
        {
            this.IsSuccess = isSuccess;
            this.Data = data;
        }
        public AjaxResult(bool isSuccess, string message, object data)
        {
            this.IsSuccess = isSuccess;
            this.Message = message;
            this.Data = data;
        }
    }
}

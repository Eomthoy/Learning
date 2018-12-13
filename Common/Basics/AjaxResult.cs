using System.Collections.Generic;
using System.Linq;

namespace Common.Basics
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AjaxResult<T> where T : class
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool? IsSuccess { get; set; }
        /// <summary>
        /// 返回消息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
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
        public static AjaxResult<T> Success(string message)
        {
            return new AjaxResult<T>(true, message);
        }
        public static AjaxResult<T> Erro(string message)
        {
            return new AjaxResult<T>(false, message);
        }
    }
    public class Success
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool? IsSuccess { get; set; }
        /// <summary>
        /// 返回消息
        /// </summary>
        public string Message { get; set; }
        public Success()
        {
        }
        public Success(string message)
        {
            this.IsSuccess = true;
            this.Message = message;
        }
    }
    public class Erro
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool? IsSuccess { get; set; }
        /// <summary>
        /// 返回消息
        /// </summary>
        public string Message { get; set; }
        public Erro()
        {
        }
        public Erro(string message)
        {
            this.IsSuccess = false;
            this.Message = message;
        }
    }
}

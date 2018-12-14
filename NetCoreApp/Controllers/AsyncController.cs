using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreApp.Controllers
{
    /// <summary>
    /// 异步测试
    /// </summary>
    [Produces("application/json")]
    [Route("api/Async")]
    public class AsyncController : ApiBaseController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/ChangeAsync")]
        public async Task<JsonResult> ChangeAsync(string str)
        {
            string result = await Change(str);
            return new JsonResult(result);
        }
        private async Task<string> Change(string str)
        {
            Func<string, string> func = x => { return x.ToUpper(); };
            string result = await Task.Run(() => func(str));
            result = result + "-UPPER";
            return result;
        }
    }
}
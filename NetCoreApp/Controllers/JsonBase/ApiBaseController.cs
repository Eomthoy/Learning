using Eom.Common.Basics;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreApp.Controllers
{
    public class ApiBaseController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected AjaxResult Succuss(string message)
        {
            return new AjaxResult(true, message);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected AjaxResult Erro(string message)
        {
            return new AjaxResult(false, message);
        }
    }
}
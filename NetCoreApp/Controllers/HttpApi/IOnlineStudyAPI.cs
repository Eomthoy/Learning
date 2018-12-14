using Common.Basics;
using NetCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClient;
using WebApiClient.Attributes;

namespace NetCoreApp.Controllers
{
    /// <summary>
    /// 用户操作接口
    /// </summary>
    public interface IOnlineStudyAPI : IHttpApi
    {
        // GET {url}?account={account}&password={password}&something={something}
        [HttpPost("Data/GetStatistics")]
        [Timeout(10 * 1000)] // 10s超时
        [JsonReturn]
        ITask<AjaxResult<StatisticsDto>> GetByIdAsync([JsonContent]SearchDto query);

    }
}

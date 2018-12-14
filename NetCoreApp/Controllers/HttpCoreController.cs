using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Basics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Repository;
using WebApiClient;

namespace NetCoreApp.Controllers
{
    [Produces("application/json")]
    [Route("api/HttpCore")]
    public class HttpCoreController : Controller
    {
        [Route("GetTaskAsync")]
        [HttpGet]
        public async Task<AjaxResult<StatisticsDto>> GetTaskAsync()
        {
            try
            {
                var userApi = HttpApiFactory.Create<IUserAPI>();
                var about = await userApi.GetByIdAsync(new SearchDto() { Role = "1", Code = "20051053" });
                new AjaxResult<StatisticsDto>(about.Data);
                return about;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [Route("GetOnlineStudyAsync")]
        [HttpGet]
        public async Task<AjaxResult<StatisticsDto>> GetOnlineStudyAsync()
        {
            try
            {
                var userApi = HttpApiFactory.Create<IUserAPI>();
                var about = await userApi.GetByIdAsync(new SearchDto() { Role = "1", Code = "钱前" });
                return about;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
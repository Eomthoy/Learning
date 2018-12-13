﻿using System.IO;
using System.Threading.Tasks;
using Common.Basics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Common.Helper;

namespace NetCoreApp.Controllers
{
    [Produces("application/json")]
    [Route("FileManage/")]
    public class FileManageController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private string path = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        public FileManageController(IHostingEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
            this.path = _hostingEnvironment.WebRootPath + "/UploadFiles/";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("UploadFile")]
        [HttpPost]
        public async Task<AjaxResult<string>> UploadFile()
        {

            FileHelper.Upload(path, Request.Form.Files);
            await FileHelper.UploadAsync(path, Request.Form.Files);

            return new Success("上传成功");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("DownloadFile")]
        [HttpPost]
        public FileResult DownloadFile([FromBody] string fileName)
        {
            string filePath = Path.Combine(path, fileName);
            var stream = System.IO.File.OpenRead(filePath);
            //获取contentType
            string contentType = FileHelper.GetContentType(_hostingEnvironment.WebRootPath + "/UploadFiles/" + fileName);
            //FileHelper.GetContentType(_hostingEnvironment.WebRootPath + "/UploadFiles/" + "劳务表.xlsx");
            //FileHelper.GetContentType(_hostingEnvironment.WebRootPath + "/UploadFiles/" + "题目.txt");

            return File(stream, contentType, fileName);
        }
    }
}
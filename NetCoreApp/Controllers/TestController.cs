using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Eom.Common.Basics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetCoreApp.Models;
using NetCoreApp.Repository;

namespace NetCoreApp.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class TestController : Controller
    {
        private IConfiguration _configuration;
        private IHostingEnvironment _hostingEnvironment;
        public TestController(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// 
        /// </summary>
        [Route("Test/ExcelImport")]
        [HttpPost]
        public void ExcelImport()
        {
            string msg = "";
            long size = 0;
            var files = Request.Form.Files;
            string webRootPath = _hostingEnvironment.WebRootPath;
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    string fileExt = System.IO.Path.GetExtension(formFile.FileName); //文件扩展名
                    string newFileName = System.Guid.NewGuid().ToString() + fileExt; //随机生成新的文件名
                    string path = webRootPath + "/UploadFiles/";
                    // 如果不存在就创建file文件夹
                    if (!Directory.Exists(path))
                    {
                        if (path != null) Directory.CreateDirectory(path);
                    }
                    string filePath = Path.Combine(path, newFileName);
                    size += formFile.Length;
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        //写入本地
                        formFile.CopyTo(stream);
                        stream.Flush();
                    }
                    //读取excel数据保存至数据库
                    var result = ReadExcelToDataTable(filePath, "学生酬金领取表", 2);
                }
            }
        }

        private object ReadExcelToDataTable(string filePath, string v1, int v2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        [Route("Test/TestFunc")]
        [HttpPost]
        public JsonResult TestFunc(string str)
        {
            try
            {
                using (NetCoreContext context = new NetCoreContext())
                {
                    //var fsk = context.Set<Student>().Select(x => x.Name).FromSql<Student>("select Name from Student").ToList();
                    //IList<Student> test = fsk.Select(x => new { x.Name, x.Id }) as IList<Student>;

                    IList<Student> dahd = context.Student.ToList();


                    //分页1
                    int pageSize = 10;
                    int pageNum = 2;
                    int offset = pageSize * (pageNum - 1);
                    IList<Student> list = context.Student.Skip(offset).Take(pageSize).ToList();


                    //分页2
                    int pageSize2 = 5;
                    int pageNum2 = 4;
                    int offset2 = pageSize2 * (pageNum2 - 1);
                    IList<Student> list2 = context.Student.Skip(offset2).Take(pageSize2).ToList();
                    //分页3
                    PageResult<Student> result = new PageResult<Student>(pageNum2, pageSize, context.Student);
                    //sql执行
                    string sqlsql = "Select * From Student";
                    var dasjdla = context.Student.FromSql(sqlsql).ToList();

                    string sql = "Select s.*,c.Name As ClassName From Student As s Left Join Class As c On c.Id = s.ClassId";
                    var fdhskf = context.Stu.FromSql(sql).ToList();

                    IList<Stu> stundetList = context.Student.FromSql(sql).ToList() as IList<Stu>; //返回值：IQueryable<TEntity>

                    var fdsfdsfds = context.Database.ExecuteSqlCommand(sql);            //返回值：int

                    return this.Json(dahd);
                }
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                throw new Exception(ex.Message);
            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class Car
    {
        /// <summary>
        /// 
        /// </summary>
        public string Nmae { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Eom.Common;
using Eom.Common.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
using NetCoreApp.Controllers;
using NetCoreApp.Models;
using NetCoreApp.Repository;
using WebApiClient;

namespace NetCoreApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            // 注册与配置IUserApi接口
            HttpApiFactory.Add<IUserAPI>().ConfigureHttpApiConfig(c =>
            {
                c.HttpHost = new Uri("http://localhost:55418/");
                c.LoggerFactory = new LoggerFactory().AddConsole();
                c.FormatOptions.DateTimeFormat = DateTimeFormats.ISO8601_WithMillisecond;
            });
            // 注册与配置IUserApi接口
            HttpApiFactory.Add<IOnlineStudyAPI>().ConfigureHttpApiConfig(c =>
            {
                c.HttpHost = new Uri("http://localhost:50323/");
                c.LoggerFactory = new LoggerFactory().AddConsole();
                c.FormatOptions.DateTimeFormat = DateTimeFormats.ISO8601_WithMillisecond;
            });
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            AutoMapper.Mapper.Initialize(option => option.AddProfile(new AutoMapperFile()));
            //注册swagger
            services.AddMvc().AddJsonOptions(options =>
            {
                //不使用驼峰样式的key
                options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
                //设置时间格式
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            });
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Version = "v1",
                    Title = "Demo API"
                });
                //swagger中增加accesstoken参数
                x.OperationFilter<AddAuthTokenHeaderParameter>();
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var xmlPath = Path.Combine(basePath, "NetCoreApp.xml");
                x.IncludeXmlComments(xmlPath);
            });
            //SqlServer注入
            NetCoreContext.ConnectionString = Configuration.GetConnectionString("SqlServer");
            SqlHelper.connString = Configuration.GetConnectionString("SqlServer");
            SqlHelper.connString = "data source=10.126.6.113;initial catalog=TSP;user id=sa;password=cdutcm@123;";
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCors("any");
            app.UseMvc();

            //注册swagger
            app.UseSwagger();
            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "DemoApi");
            });
        }
    }
}

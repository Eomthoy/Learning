using Microsoft.EntityFrameworkCore;
using NetCoreApp.Models;

namespace NetCoreApp.Repository
{
    /// <summary>
    /// 仓储上下文
    /// </summary>
    public class NetCoreContext : DbContext
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string ConnectionString = null;
        /// <summary>
        /// 数据库注册
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //注入Sql链接字符串
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Stu> Stu { get; set; }
        public virtual DbSet<SysMenu> SysMenu { get; set; }
        public virtual DbSet<SysButton> SysButton { get; set; }
    }
}

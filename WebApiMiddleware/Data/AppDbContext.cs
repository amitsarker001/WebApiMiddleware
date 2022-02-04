using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMiddleware.Data.Model;

namespace WebApiMiddleware.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<UserInfo> UserInfos{ get; set; }
        public DbSet<Products> Products{ get; set; }
    }
}

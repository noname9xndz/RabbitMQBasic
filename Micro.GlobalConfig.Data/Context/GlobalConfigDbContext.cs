using Micro.GlobalConfig.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Micro.GlobalConfig.Data.Context
{
    public class GlobalConfigDbContext : DbContext
    {
        public GlobalConfigDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<GlobalConfigModel> GlobalConfig { set; get; }
    }
}
using Micro.Job.Domain.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Micro.Job.Data.Context
{
    public class JobDbContext : DbContext
    {
        public JobDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<JobModel> Jobs { set; get; }
    }
}
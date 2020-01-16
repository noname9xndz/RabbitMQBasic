using Micro.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Micro.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AccountTransferLog> AccountTransferLog { set; get; }
    }
}
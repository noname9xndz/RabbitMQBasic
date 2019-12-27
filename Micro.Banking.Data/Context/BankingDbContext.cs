using System;
using System.Collections.Generic;
using System.Text;
using Micro.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Micro.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Account> Accounts { set; get; }
    }
}

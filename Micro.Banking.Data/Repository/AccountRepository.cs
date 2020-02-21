using Micro.Banking.Data.Context;
using Micro.Banking.Domain.Interfaces;
using Micro.Banking.Domain.Models;
using System.Collections.Generic;

namespace Micro.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _bankingDbContext;

        public AccountRepository(BankingDbContext bankingDbContext)
        {
            _bankingDbContext = bankingDbContext;
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _bankingDbContext.Accounts;
        }
    }
}
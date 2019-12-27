using System;
using System.Collections.Generic;
using System.Text;
using Micro.Banking.Application.Interfaces;
using Micro.Banking.Domain.Interfaces;
using Micro.Banking.Domain.Models;

namespace Micro.Banking.Application.Services
{
   public class AccountService : IAccountService
   {
       private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public IEnumerable<Account> GetAllAccounts()
        {
            return _accountRepository.GetAllAccounts();
        }
    }
}

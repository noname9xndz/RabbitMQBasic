using Micro.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Micro.Banking.Application.Models;

namespace Micro.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAllAccounts();

        void Transfer(AccountTransfer accountTransfer);
    }
}

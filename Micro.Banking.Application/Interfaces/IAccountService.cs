using Micro.Banking.Application.Models;
using Micro.Banking.Domain.Models;
using System.Collections.Generic;

namespace Micro.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAllAccounts();

        void Transfer(AccountTransfer accountTransfer);
    }
}
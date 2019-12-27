using System;
using System.Collections.Generic;
using System.Text;
using Micro.Banking.Domain.Models;

namespace Micro.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAllAccounts();

    }
}

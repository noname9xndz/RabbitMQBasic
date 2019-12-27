using Micro.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micro.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAllAccounts();
    }
}

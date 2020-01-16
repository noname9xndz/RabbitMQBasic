using Micro.Banking.Domain.Models;
using System.Collections.Generic;

namespace Micro.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAllAccounts();
        //void AddAco
    }
}
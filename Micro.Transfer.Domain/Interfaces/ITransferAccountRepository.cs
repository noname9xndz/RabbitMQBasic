using Micro.Transfer.Domain.Models;
using System.Collections.Generic;

namespace Micro.Transfer.Domain.Interfaces
{
    public interface ITransferAccountRepository
    {
        IEnumerable<AccountTransferLog> GetAllAccountsTransferLog();
    }
}
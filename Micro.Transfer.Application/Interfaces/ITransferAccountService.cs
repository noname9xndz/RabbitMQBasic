
using System.Collections.Generic;
using Micro.Transfer.Domain.Models;

namespace Micro.Transfer.Application.Interfaces
{
    public interface ITransferAccountService
    {
        IEnumerable<AccountTransferLog> GetAllAccountsTransferLog();

       // void Transfer(AccountTransfer accountTransfer);
    }
}
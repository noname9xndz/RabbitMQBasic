using Micro.Transfer.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Micro.Transfer.Domain.Interfaces
{
    public interface ITransferAccountRepository
    {
        IEnumerable<AccountTransferLog> GetAllAccountsTransferLog();

        void AddAccountsTransferLog(AccountTransferLog accountTransferLog);
    }
}
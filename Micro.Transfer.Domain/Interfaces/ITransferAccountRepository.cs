using Micro.Common;
using Micro.Transfer.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Micro.Transfer.Domain.Interfaces
{
    public interface ITransferAccountRepository
    {
        Task<List<AccountTransferLog>> GetAllAccountsTransferLog();

        Task AddAccountsTransferLog(AccountTransferLog accountTransferLog);

        Task UpdateAccountsTransferLog(AccountTransferLog accountTransferLog);

        Task<bool> UpdateMultiAccountsTransferLog(List<AccountTransferLog> listAccountTransferLog);

        Task<List<AccountTransferLog>> GetAllAccountsTransferLogByStatus(PaymentStatus paymentStatus);
    }
}
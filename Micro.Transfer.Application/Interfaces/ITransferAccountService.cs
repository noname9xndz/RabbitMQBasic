using Micro.Common;
using Micro.Transfer.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Micro.Transfer.Application.Interfaces
{
    public interface ITransferAccountService
    {
        Task<List<AccountTransferLog>> GetAllAccountsTransferLog();

        Task<List<AccountTransferLog>> GetAllAccountsTransferLogByStatus(PaymentStatus paymentStatus);

        Task<bool> UpdateMultiAccountsTransferLog(List<AccountTransferLog> listTransferLogs);

        // void Transfer(AccountTransfer accountTransfer);
    }
}
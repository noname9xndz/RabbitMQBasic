using Micro.Transfer.Data.Context;
using Micro.Transfer.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Micro.Transfer.Domain.Interfaces;

namespace Micro.Transfer.Data.Repository
{
    public class TransferAccountRepository : ITransferAccountRepository
    {
        private readonly TransferDbContext _transferDbContextDbContext;

        public TransferAccountRepository(TransferDbContext transferDbContextDbContext)
        {
            _transferDbContextDbContext = transferDbContextDbContext;
        }

        public IEnumerable<AccountTransferLog> GetAllAccountsTransferLog()
        {
            return _transferDbContextDbContext.AccountTransferLog;
        }

        public async Task AddAccountsTransferLog(AccountTransferLog accountTransferLog)
        {
            await _transferDbContextDbContext.AccountTransferLog.AddAsync(accountTransferLog);
            await _transferDbContextDbContext.SaveChangesAsync();
        }
    }
}
using Micro.Transfer.Data.Context;
using Micro.Transfer.Domain.Models;
using System.Collections.Generic;
using Micro.Transfer.Domain.Interfaces;

namespace Micro.Transfer.Data.Repository
{
    public class TransferAccountRepository : ITransferAccountRepository
    {
        private readonly TransferDbContext _bankingDbContext;

        public TransferAccountRepository(TransferDbContext bankingDbContext)
        {
            _bankingDbContext = bankingDbContext;
        }

        public IEnumerable<AccountTransferLog> GetAllAccountsTransferLog()
        {
            return _bankingDbContext.AccountTransferLog;
        }
    }
}
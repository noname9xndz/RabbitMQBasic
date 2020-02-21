using Micro.Common;
using Micro.Transfer.Data.Context;
using Micro.Transfer.Domain.Interfaces;
using Micro.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Micro.Transfer.Data.Repository
{
    public class TransferAccountRepository : ITransferAccountRepository
    {
        private readonly TransferDbContext _transferDbContextDbContext;

        public TransferAccountRepository(TransferDbContext transferDbContextDbContext)
        {
            _transferDbContextDbContext = transferDbContextDbContext;
        }

        public async Task<List<AccountTransferLog>> GetAllAccountsTransferLog()
        {
            return await _transferDbContextDbContext.AccountTransferLog.AsQueryable().Where(x=>x.PaymentType == PaymentType.PostPaid).ToListAsync();
        }

        public async Task AddAccountsTransferLog(AccountTransferLog accountTransferLog)
        {
            await _transferDbContextDbContext.AccountTransferLog.AddAsync(accountTransferLog);
            await _transferDbContextDbContext.SaveChangesAsync();
        }

        public async Task UpdateAccountsTransferLog(AccountTransferLog accountTransferLog)
        {
            var model = _transferDbContextDbContext.AccountTransferLog.Update(accountTransferLog);
            await Task.FromResult(model);
        }

        public async Task<bool> UpdateMultiAccountsTransferLog(List<AccountTransferLog> listAccountTransferLog)
        {
            bool flag = false;
            try
            {
                _transferDbContextDbContext.AccountTransferLog.UpdateRange(listAccountTransferLog);
                await _transferDbContextDbContext.SaveChangesAsync();
                flag = true;
            }
            catch (Exception e)
            {
                // write log
            }

            return await Task.FromResult(flag);
        }

        public async Task<List<AccountTransferLog>> GetAllAccountsTransferLogByStatus(PaymentStatus paymentStatus)
        {
            List<AccountTransferLog> listTransferLogs = new List<AccountTransferLog>();
            try
            {
                listTransferLogs = await _transferDbContextDbContext.AccountTransferLog.Where(x => x.PaymentStatus == paymentStatus && x.PaymentType == PaymentType.PostPaid).ToListAsync();
            }
            catch (Exception e)
            {
                // write log
            }

            return listTransferLogs;
        }
    }
}
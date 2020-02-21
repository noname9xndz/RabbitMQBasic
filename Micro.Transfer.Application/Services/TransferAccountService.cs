using Micro.Common;
using Micro.Domain.Core.Bus;
using Micro.Transfer.Application.Interfaces;
using Micro.Transfer.Domain.Interfaces;
using Micro.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Micro.Transfer.Application.Services
{
    public class TransferAccountService : ITransferAccountService
    {
        private readonly ITransferAccountRepository _transferAccountRepository;
        private readonly IEventBus _eventBus;

        public TransferAccountService(ITransferAccountRepository transferAccountRepository, IEventBus eventBus)
        {
            _transferAccountRepository = transferAccountRepository;
            _eventBus = eventBus;
        }

        public async Task<List<AccountTransferLog>> GetAllAccountsTransferLog()
        {
            return await _transferAccountRepository.GetAllAccountsTransferLog();
        }

        public async Task<List<AccountTransferLog>> GetAllAccountsTransferLogByStatus(PaymentStatus paymentStatus)
        {
            return await _transferAccountRepository.GetAllAccountsTransferLogByStatus(paymentStatus);
        }

        public async Task<bool> UpdateMultiAccountsTransferLog(List<AccountTransferLog> listTransferLogs)
        {
            bool flag = false;
            try
            {
                await _transferAccountRepository.UpdateMultiAccountsTransferLog(listTransferLogs);
                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
            }

            return flag;
        }
    }
}
using Micro.Transfer.Application.Interfaces;
using Micro.Transfer.Domain.Interfaces;
using Micro.Transfer.Domain.Models;
using System.Collections.Generic;
using Micro.Domain.Core.Bus;

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

        public IEnumerable<AccountTransferLog> GetAllAccountsTransferLog()
        {
            return _transferAccountRepository.GetAllAccountsTransferLog();
        }

    }
}
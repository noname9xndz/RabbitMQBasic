using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Micro.Domain.Core.Bus;
using Micro.Transfer.Domain.Events;
using Micro.Transfer.Domain.Interfaces;
using Micro.Transfer.Domain.Models;

namespace Micro.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferAccountRepository _transferAccountRepository;
        public TransferEventHandler(ITransferAccountRepository transferAccountRepository)
        {
            _transferAccountRepository = transferAccountRepository;
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            _transferAccountRepository.AddAccountsTransferLog(new AccountTransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount

            });
            return Task.CompletedTask;
        }
    }
}

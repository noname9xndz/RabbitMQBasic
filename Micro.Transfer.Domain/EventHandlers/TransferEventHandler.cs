using Micro.Domain.Core.Bus;
using Micro.Transfer.Domain.Events;
using Micro.Transfer.Domain.Interfaces;
using Micro.Transfer.Domain.Models;
using System.Threading.Tasks;

namespace Micro.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferAccountRepository _transferAccountRepository;

        public TransferEventHandler(ITransferAccountRepository transferAccountRepository)
        {
            _transferAccountRepository = transferAccountRepository;
        }

        public async Task Handle(TransferCreatedEvent @event)
        {
            await _transferAccountRepository.AddAccountsTransferLog(new AccountTransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount,
                PaymentType = @event.PaymentType,
                PaymentStatus = @event.PaymentStatus
            });
        }
    }
}
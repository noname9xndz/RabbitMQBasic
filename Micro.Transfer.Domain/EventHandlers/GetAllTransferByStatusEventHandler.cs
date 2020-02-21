using Micro.Domain.Core.Bus;
using Micro.Transfer.Domain.Events;
using Micro.Transfer.Domain.Interfaces;
using Micro.Transfer.Domain.Models;
using System.Threading.Tasks;

namespace Micro.Transfer.Domain.EventHandlers
{
    public class GetAllTransferByStatusEventHandler : IEventHandlerResult<GetAllTransferByStatusEvent, TransferListViewModel>
    {
        private readonly ITransferAccountRepository _transferAccountRepository;

        public GetAllTransferByStatusEventHandler(ITransferAccountRepository transferAccountRepository)
        {
            _transferAccountRepository = transferAccountRepository;
        }

        public async Task<TransferListViewModel> Handle(GetAllTransferByStatusEvent @event)
        {
            TransferListViewModel transfers = new TransferListViewModel();
            transfers.listTransferViewModels = await _transferAccountRepository.GetAllAccountsTransferLogByStatus(@event.PaymentStatus);
            return transfers;
        }
    }
}
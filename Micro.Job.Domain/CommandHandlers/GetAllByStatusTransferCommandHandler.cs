using MediatR;
using Micro.Domain.Core.Bus;
using Micro.Job.Domain.Commands;
using Micro.Job.Domain.Events;
using Micro.Job.Domain.ViewModels;
using System.Threading;
using System.Threading.Tasks;

namespace Micro.Job.Domain.CommandHandlers
{
    public class GetAllByStatusTransferCommandHandler : IRequestHandler<GetAllTransferByStatusCommand, TransferListViewModel>
    {
        private readonly IEventBus _eventBus;

        public GetAllByStatusTransferCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public async Task<TransferListViewModel> Handle(GetAllTransferByStatusCommand request, CancellationToken cancellationToken)
        {
            //publish event to rabbitmq
            _eventBus.Pushlish(new TransferGetAllByPaymentStatusEvent(request.PaymentStatus));

            return await Task.FromResult(new TransferListViewModel());
        }
    }
}
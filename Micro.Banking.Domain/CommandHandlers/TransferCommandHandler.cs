using MediatR;
using Micro.Banking.Domain.Commands;
using Micro.Banking.Domain.Events;
using Micro.Domain.Core.Bus;
using System.Threading;
using System.Threading.Tasks;

namespace Micro.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public TransferCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //publish event to rabbitmq
            _eventBus.Pushlish(new TransferCreatedEvent(request.From, request.To, request.Amount));

            return Task.FromResult(true);
        }
    }
}
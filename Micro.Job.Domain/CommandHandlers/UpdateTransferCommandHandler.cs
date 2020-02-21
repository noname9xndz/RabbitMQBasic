using MediatR;
using Micro.Domain.Core.Bus;
using Micro.Job.Domain.Commands;
using Micro.Job.Domain.Events;
using System.Threading;
using System.Threading.Tasks;

namespace Micro.Job.Domain.CommandHandlers
{
    public class UpdateTransferCommandHandler : IRequestHandler<UpdateMultiTransferCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public UpdateTransferCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(UpdateMultiTransferCommand request, CancellationToken cancellationToken)
        {
            //publish event to rabbitmq
            _eventBus.Pushlish(new TransferUpdateMultiEvent(request.TransferList));

            return Task.FromResult(true);
        }
    }
}
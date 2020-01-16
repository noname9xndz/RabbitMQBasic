using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Micro.Domain.Core.Bus;
using Micro.Transfer.Domain.Events;

namespace Micro.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {
            
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}

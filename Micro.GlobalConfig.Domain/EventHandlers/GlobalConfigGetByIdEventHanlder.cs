using Micro.Domain.Core.Bus;
using Micro.GlobalConfig.Domain.Events;
using Micro.GlobalConfig.Domain.Interfaces;
using System.Threading.Tasks;

namespace Micro.GlobalConfig.Domain.EventHandlers
{
    public class GlobalConfigGetByIdEventHanlder : IEventHandler<GlobalConfigUpdateEvent>
    {
        private readonly IGlobalConfigRepository _globalConfigRepository;

        public GlobalConfigGetByIdEventHanlder(IGlobalConfigRepository globalConfigRepository)
        {
            _globalConfigRepository = globalConfigRepository;
        }

        public async Task Handle(GlobalConfigUpdateEvent @event)
        {
            await _globalConfigRepository.GetGlobalConfigByName(@event.Name);
        }
    }
}
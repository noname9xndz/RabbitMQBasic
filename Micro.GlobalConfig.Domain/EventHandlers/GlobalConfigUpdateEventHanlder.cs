using Micro.Domain.Core.Bus;
using Micro.GlobalConfig.Domain.Events;
using Micro.GlobalConfig.Domain.Interfaces;
using System.Threading.Tasks;

namespace Micro.GlobalConfig.Domain.EventHandlers
{
    public class GlobalConfigUpdateEventHanlder : IEventHandler<GlobalConfigUpdateEvent>
    {
        private readonly IGlobalConfigRepository _globalConfigRepository;

        public GlobalConfigUpdateEventHanlder(IGlobalConfigRepository globalConfigRepository)
        {
            _globalConfigRepository = globalConfigRepository;
        }

        public async Task Handle(GlobalConfigUpdateEvent @event)
        {
            var config = await _globalConfigRepository.GetGlobalConfigByName(@event.Name);
            config.Name = @event.Name;
            config.Value = @event.Value;
            await _globalConfigRepository.UpdateGlobalConfig(config);
        }
    }
}
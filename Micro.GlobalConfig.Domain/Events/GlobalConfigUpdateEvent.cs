using Micro.Domain.Core.Events;

namespace Micro.GlobalConfig.Domain.Events
{
    public class GlobalConfigUpdateEvent : Event
    {
        public string Name { get; private set; }
        public string Value { get; private set; }

        public GlobalConfigUpdateEvent(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
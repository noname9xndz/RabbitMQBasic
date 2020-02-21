using Micro.Domain.Core.Events;
using System.Threading.Tasks;

namespace Micro.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {
    }

    public interface IEventHandlerResult<in TEvent, TResponse> where TEvent : Event
    {
        Task<TResponse> Handle(TEvent @event);
    }

    //    public interface <in TEvent,out TResult> : IEventHandler where TEvent : Event
    //    {
    //        Task<T> Handle(TEvent @event) where T : class;
    //
    //    }
}
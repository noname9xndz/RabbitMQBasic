using Micro.Common;
using Micro.Domain.Core.Events;

namespace Micro.Transfer.Domain.Events
{
    public class GetAllTransferByStatusEvent : Event
    {
        public PaymentStatus PaymentStatus { get; private set; }

        public GetAllTransferByStatusEvent(PaymentStatus paymentStatus)
        {
            PaymentStatus = paymentStatus;
        }
    }
}
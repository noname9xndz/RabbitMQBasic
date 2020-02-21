using Micro.Common;
using Micro.Domain.Core.Events;

namespace Micro.Job.Domain.Events
{
    public class TransferGetAllByPaymentStatusEvent : Event
    {
        public PaymentStatus PaymentStatus { get; private set; }

        public TransferGetAllByPaymentStatusEvent(PaymentStatus paymentStatus)
        {
            PaymentStatus = paymentStatus;
        }
    }
}
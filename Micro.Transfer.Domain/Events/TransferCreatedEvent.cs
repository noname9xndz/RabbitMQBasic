using Micro.Common;
using Micro.Domain.Core.Events;

namespace Micro.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public string From { get; private set; }
        public string To { get; private set; }
        public decimal Amount { get; private set; }

        public PaymentType? PaymentType { get; private set; }
        public PaymentStatus? PaymentStatus { get; private set; }

        public TransferCreatedEvent(string from, string to, decimal amount, PaymentType paymentType, PaymentStatus paymentStatus)
        {
            From = from;
            To = to;
            Amount = amount;
            PaymentType = paymentType;
            PaymentStatus = paymentStatus;
        }
    }
}
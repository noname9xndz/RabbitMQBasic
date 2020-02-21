using Micro.Common;
using Micro.Domain.Core.Events;

namespace Micro.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Amount { get; private set; }
        public PaymentType PaymentType { set; get; }
        public PaymentStatus PaymentStatus { set; get; }

        public TransferCreatedEvent(int from, int to, decimal amount, PaymentType paymentType, PaymentStatus paymentStatus)
        {
            From = from;
            To = to;
            Amount = amount;
            PaymentType = paymentType;
            PaymentStatus = paymentStatus;
        }
    }
}
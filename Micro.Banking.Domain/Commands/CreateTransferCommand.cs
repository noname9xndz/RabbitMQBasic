using Micro.Common;

namespace Micro.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int from, int to, decimal amount, PaymentType paymentType, PaymentStatus paymentStatus)
        {
            From = from;
            To = to;
            Amount = amount;
            PaymentType = paymentType;
            PaymentStatus = paymentStatus;
        }
    }
}
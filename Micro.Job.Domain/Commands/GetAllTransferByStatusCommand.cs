using MediatR;
using Micro.Common;
using Micro.Domain.Core.Commands;
using Micro.Job.Domain.ViewModels;

namespace Micro.Job.Domain.Commands
{
    public class GetAllTransferByStatusCommand : Command, IRequest<TransferListViewModel>
    {
        public PaymentStatus PaymentStatus { get; set; }

        public GetAllTransferByStatusCommand(PaymentStatus paymentStatus)
        {
            PaymentStatus = paymentStatus;
        }
    }
}
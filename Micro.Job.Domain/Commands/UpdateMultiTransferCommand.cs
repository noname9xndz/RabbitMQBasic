using MediatR;
using Micro.Domain.Core.Commands;
using Micro.Job.Domain.ViewModels;

namespace Micro.Job.Domain.Commands
{
    public class UpdateMultiTransferCommand : Command, IRequest<TransferListViewModel>
    {
        public TransferListViewModel TransferList { get; set; }

        public UpdateMultiTransferCommand(TransferListViewModel listTransferViewModels)
        {
            // transfer = new List<TransferViewModel>();
            TransferList = listTransferViewModels;
        }
    }
}
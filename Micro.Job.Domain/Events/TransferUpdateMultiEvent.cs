using Micro.Domain.Core.Events;
using Micro.Job.Domain.ViewModels;

namespace Micro.Job.Domain.Events
{
    public class TransferUpdateMultiEvent : Event
    {
        private TransferListViewModel TransferList { get; set; }

        public TransferUpdateMultiEvent(TransferListViewModel listTransferViewModels)
        {
            TransferList = listTransferViewModels;
        }
    }
}
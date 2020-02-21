using Micro.Common;
using Micro.Job.Domain.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Micro.Job.Application.Interfaces
{
    public interface IJobService
    {
        Task<List<TransferListViewModel>> GetAllTransferByPaymentStatus(PaymentStatus paymentStatus);

        Task<bool> UpdateMultilTranfer(TransferListViewModel transferList);
    }
}
using Micro.Common;
using Micro.Job.Domain.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Micro.Job.Services
{
    public interface ITranferClient
    {
        Task<List<TransferViewModel>> GetAllTranferByStatusAsync(PaymentStatus paymentStatus);

        Task<List<TransferViewModel>> GetAllTranferAsync();

        Task<bool> UpdateMultilTranfer(List<TransferViewModel> listTransferLogs);
    }
}
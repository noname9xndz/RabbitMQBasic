using Micro.Common;
using Micro.Domain.Core.Bus;
using Micro.Job.Application.Interfaces;
using Micro.Job.Domain.Commands;
using Micro.Job.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Micro.Job.Application.Services
{
    public class JobService : IJobService
    {
        private readonly IEventBus _eventBus;

        public async Task<List<TransferListViewModel>> GetAllTransferByPaymentStatus(PaymentStatus paymentStatus)
        {
            var createTranferCommand = new GetAllTransferByStatusCommand(paymentStatus);
            _eventBus.SendCommand(createTranferCommand);

            return await Task.FromResult(new List<TransferListViewModel>());
        }

        public Task<bool> UpdateMultilTranfer(TransferListViewModel transferList)
        {
            throw new NotImplementedException();
        }
    }
}
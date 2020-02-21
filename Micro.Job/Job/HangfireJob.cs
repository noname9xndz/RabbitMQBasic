using Micro.Common;
using Micro.Job.Services;
using System.Threading.Tasks;

namespace Micro.Job.Job
{
    public class HangfireJob
    {
        private readonly ITranferClient _tranferClient;

        public HangfireJob(ITranferClient tranferClient)
        {
            _tranferClient = tranferClient;
        }

        public async Task ChangeStatusTranfer()
        {
            var listTranfers = await _tranferClient.GetAllTranferByStatusAsync(PaymentStatus.Pending);
            if (listTranfers.Count > 0)
            {
                listTranfers.ForEach(x => x.PaymentStatus = PaymentStatus.Success);

                var status = await _tranferClient.UpdateMultilTranfer(listTranfers);

                // handle error status
            }
        }

        public async Task TestChangeTranferStatus()
        {
            var listTranfers = await _tranferClient.GetAllTranferAsync();
            if (listTranfers.Count > 0)
            {
                listTranfers.ForEach(x => x.PaymentStatus = PaymentStatus.Pending);

                var status = await _tranferClient.UpdateMultilTranfer(listTranfers);

                // handle error status
            }
        }
    }
}
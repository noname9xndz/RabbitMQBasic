using Micro.Common;
using Micro.Job.Domain.ViewModels;
using Micro.Job.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Micro.Job.Service
{
    public class TranferClient : ITranferClient
    {
        private readonly IHttpService _httpService;
        private string url => "https://localhost:5003/api/TransferAccount/";

        public TranferClient(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<List<TransferViewModel>> GetAllTranferByStatusAsync(PaymentStatus paymentStatus)
        {
            var tranfersObject = await _httpService.SendAsync<object>(url + (int)paymentStatus, HttpMethod.Get, null);
            List<TransferViewModel> transfer = JsonConvert.DeserializeObject<List<TransferViewModel>>(tranfersObject.Result.ToString());
            return transfer;
        }

        public async Task<List<TransferViewModel>> GetAllTranferAsync()
        {
            var tranfersObject = await _httpService.SendAsync<object>(url, HttpMethod.Get, null);
            List<TransferViewModel> transfer = JsonConvert.DeserializeObject<List<TransferViewModel>>(tranfersObject.Result.ToString());
            return transfer;
        }

        public async Task<bool> UpdateMultilTranfer(List<TransferViewModel> listTransferLogs)
        {
            string urlUpdate = "https://localhost:5003/api/TransferAccount/";
            var result = await _httpService.PutAsync<object>(url, listTransferLogs);
            return (bool)result.Result;
        }
    }
}
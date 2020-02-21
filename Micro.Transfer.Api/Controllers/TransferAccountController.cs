using Micro.Common;
using Micro.Transfer.Application.Interfaces;
using Micro.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Micro.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferAccountController : ControllerBase
    {
        private readonly ITransferAccountService _transferAccountService;

        public TransferAccountController(ITransferAccountService transferAccountService)
        {
            _transferAccountService = transferAccountService;
        }

        [HttpGet]
        public async Task<ApiResponse<List<AccountTransferLog>>> GetAllAccount()
        {
            ApiResponse<List<AccountTransferLog>> response = new ApiResponse<List<AccountTransferLog>>();
            response.Result = await _transferAccountService.GetAllAccountsTransferLog();
            response.Successful = true;
            return response;
        }

        [HttpGet("{paymentStatus}")]
        public async Task<ApiResponse<List<AccountTransferLog>>> GetAllByStatus(PaymentStatus paymentStatus)
        {
            ApiResponse<List<AccountTransferLog>> response = new ApiResponse<List<AccountTransferLog>>();
            response.Result = await _transferAccountService.GetAllAccountsTransferLogByStatus(paymentStatus);
            response.Successful = true;
            return response;
        }

        [HttpPut]
        public async Task<ApiResponse<bool>> UpdateMultilTranfer([FromBody]List<AccountTransferLog> listTransferLogs)
        {
            ApiResponse<bool> response = new ApiResponse<bool>();
            response.Result = await _transferAccountService.UpdateMultiAccountsTransferLog(listTransferLogs);
            response.Successful = true;
            return response;
        }
    }
}
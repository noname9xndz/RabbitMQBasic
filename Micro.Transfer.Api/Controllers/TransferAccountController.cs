using Micro.Banking.Application.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Micro.Transfer.Application.Interfaces;
using Micro.Transfer.Domain.Models;

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
        public ActionResult<IEnumerable<AccountTransferLog>> GetAllAccount()
        {
            return Ok(_transferAccountService.GetAllAccountsTransferLog());
        }

//        [HttpPost]
//        public IActionResult Post([FromBody]AccountTransfer accountTransfer)
//        {
//            _accountService.Transfer(accountTransfer);
//            return Ok(accountTransfer);
//        }
    }
}
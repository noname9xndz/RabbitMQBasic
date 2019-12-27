using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Micro.Banking.Application.Interfaces;
using Micro.Banking.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Micro.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        // GET: api/Banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> GetAllAccount()
        {
            return Ok(_accountService.GetAllAccounts());
        }

    }
}

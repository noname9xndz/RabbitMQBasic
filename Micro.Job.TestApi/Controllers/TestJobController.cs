using Micro.Common;
using Micro.Job.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Micro.Job.TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestJobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public TestJobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        // GET: api/TestJob
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TestJob/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TestJob
        [HttpPost]
        public async Task<IActionResult> GetTranferByStatus([FromBody] PaymentStatus paymentStatus)
        {
            var model = await _jobService.GetAllTransferByPaymentStatus(paymentStatus);
            return Ok(model);
        }
    }
}
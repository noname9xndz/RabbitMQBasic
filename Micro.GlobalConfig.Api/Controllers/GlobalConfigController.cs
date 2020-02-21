﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Micro.GlobalConfig.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GlobalConfigController : ControllerBase
    {
        // GET: api/GlobalConfig
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GlobalConfig/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GlobalConfig
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/GlobalConfig/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
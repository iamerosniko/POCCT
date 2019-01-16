using BackendConnector.Controllers;
using BackendConnector.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CallTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallsController : ControllerBase
    {
        CallsBWController callsbw;
        public CallsController()
        {
            callsbw = new CallsBWController(Startup.Configuration["Internal:APIURL"]);
        }
        // GET: api/Calls
        [HttpGet]
        public async Task<IEnumerable<CtdCalls>> Get()
        {
            return await callsbw.Get();
        }

        // GET: api/Calls/5
        [HttpGet("{id}")]
        public async Task<CtdCalls> Get(string id)
        {
            return await callsbw.Get(id);
        }

        // POST: api/Calls
        [HttpPost]
        public async Task<CtdCalls> Post([FromBody] CtdCalls call)
        {
            return await callsbw.Post(call);
        }

        // PUT: api/Calls/5
        [HttpPut]
        public async Task<CtdCalls> Put([FromBody] CtdCalls call)
        {
            return await callsbw.Put(call);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<CtdCalls> Delete(string id)
        {
            return await callsbw.Delete(id);
        }
    }
}

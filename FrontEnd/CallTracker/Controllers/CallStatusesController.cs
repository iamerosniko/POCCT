using BackendConnector.Controllers;
using BackendConnector.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CallTracker.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CORS")]
    [ApiController]
    public class CallStatusesController : ControllerBase
    {
        CallBWStatusesController callStatusesbw;
        public CallStatusesController()
        {
            callStatusesbw = new CallBWStatusesController(Startup.Configuration["Internal:APIURL"]);
        }
        // GET: api/Calls
        [HttpGet]
        public async Task<IEnumerable<CtdCallStatuses>> Get()
        {
            return await callStatusesbw.Get();
        }

        // GET: api/Calls/5
        [HttpGet("{id}")]
        public async Task<CtdCallStatuses> Get(string id)
        {
            return await callStatusesbw.Get(id);
        }

        // POST: api/Calls
        [HttpPost]
        public async Task<CtdCallStatuses> Post([FromBody] CtdCallStatuses callStatus)
        {
            return await callStatusesbw.Post(callStatus);
        }

        // PUT: api/Calls/5
        [HttpPut]
        public async Task<CtdCallStatuses> Put([FromBody] CtdCallStatuses callStatus)
        {
            return await callStatusesbw.Put(callStatus);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<CtdCallStatuses> Delete(string id)
        {
            return await callStatusesbw.Delete(id);
        }
    }
}

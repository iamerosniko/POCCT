using BackendConnector.Controllers;
using BackendConnector.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CallTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallerAssocsController : ControllerBase
    {
        CallerBWAssocsController callerAssocssbw;
        public CallerAssocsController()
        {
            callerAssocssbw = new CallerBWAssocsController(Startup.Configuration["Internal:APIURL"]);
        }
        // GET: api/Calls
        [HttpGet]
        public async Task<IEnumerable<CtdCallerAssocs>> Get()
        {
            return await callerAssocssbw.Get();
        }

        // GET: api/Calls/5
        [HttpGet("{id}")]
        public async Task<CtdCallerAssocs> Get(string id)
        {
            return await callerAssocssbw.Get(id);
        }

        // POST: api/Calls
        [HttpPost]
        public async Task<CtdCallerAssocs> Post([FromBody] CtdCallerAssocs callAssoc)
        {
            return await callerAssocssbw.Post(callAssoc);
        }

        // PUT: api/Calls/5
        [HttpPut]
        public async Task<CtdCallerAssocs> Put([FromBody] CtdCallerAssocs callAssoc)
        {
            return await callerAssocssbw.Put(callAssoc);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<CtdCallerAssocs> Delete(string id)
        {
            return await callerAssocssbw.Delete(id);
        }
    }
}

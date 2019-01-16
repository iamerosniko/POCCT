using BackendConnector.Controllers;
using BackendConnector.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CallTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallCategoriesController : ControllerBase
    {
        CallBWCategoriesController callerCategoriessbw;
        public CallCategoriesController()
        {
            callerCategoriessbw = new CallBWCategoriesController(Startup.Configuration["Internal:APIURL"]);
        }
        // GET: api/Calls
        [HttpGet]
        public async Task<IEnumerable<CtdCallCategories>> Get()
        {
            return await callerCategoriessbw.Get();
        }

        // GET: api/Calls/5
        [HttpGet("{id}")]
        public async Task<CtdCallCategories> Get(string id)
        {
            return await callerCategoriessbw.Get(id);
        }

        // POST: api/Calls
        [HttpPost]
        public async Task<CtdCallCategories> Post([FromBody] CtdCallCategories callCategories)
        {
            return await callerCategoriessbw.Post(callCategories);
        }

        // PUT: api/Calls/5
        [HttpPut]
        public async Task<CtdCallCategories> Put([FromBody] CtdCallCategories callCategories)
        {
            return await callerCategoriessbw.Put(callCategories);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<CtdCallCategories> Delete(string id)
        {
            return await callerCategoriessbw.Delete(id);
        }
    }
}

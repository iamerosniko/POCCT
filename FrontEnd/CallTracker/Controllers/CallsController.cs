using BackendConnector.Controllers;
using BackendConnector.Entities;
using CallTracker.Models.DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CallTracker.Controllers
{
    [EnableCors("CORS")]
    [Route("api/[controller]")]
    [ApiController]
    public class CallsController : ControllerBase
    {
        CallsBWController callsbw;
        CallerBWAssocsController callAssocsbw;
        CallBWStatusesController callStatusesbw;
        CallBWCategoriesController callCategoriesbw;
        public CallsController()
        {
            callsbw = new CallsBWController(Startup.Configuration["Internal:APIURL"]);
            callAssocsbw = new CallerBWAssocsController(Startup.Configuration["Internal:APIURL"]);
            callStatusesbw = new CallBWStatusesController(Startup.Configuration["Internal:APIURL"]);
            callCategoriesbw = new CallBWCategoriesController(Startup.Configuration["Internal:APIURL"]);
        }
        // GET: api/Calls
        [HttpGet]
        public async Task<List<CTDCalls_DTO>> Get()
        {
            List<CTDCalls_DTO> ctdCalls = new List<CTDCalls_DTO>(); 
            var calls = await callsbw.Get();
            var callCategories = await callCategoriesbw.Get();
            var callStatuses = await callStatusesbw.Get();
            var callAssocs = await callAssocsbw.Get();

            foreach(var call in calls)
            {
                try
                {
                    var categ = callCategories.Find(x => x.CallCategoryID == call.CallCategoryID);
                    var status = callStatuses.Find(x => x.CallStatusID == call.CallStatusID);
                    var assoc = callAssocs.Find(x => x.CallerAssocID == call.CallerAssocID);

                    ctdCalls.Add(new CTDCalls_DTO
                    {
                        CallCategory = categ.CallCategoryDesc,
                        CallerAssocID = call.CallerAssocID,
                        CallCategoryID = call.CallCategoryID,
                        CallerAssoc = assoc.CallerAssocDesc,
                        CallerPhone = call.CallerPhone,
                        CallID = call.CallID,
                        CallStatus = status.CallStatusDesc,
                        CallStatusID = call.CallStatusID,
                        DateOfCall = call.DateOfCall,
                        user_name = call.user_name,
                    });
                }
                catch
                {

                }
            }
            return ctdCalls;
        }

        // GET: api/Calls/5
        [HttpGet("{id}")]
        public async Task<CTDCalls_DTO> Get(int id)
        {
            var calls = await Get();
            return calls.Find(x => x.CallID == id);
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

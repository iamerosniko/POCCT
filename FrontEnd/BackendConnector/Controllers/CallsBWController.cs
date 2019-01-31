using BackendConnector.Entities;
using BackendConnector.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendConnector.Controllers
{
    public class CallsBWController
    {
        APIAccess _apiAccess;

        public CallsBWController(string apiUrl)
        {
            _apiAccess = new APIAccess("Calls", apiUrl);
            //_apiAccess = new APIAccess("Calls", "https://localhost:44355/api/");
        }
        [HttpGet]
        public async Task<List<CtdCalls>> Get()
        {
            var result = await _apiAccess.GetRequest();
            var Calls = JsonConvert.DeserializeObject<List<CtdCalls>>(result);
            return Calls;
        }
        [HttpGet("{CallID}")]
        public async Task<CtdCalls> Get(string CallID)
        {
            var result = await _apiAccess.GetRequest(CallID);
            var Call = result == null ? new CtdCalls() : JsonConvert.DeserializeObject<CtdCalls>(result);
            return Call;
        }

        [HttpPost]
        public async Task<CtdCalls> Post(CtdCalls call)
        {
            var body = JsonConvert.SerializeObject(call);
            var result = await _apiAccess.PostRequest(body);
            var Call = JsonConvert.DeserializeObject<CtdCalls>(result);
            return Call;
        }

        [HttpPut]
        public async Task<CtdCalls> Put(CtdCalls call)
        {
            var body = JsonConvert.SerializeObject(call);
            var result = await _apiAccess.PutRequest(call.CallID.ToString(), body);
            return await Get(call.CallID.ToString());
        }

        [HttpDelete("{CallID}")]
        public async Task<CtdCalls> Delete(string CallID)
        {
            var result = await _apiAccess.DeleteRequest(CallID);
            var Call = JsonConvert.DeserializeObject<CtdCalls>(result);
            return Call;
        }
    }
}

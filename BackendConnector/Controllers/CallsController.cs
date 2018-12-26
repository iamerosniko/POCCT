using BackendConnector.Entities;
using BackendConnector.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendConnector.Controllers
{
    public class CallsController
    {
        APIAccess _apiAccess;

        public CallsController()
        {
            _apiAccess = new APIAccess("Calls", "https://ctapi.apps.cac.preview.pcf.manulife.com/api/");
        }
        //public async void Get()
        public async Task<List<CtdCalls>> Get()
        {
            var result = await _apiAccess.GetRequest();
            var Calls = JsonConvert.DeserializeObject<List<CtdCalls>>(result);
            return Calls;
        }
        public async Task<CtdCalls> Get(string CallID)
        {
            var result = await _apiAccess.GetRequest(CallID);
            var Call = JsonConvert.DeserializeObject<CtdCalls>(result);
            return Call;
        }

        public async Task<CtdCalls> Post(CtdCalls call)
        {
            var body = JsonConvert.SerializeObject(call);
            var result = await _apiAccess.PostRequest(body);
            var Call = JsonConvert.DeserializeObject<CtdCalls>(result);
            return Call;
        }

        public async Task<CtdCalls> Put(CtdCalls call)
        {
            var body = JsonConvert.SerializeObject(call);
            var result = await _apiAccess.PutRequest(call.CallID.ToString(), body);
            return await Get(call.CallID.ToString());
        }

        public async Task<CtdCalls> Delete(string CallID)
        {
            var result = await _apiAccess.DeleteRequest(CallID);
            var Call = JsonConvert.DeserializeObject<CtdCalls>(result);
            return Call;
        }
    }
}

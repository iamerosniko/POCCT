using BackendConnector.Entities;
using BackendConnector.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendConnector.Controllers
{
    public class CallBWStatusesController
    {
        APIAccess _apiAccess;

        public CallBWStatusesController(string apiUrl)
        {
            _apiAccess = new APIAccess("CallStatuses", apiUrl);
        }
        //public async void Get()
        public async Task<List<CtdCallStatuses>> Get()
        {
            var result = await _apiAccess.GetRequest();
            var Calls = JsonConvert.DeserializeObject<List<CtdCallStatuses>>(result);
            return Calls;
        }
        public async Task<CtdCallStatuses> Get(string callStatusID)
        {
            var result = await _apiAccess.GetRequest(callStatusID);
            var Call = result == null ? new CtdCallStatuses() : JsonConvert.DeserializeObject<CtdCallStatuses>(result);
            return Call;
        }

        public async Task<CtdCallStatuses> Post(CtdCallStatuses callstatus)
        {
            var body = JsonConvert.SerializeObject(callstatus);
            var result = await _apiAccess.PostRequest(body);
            var Call = JsonConvert.DeserializeObject<CtdCallStatuses>(result);
            return Call;
        }

        public async Task<CtdCallStatuses> Put(CtdCallStatuses callstatus)
        {
            var body = JsonConvert.SerializeObject(callstatus);
            var result = await _apiAccess.PutRequest(callstatus.CallStatusID.ToString(), body);
            return await Get(callstatus.CallStatusID.ToString());
        }

        public async Task<CtdCallStatuses> Delete(string Callstatusid)
        {
            var result = await _apiAccess.DeleteRequest(Callstatusid);
            var Call = JsonConvert.DeserializeObject<CtdCallStatuses>(result);
            return Call;
        }
    }
}

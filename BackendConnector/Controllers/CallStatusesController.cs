using BackendConnector.Entities;
using BackendConnector.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendConnector.Controllers
{
    public class CallStatusesController
    {
        APIAccess _apiAccess;

        public CallStatusesController()
        {
            _apiAccess = new APIAccess("CallStatuses", "https://ctapi.apps.cac.preview.pcf.manulife.com/api/");
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
            var Call = JsonConvert.DeserializeObject<CtdCallStatuses>(result);
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

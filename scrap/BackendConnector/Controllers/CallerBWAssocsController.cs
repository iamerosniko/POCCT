using BackendConnector.Entities;
using BackendConnector.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendConnector.Controllers
{
    public class CallerBWAssocsController
    {
        APIAccess _apiAccess;

        public CallerBWAssocsController()
        {
            _apiAccess = new APIAccess("CallerAssocs", "https://ctapi.apps.cac.preview.pcf.manulife.com/api/");
        }
        //public async void Get()
        public async Task<List<CtdCallerAssocs>> Get()
        {
            var result = await _apiAccess.GetRequest();
            var Calls = JsonConvert.DeserializeObject<List<CtdCallerAssocs>>(result);
            return Calls;
        }
        public async Task<CtdCallerAssocs> Get(string callAssocID)
        {
            var result = await _apiAccess.GetRequest(callAssocID);
            var Call = JsonConvert.DeserializeObject<CtdCallerAssocs>(result);
            return Call;
        }

        public async Task<CtdCallerAssocs> Post(CtdCallerAssocs callAssoc)
        {
            var body = JsonConvert.SerializeObject(callAssoc);
            var result = await _apiAccess.PostRequest(body);
            var Call = JsonConvert.DeserializeObject<CtdCallerAssocs>(result);
            return Call;
        }

        public async Task<CtdCallerAssocs> Put(CtdCallerAssocs callAssoc)
        {
            var body = JsonConvert.SerializeObject(callAssoc);
            var result = await _apiAccess.PutRequest(callAssoc.CallerAssocID.ToString(), body);
            return await Get(callAssoc.CallerAssocID.ToString());
        }

        public async Task<CtdCallerAssocs> Delete(string callAssocID)
        {
            var result = await _apiAccess.DeleteRequest(callAssocID);
            var Call = JsonConvert.DeserializeObject<CtdCallerAssocs>(result);
            return Call;
        }
    }
}

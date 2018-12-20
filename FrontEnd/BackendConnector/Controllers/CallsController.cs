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
            var a = await _apiAccess.GetRequest();
            var Calls = JsonConvert.DeserializeObject<List<CtdCalls>>(a);
            return Calls;
        }
    }
}

using BackendConnector.Entities;
using BackendConnector.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendConnector.Controllers
{
    public class CallCategoriesController
    {
        APIAccess _apiAccess;

        public CallCategoriesController()
        {
            _apiAccess = new APIAccess("CallCategories", "https://ctapi.apps.cac.preview.pcf.manulife.com/api/");
        }
        //public async void Get()
        public async Task<List<CtdCallCategories>> Get()
        {
            var result = await _apiAccess.GetRequest();
            var Calls = JsonConvert.DeserializeObject<List<CtdCallCategories>>(result);
            return Calls;
        }
        public async Task<CtdCallCategories> Get(string CallCategoryID)
        {
            var result = await _apiAccess.GetRequest(CallCategoryID);
            var Call = JsonConvert.DeserializeObject<CtdCallCategories>(result);
            return Call;
        }

        public async Task<CtdCallCategories> Post(CtdCallCategories callcategory)
        {
            var body = JsonConvert.SerializeObject(callcategory);
            var result = await _apiAccess.PostRequest(body);
            var Call = JsonConvert.DeserializeObject<CtdCallCategories>(result);
            return Call;
        }

        public async Task<CtdCallCategories> Put(CtdCallCategories callcategory)
        {
            var body = JsonConvert.SerializeObject(callcategory);
            var result = await _apiAccess.PutRequest(callcategory.CallCategoryID.ToString(), body);
            return await Get(callcategory.CallCategoryID.ToString());
        }

        public async Task<CtdCallCategories> Delete(string CallCategoryID)
        {
            var result = await _apiAccess.DeleteRequest(CallCategoryID);
            var Call = JsonConvert.DeserializeObject<CtdCallCategories>(result);
            return Call;
        }
    }
}

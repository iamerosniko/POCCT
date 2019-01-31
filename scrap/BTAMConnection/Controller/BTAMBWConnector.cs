using BTAMConnection.Controller.Services;
using BTAMConnection.Entities;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace BTAMConnection.Controller
{
    public class BTAMBWConnector
    {
        private APIAccess _apiAccess;
        private string _controller;
        private string _apiUrl;
        public BTAMBWConnector()
        {
            StreamReader file = new StreamReader(@".\BTAMConnection.txt");
            _apiUrl = file.ReadLine();
            _controller = "SingleSignIn";
        }

        public string getApiUrl()
        {
            return _apiUrl;
        }

        public async Task<CurrentUser> GetAppSignIn(AppSignIn appSignIn)
        {
            _apiAccess = new APIAccess("AppSignIn2", getApiUrl());
            var body = JsonConvert.SerializeObject(appSignIn);
            var result = await _apiAccess.PostRequest(body);
            CurrentUser user = JsonConvert.DeserializeObject<CurrentUser>(result);
            return user;
        }
        //Authenticate/{appSecurityKey}
        public async Task<AppToken> Authenticate(string appSecurityKey, CurrentUser user)
        {
            _apiAccess = new APIAccess("Authenticate/" + appSecurityKey, getApiUrl());
            var body = JsonConvert.SerializeObject(user);
            var result = await _apiAccess.PostRequest(body);
            AppToken authenticationToken = JsonConvert.DeserializeObject<AppToken>(result);
            return authenticationToken;
        }

    }
}

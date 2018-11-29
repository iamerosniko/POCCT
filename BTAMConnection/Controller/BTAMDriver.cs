using BTAMConnection.Entities;

namespace BTAMConnection.Controller
{
    public class BTAMDriver
    {
        private TokenFactory _tokenFactory;
        #region API
        //[Route("GetUserName")]
        //[HttpGet]
        public CurrentUser GetSignInUsername()
        {
            var username = "";
            //var username = this.User.Identity.Name;

            return new CurrentUser
            {
                UserName = username
            };
        }

        //[HttpGet("GetBTAMURL")]
        public BTAMEntity Get()
        {
            return new BTAMEntity
            {
                BTAMURL = ""
                //Startup.Configuration["BTAMURL"]
            };
        }

        //[Route("GetAuthorizationUser")]
        //[HttpPost]
        //public async Task<AppToken> GetAuthorizationToken([FromBody] string authenticationtoken)
        public AppToken GetAuthorizationToken(AppToken authenticationToken)
        {
            _tokenFactory = new TokenFactory();

            if (authenticationToken.Token != "")
            {
                //1)Extracttoken is used to extract all details required before generating an authorization token
                //2)GenerateAuthorizationToken is used to generate Authorization token
                var authorizationToken = _tokenFactory.GenerateAuthorizationToken(_tokenFactory.ExtractToken(authenticationToken.Token));

                return new AppToken
                {
                    Token = authorizationToken,
                    TokenName = "Authorization"
                };
            }
            return new AppToken
            {
                TokenName = "Authorization"
            };
        }
        #endregion
    }
}

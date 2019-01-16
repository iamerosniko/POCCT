using System;

namespace CallTracker.Models.BTAMEntities
{
    public class AppToken
    {
        public String TokenName { get; set; }
        public String Token { get; set; }
        public AppToken()
        {
            Token = "";
            TokenName = "";
        }
    }
}

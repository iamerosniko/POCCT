using BackendConnector.Controllers;
using BackendConnector.Entities;
using BTAMConnection.Controller;
using BTAMConnection.Entities;
using System;
using System.Windows.Forms;
namespace FrontEnd
{
    public partial class Main : Form
    {
        public string AUTHORIZATIONTOKEN;

        public Main()
        {
            InitializeComponent();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            BTAMBWConnector con = new BTAMBWConnector();
            BTAMDriver driver = new BTAMDriver();
            //get btam url -done
            BTAMEntity btam = new BTAMEntity { BTAMURL = con.getApiUrl() };
            //get username -done
            //CurrentUser user = new CurrentUser { UserName = "ambrjoe" };
            CurrentUser user = new CurrentUser { UserName = Environment.UserName };
            //get host
            string host = "calltracker";
            //get appsignin
            AppSignIn appSignIn = new AppSignIn { UserName = user.UserName, AppURL = host };
            //getAppSignIn - btam
            this.Text = "Authenticating";
            var resultUser = await con.GetAppSignIn(appSignIn);

            if (resultUser != null)
            {
                user = resultUser;
            }
            if (!user.Role.Equals("NoAccess"))
            {
                //get authenticationToken
                var AuthenticationToken = await con.Authenticate("c9567d84-7626-392a-0698-ebd0d5504f8f", user);
                //get authorizationToken
                this.Text = "Authorizing";
                var AuthorizationToken = driver.GetAuthorizationToken(AuthenticationToken);
                //save to main apps 
                AUTHORIZATIONTOKEN = AuthorizationToken.Token;
            }
            else
            {
                MessageBox.Show("no access");
                this.Close();
            }
            //MessageBox.Show("Welcome!\n" + user.FirstName + " " + user.LastName + ".\nYour Details for this app is: \nROLE:" + user.Role);
            this.Text = "Welcome " + user.FirstName + " " + user.LastName + "! (" + user.Role + ")";


            CallsBWController callsController = new CallsBWController();
            CallBWCategoriesController callCategoriesController = new CallBWCategoriesController();
            CallBWStatusesController callStatusesController = new CallBWStatusesController();
            CallerBWAssocsController callerAssocsController = new CallerBWAssocsController();

            var CallList = await callsController.Get();
            var CallCategList = await callCategoriesController.Get();
            var CallerAssocList = await callerAssocsController.Get();
            var CallStatusList = await callStatusesController.Get();

            GridCalls.DataSource = CallList;
            GridCallerAssocs.DataSource = CallerAssocList;
            GridCallCategories.DataSource = CallCategList;
            GridCallStatuses.DataSource = CallStatusList;

            CtdCallsDTO sCalls = new CtdCallsDTO
            {
                CallCategoryID = 3,
                CallerAssocID = 1,
                CallerPhone = "12345678",
                CallStatusID = 5,
                DateOfCall = DateTime.Now,
                user_name = "alverer"
            };

            //var res = await callsController.Post(sCalls);
        }
    }
}

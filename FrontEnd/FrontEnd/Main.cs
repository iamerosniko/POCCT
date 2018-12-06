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



        }
    }
}

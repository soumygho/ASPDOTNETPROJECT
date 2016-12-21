using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocialNetworkingSiteLibrary;

public partial class userdetails : System.Web.UI.Page
{
    RegistrationService.RegistrationWebService registrationservice = new RegistrationService.RegistrationWebService();
    ClassConvertClientDataToServerSideData clienttoserver = new ClassConvertClientDataToServerSideData();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            ClassUserId id = new ClassUserId();
            id.Userid = Int32.Parse(Request.QueryString["id"]);
            RegistrationService.ClassUserDetails userdetails = registrationservice.getUserDetails(clienttoserver.convertToServerSideClassUserId(id));
            if (userdetails != null)
            {
                List<RegistrationService.ClassUserDetails> userDetailsList = new List<RegistrationService.ClassUserDetails>();
                userDetailsList.Add(userdetails);
                DataPagerRepeater2.DataSource = userDetailsList;
                DataPagerRepeater2.DataBind();
            }
        }
    }
    protected void DataPagerRepeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
}

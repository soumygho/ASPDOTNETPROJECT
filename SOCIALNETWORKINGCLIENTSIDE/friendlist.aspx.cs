using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocialNetworkingSiteLibrary;

public partial class friendlist : System.Web.UI.Page
{
    PostHandlerService.PostHandlerWebService posthandlerService = new PostHandlerService.PostHandlerWebService();
    PostHandlerService.ClassUserId userid = null;
    ClassConvertClientDataToServerSideData clienttoserver = new ClassConvertClientDataToServerSideData();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
           RegistrationService.ClassUserId id = new RegistrationService.ClassUserId();
            id.Userid = Int32.Parse(Request.QueryString["id"]);
            userid = clienttoserver.convertToServerSideClassUserId(id);
            if (posthandlerService.getAllFriendList(userid) != null)
            {
                DataPagerRepeater3.DataSource = posthandlerService.getAllFriendList(userid);
                DataPagerRepeater3.DataBind();
            }
        }
    }
}

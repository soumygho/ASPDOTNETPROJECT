using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocialNetworkingSiteLibrary;
using System.Collections;

public partial class searchResult : System.Web.UI.Page
{
    PostHandlerService.PostHandlerWebService posthandlerService = new PostHandlerService.PostHandlerWebService();
    RegistrationService.RegistrationWebService registrationservice = new RegistrationService.RegistrationWebService();
    ClassConvertClientDataToServerSideData clienttoserver = new ClassConvertClientDataToServerSideData();
    PostHandlerService.ClassFriend friend = null;
    PostHandlerService.ClassUserId userid = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            if (posthandlerService.getSearchResult(Request.QueryString["q"].ToString()) != null)
            {
                
                List<PostHandlerService.ClassUserId> useridList = new List<PostHandlerService.ClassUserId>( posthandlerService.getSearchResult(Request.QueryString["q"].ToString()));
                DataPagerRepeater1.DataSource = useridList;
                DataPagerRepeater1.DataBind();
            }
        }
        else
        {
            Response.Redirect("~//index.aspx");
        }
    }
}

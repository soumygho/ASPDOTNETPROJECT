using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SocialNetworkingSiteLibrary;

/// <summary>
/// Summary description for RegistrationWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class RegistrationWebService : System.Web.Services.WebService {
    
    public RegistrationWebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod(EnableSession=true)]
    public bool registerUser(ClassUserId userid)
    {
        bool flag = false;
        if (Session["user"] == null)
        {
           
            ClassFolderOperation folderops;
            try
            {

                folderops = new ClassFolderOperation(Server.MapPath("~/"));

                folderops.registerUser(userid);
                flag = true;
                Session["user"] = userid;

            }
            catch (Exception em)
            {

            }
        }
        return flag;
    }

    ClassDatabaseOperation dbOps = null;
    [WebMethod(EnableSession = true)]
    public ClassUserId login(ClassUserId userid)
    {
        
        dbOps = new ClassDatabaseOperation();
        try
        {
            userid = dbOps.readUserMasterDB(userid, Server.MapPath("~/") + "//DATABASE//MASTERUSERDB//UserMasterDB.mdb");
           
            if (userid != null)
            {
                ClassUserDetails user = dbOps.readUserDetails(userid, Server.MapPath("~/") + "//USER//" + userid.Userid + "//userdetails//userdetails.mdb");
                userid.Profname = user.Name;
                Session["user"] = userid;
                
            }
        }
        catch (Exception e)
        {
        }
        return userid;
    }

    [WebMethod(EnableSession = true)]
    public ClassUserId getSessionValue()
    {
        ClassUserId userid = null;
        userid = (ClassUserId)Session["user"];
        return userid;
    }
    
}


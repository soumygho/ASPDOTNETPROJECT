using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Services;
using System.Collections;
using System.IO;
using SocialNetworkingSiteLibrary;

/// <summary>
/// Summary description for PostHandlerWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class PostHandlerWebService : System.Web.Services.WebService {
    ClassDatabaseOperation dbOps = new ClassDatabaseOperation();

    public PostHandlerWebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod(EnableSession=true)]
    public List<ClassPostDetails> constructUserWall(ClassUserId userid)
    {
        List<ClassPostDetails> userwallList = null;
        if (userid != null)
        {
            try
            {
                userwallList = dbOps.readPostsByUserId(userid, Server.MapPath("~//"));
            }
            catch (Exception e)
            {
            }
        }
        
        return userwallList;
    }
    [WebMethod(EnableSession=true)]
    public bool shareNewPost(ClassUserId userid,ClassPostDetails post)
    {
        bool flag = false;

        if (userid != null)
        {
            try
            {
                post.UserId = userid.Userid;
                post.ProfName = userid.Profname;
               flag =  dbOps.insertInToMasterPostDb(post, Server.MapPath("~//"));
                int postid = 0;
               if (flag)
               {
                   postid = dbOps.getPostId(userid.Userid, Server.MapPath("~//")+"USER//" + userid.Userid + "//" + "posts" + "//" + "post.mdb")-1;
                   string url = Server.MapPath("~//")+"USER//"+userid.Userid+"//postsdetails//";
                   string baseurl = Server.MapPath("~//")+"DATABASE//POSTDETAILS//";
                   File.Copy(baseurl+"comment.mdb",url+"comment"+postid+".mdb");
                   File.Copy(baseurl+"like.mdb",url+"like"+postid+".mdb");
               }
                
            }
            catch (Exception e)
            {
            }
        }

        return flag;
    }

    [WebMethod(EnableSession = true)]
    public bool setSessionValue(ClassUserId userid)
    {
        bool flag = false;
        if (userid != null)
        {
            Session["user"] = userid;
            flag = true;
        }
        return flag;
    }
    
    
}


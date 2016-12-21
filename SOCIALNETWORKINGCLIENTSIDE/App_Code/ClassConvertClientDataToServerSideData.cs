using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocialNetworkingSiteLibrary;
/// <summary>
/// Summary description for ClassConvertClientDataToServerSideData
/// </summary>
public class ClassConvertClientDataToServerSideData
{
	public ClassConvertClientDataToServerSideData()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public PostHandlerService.ClassPostDetails convertToServerSidePostDetails(ClassPostDetails post)
    {
        PostHandlerService.ClassPostDetails serverpost = new PostHandlerService.ClassPostDetails();
        serverpost.Postcaption = post.Postcaption;
        serverpost.Postdate = post.Postdate;
        serverpost.Postid = post.Postid;
        serverpost.Postimageurl = post.Postimageurl;
        serverpost.Postlike = post.Postlike;
        serverpost.Postlink = post.Postlink;
        serverpost.Posttype = post.Posttype;
        serverpost.UserId = post.UserId;
        return serverpost;
    }

   public PostHandlerService.ClassPostDetails convertToServerSideCommentList(ClassPostDetails post)
    {
         PostHandlerService.ClassPostDetails serverpost = null;
        /*for (int i = 0; i <  i++)
        {
            ClassComment comment = post.commentlist[i];
           
        }*/
            return serverpost;
    }

    

public RegistrationService.ClassUserId convertToServerSideClassUserId(ClassUserId userid)
{
 	    RegistrationService.ClassUserId userId = null;
        userId = new RegistrationService.ClassUserId();
        userId.Name = userid.Name;
        userId.Password = userid.Password;
        userId.Doj = userid.Doj;
        userId.Email = userid.Email;
        userId.Activated = userid.Activated;
        userId.Profname = userid.Profname;
        userId.Userid = userid.Userid;
        return userId;
}
public PostHandlerService.ClassUserId convertToServerSideClassUserId(RegistrationService.ClassUserId userid)
{
    PostHandlerService.ClassUserId userId = null;
    userId = new PostHandlerService.ClassUserId();
    userId.Userid = userid.Userid; 
    userId.Name = userid.Name;
    userId.Password = userid.Password;
    userId.Doj = userid.Doj;
    userId.Email = userid.Email;
    userId.Activated = userid.Activated;
    userId.Profname = userid.Profname;
    return userId;
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocialNetworkingSiteLibrary;

/// <summary>
/// Summary description for ClassWallOperation
/// </summary>
public class ClassWallOperation
{
    ClassDatabaseOperation dbops = new ClassDatabaseOperation();
	public ClassWallOperation()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public bool refreshWall(ClassUserId userId,string baseurl)
    {
        bool flag = false;
        List<ClassPostDetails> temp = null;
        ClassPostDetails post = new ClassPostDetails();
        post.UserId = userId.Userid;
        post = dbops.readLastpostId(baseurl+"USER//"+userId.Userid+"//posts//lastpostid.mdb");
        if (post != null)
        {
            temp = dbops.readUserMasterDbForACirtainLimit(baseurl + "DATABASE//MASTERUSERDB//postmasterDB.mdb",post);
            if (temp != null)
            {
                List<ClassPostDetails> wallList = new List<ClassPostDetails>();
                for (int i = 0; i < temp.Count; i++)
                {
                    ClassPostDetails temppost = temp[i];
                    ClassUserId user = new ClassUserId();
                    user.Userid = temppost.UserId;
                    bool isfriend = dbops.checkIfFriend(user, baseurl + "USER//" + userId.Userid + "//friendlist//frienddatabase.mdb");
                    if (isfriend)
                    {
                        wallList.Add(temppost);
                    }
                }
                if (wallList.Count > 0)
                {
                    ClassPostDetails lastPost = null;
                    for (int i = 0; i < wallList.Count; i++)
                    {
                        ClassPostDetails temppost = wallList[i];
                        dbops.insertIntoWall(temppost, baseurl + "USER//" + userId.Userid + "//wall//wall.mdb");
                        lastPost = temppost;
                    }
                    if (lastPost != null)
                    {
                        flag = dbops.updatelastPostId(lastPost, baseurl + "USER//" + userId.Userid + "//posts//lastpostid.mdb");
                    }
                }
            }
        }
        return flag;
    }

    public List<ClassPostDetails> cunstructWallPost(ClassUserId userid,string baseurl)
    {
        List<ClassPostDetails> wallList = null;
        wallList = dbops.readWall(baseurl + "USER//" + userid.Userid + "//wall//wall.mdb");
        if (wallList != null && wallList.Count > 0)
        {
            for (int i = 0; i < wallList.Count; i++)
            {
                ClassPostDetails post = wallList[i];
                string url = baseurl + "USER//" + post.Postid + "//posts//post.mdb";
                wallList[i] = dbops.readPostDetailsByPostIDandUserId(post, url);
            }


        }
        return wallList;
    }

}

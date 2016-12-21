using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.OleDb;
using SocialNetworkingSiteLibrary;

/// <summary>
/// Summary description for ClassFolderOperation
/// </summary>
public class ClassFolderOperation 
{
    string baseurl = "";
    string parenturl = "";
    string parenturl1 ="";
    ClassDataBaseAccess databaseaccess = null;
    string databaseurl = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
    ClassDatabaseOperation databaseoperation = new ClassDatabaseOperation();
	public ClassFolderOperation(string url)
	{
        baseurl = url;
        parenturl1 = baseurl+"DATABASE" + "\\" + "USER DATABASE";
        parenturl = baseurl + "DATABASE" + "\\"+"MASTERUSERDB";
        databaseurl += url;
	}

    private bool createNewUserFolder(int userid)
    {
        bool flag = true;
        try
        {
            parenturl = baseurl +"USER" +"\\" + userid.ToString();
            Directory.CreateDirectory(parenturl);
            Directory.CreateDirectory(parenturl + "\\" + "image");
            Directory.CreateDirectory(parenturl + "\\" + "posts");
            Directory.CreateDirectory(parenturl+"\\"+"userdetails");
            Directory.CreateDirectory(parenturl + "\\" + "postsdetails");
            Directory.CreateDirectory(parenturl + "\\" + "timeline");
            Directory.CreateDirectory(parenturl + "\\" + "wall");
            Directory.CreateDirectory(parenturl + "\\" + "notification");
            Directory.CreateDirectory(parenturl + "\\" + "friendrequest");
            Directory.CreateDirectory(parenturl + "\\" + "friendlist");
            
            File.Copy(parenturl1+"\\"+"USER DETAILS"+"\\"+"userdetails.mdb",parenturl+"\\"+"userdetails"+"\\"+"userdetails.mdb");
            File.Copy(parenturl1 + "\\" + "POSTS"+"\\" + "post.mdb", parenturl + "\\" + "posts" + "\\" + "post.mdb");
            File.Copy(parenturl1 + "\\" + "POSTS" + "\\" + "postid.mdb", parenturl + "\\" + "posts" + "\\" + "postid.mdb");
            File.Copy(parenturl1 + "\\" + "POSTS" + "\\" + "lastpostid.mdb", parenturl + "\\" + "posts" + "\\" + "lastpostid.mdb");
            File.Copy(parenturl1 + "\\" + "FRIENDLIST" + "\\" + "frienddatabase.mdb", parenturl + "\\" + "friendlist" + "\\" + "frienddatabase.mdb");
            File.Copy(parenturl1 + "\\" + "TIMELINE" + "\\" + "timeline.mdb", parenturl + "\\" + "timeline" + "\\" + "timeline.mdb");
            File.Copy(parenturl1 + "\\" + "WALL" + "\\" + "wall.mdb", parenturl + "\\" + "wall" + "\\" + "wall.mdb");
            flag = false;
            

        }
        catch (Exception em)
        {

        }
        return flag;
    }

    public bool registerUser(ClassUserId userid)
    {
        bool flag = true;
        flag = databaseoperation.insertIntoUserMasterDb(userid, parenturl + "\\UserMasterDB.mdb");
        //E:\\MY PROJECTS\\ASP.NET PROJECT\\SOCIALNETWORKING\\DATABASE\\MASTERUSERDB\\UserMasterDB.mdb
        if (flag)
        {
            userid = databaseoperation.readUserMasterDB(userid, parenturl + "\\" + "UserMasterDB.mdb");
            if (userid.Userid != 0)
            {
                createNewUserFolder(userid.Userid);
                databaseoperation.insertintoUserDetails(userid, baseurl + "USER\\" + userid.Userid + "\\userdetails\\userdetails.mdb");
            }
        }
        return flag;
    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;
using System.Collections;
using SocialNetworkingSiteLibrary;

/// <summary>
/// Summary description for ClassDatabaseOperation
/// </summary>
public class ClassDatabaseOperation
{

    string databaseurl = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
    OleDbTransaction transaction = null;
    CreateDateClass createdate = new CreateDateClass();
	public ClassDatabaseOperation()
	{
		
	}
    private ClassDataBaseAccess getConnection (string url) 
    {
        ClassDataBaseAccess databaseaccess = null;
        bool flag = true;
        databaseaccess = new ClassDataBaseAccess(databaseurl+url);
       
            databaseaccess.con.Open();
           
        
        
            
        
           return databaseaccess;
    }

    private bool closeConnection(ClassDataBaseAccess databaseaccess)
    {
        bool flag = true;
        
        databaseaccess.con.Close();
        return flag;
    }

    private bool executeSelectCommandusingdr(string statement, ClassDataBaseAccess databaseaccess)
    {
        bool flag = true;
        databaseaccess.cmd = databaseaccess.con.CreateCommand();
        transaction = databaseaccess.con.BeginTransaction();
        databaseaccess.cmd.Connection = databaseaccess.con;
        databaseaccess.cmd.Transaction = transaction;
        databaseaccess.cmd.CommandText = statement;
        databaseaccess.dr = databaseaccess.cmd.ExecuteReader();
        transaction.Commit();
        return flag;
    }

    private bool executeSelectCommandusingda(string statement, ClassDataBaseAccess databaseaccess)
    {
        bool flag = true;
        databaseaccess.cmd = databaseaccess.con.CreateCommand();
        transaction = databaseaccess.con.BeginTransaction();
        databaseaccess.cmd.Connection = databaseaccess.con;
        databaseaccess.cmd.Transaction = transaction;
        databaseaccess.cmd.CommandText = statement;
        databaseaccess.da = new OleDbDataAdapter();
        databaseaccess.da.Fill(databaseaccess.dataset);
        transaction.Commit();
        return flag;
    }

    private bool executeQuery(string statement, ClassDataBaseAccess databaseaccess)
    {
        bool flag = true;
        databaseaccess.cmd = databaseaccess.con.CreateCommand();
        transaction = databaseaccess.con.BeginTransaction();
        databaseaccess.cmd.Connection = databaseaccess.con;
        databaseaccess.cmd.Transaction = transaction;
        databaseaccess.cmd.CommandText = statement;
        databaseaccess.cmd.ExecuteNonQuery();
        transaction.Commit();
        return flag;
    }

    private void handaleError(Exception em, ClassDataBaseAccess databaseaccess)
    {
        try
        {
            transaction.Rollback();
            throw em;
        }
        catch (Exception e)
        {
            throw e;
        }
    }
    public bool insertIntoUserMasterDb(ClassUserId userid,string url)
    {
        bool flag = true;
        userid.Doj = createdate.createDate(userid.Doj);
         ClassDataBaseAccess databaseaccess = null;
        String sql = "insert into userdetails (email,dateofjoining,activated,pwd) values('"+userid.Email+"',"+userid.Doj+",1,'"+userid.Password+"');";
        try
        {
          databaseaccess =   getConnection(url);
           executeQuery(sql,databaseaccess);
            flag = true;
        }
        catch (Exception e)
        {
            handaleError(e,databaseaccess);
        }
        finally
        {
            closeConnection(databaseaccess);
        }
        return flag;
    }

    public ClassUserId readUserMasterDB(ClassUserId userid, string url)
    {
        bool flag = true;
        ClassDataBaseAccess databaseaccess = null;
        try
        {
          databaseaccess =   getConnection(url);
            executeSelectCommandusingdr("select * from userdetails where email = '"+userid.Email+"' and pwd = '"+userid.Password+"';",databaseaccess);
            if (databaseaccess.dr.HasRows)
            {
                while (databaseaccess.dr.Read())
                {
                    userid.Activated = Int32.Parse(databaseaccess.dr["activated"].ToString());
                    userid.Doj = databaseaccess.dr["dateofjoining"].ToString();
                    userid.Email = databaseaccess.dr["email"].ToString();
                    userid.Userid = Int32.Parse( databaseaccess.dr["id"].ToString());
                    userid.Password = databaseaccess.dr["pwd"].ToString();
                }
            }
        }
        catch (Exception e)
        {
            handaleError(e,databaseaccess);
        }
        finally
        {
            closeConnection(databaseaccess);
        }
        return userid;
    }

    public ClassPostDetails readPostDetailsByPostIDandUserId(ClassPostDetails post, string url)
    {
        bool flag = true;
        ClassDataBaseAccess databaseaccess = null;
        try
        {
           databaseaccess =  getConnection(url);
            executeSelectCommandusingdr("select * from post where postid = '" + post.Postid + "';",databaseaccess);
            if (databaseaccess.dr.HasRows)
            {
                while (databaseaccess.dr.Read())
                {
                    post.Postcaption = databaseaccess.dr["caption"].ToString();
                }
            }
        }
        catch (Exception e)
        {
            handaleError(e,databaseaccess);
        }
        finally
        {
            closeConnection(databaseaccess);
        }
        return post;
    }

    public List<ClassPostDetails> readPostsByUserId(ClassUserId userid, string urlUserBase)
    {
        List<ClassPostDetails> postList = null;
        bool flag = false;
        ClassDataBaseAccess databaseaccess = null;
        try
        {
           databaseaccess = getConnection(urlUserBase+"USER//"+userid.Userid+"//"+"posts"+"//"+"post.mdb");
            executeSelectCommandusingdr("select * from post;",databaseaccess);
            if (databaseaccess.dr.HasRows)
            {
                flag = true;
                postList = new List<ClassPostDetails>();
                while (databaseaccess.dr.Read())
                {
                    ClassPostDetails post = new ClassPostDetails();
                    post.Postid = databaseaccess.dr["id"].ToString();
                    post.Postimageurl = databaseaccess.dr["imageid"].ToString();
                    post.UserId = userid.Userid;
                    post.ProfName = userid.Profname;
                    post.Postdate = databaseaccess.dr["postdate"].ToString();
                    post.Postlink = databaseaccess.dr["linkdetails"].ToString();
                    post.Posttype = databaseaccess.dr["posttype"].ToString();
                    post.Postcaption = databaseaccess.dr["caption"].ToString();
                    postList.Add(post);
                }
            }
        }
        catch (Exception e)
        {
            handaleError(e,databaseaccess);
        }
        finally
        {
            closeConnection(databaseaccess);
        }
        if (flag)
        {
            string url = urlUserBase + "//" + userid.Userid + "//" + "postdetails" + "//" + "post.mdb";
        }
        return postList;
    }

    public ClassPostDetails readPostDetails(ClassPostDetails post,string baseurl)
    {
        return post;
    }

    public List<ClassComment> getCommentDetails(ClassPostDetails post,string baseurl)
    {
        ClassDataBaseAccess databaseaccess = null;
        List<ClassComment> commentList = null;
        try
        {
            string url = baseurl + "//" + post.UserId + "//" + "postdetails" + "//" + post.Postid + "//" + "comment.mdb";
            
            databaseaccess = getConnection(url);
            executeSelectCommandusingdr("select * from commenttable;", databaseaccess);
            if (databaseaccess.dr.HasRows)
            {
                commentList = new List<ClassComment>();
                while (databaseaccess.dr.Read())
                {
                    ClassComment comment = new ClassComment();
                    comment.Commentdate = databaseaccess.dr["commentdate"].ToString();
                    comment.Comment = databaseaccess.dr["commentdetails"].ToString();
                    comment.Profid = databaseaccess.dr["profid"].ToString();
                    comment.Profname = databaseaccess.dr["profname"].ToString();
                    commentList.Add(comment);
                }
            }

        }
        catch (Exception e)
        {
            handaleError(e, databaseaccess);
        }
        finally
        {
            closeConnection(databaseaccess);
        }
        return commentList;
    }//user url

    public List<ClassLike> getLikeDetails(ClassPostDetails post, string baseurl)
    {
        ClassDataBaseAccess databaseaccess = null;
        List<ClassLike> likeList = null;
        try
        {
            string url = baseurl + "//" + post.UserId + "//" + "postdetails" + "//" + post.Postid + "//" + "like.mdb";
           
            databaseaccess = getConnection(url);
            executeSelectCommandusingdr("select * from postdetails;", databaseaccess);
            if (databaseaccess.dr.HasRows)
            {
                likeList = new List<ClassLike>();
                while (databaseaccess.dr.Read())
                {
                    ClassLike like = new ClassLike();
                    like.Profid = databaseaccess.dr["profid"].ToString();
                    like.Profname = databaseaccess.dr["profname"].ToString();
                    likeList.Add(like);
                }
            }

        }
        catch (Exception e)
        {
            handaleError(e, databaseaccess);
        }
        finally
        {
            closeConnection(databaseaccess);
        }
        return likeList;
    }//user url


    public bool insertInToMasterPostDb(ClassPostDetails post,string url)
    {
        bool flag = false;
        post.Postdate = createdate.createDate(post.Postdate);
        ClassDataBaseAccess databaseaccess = null;
        ClassDataBaseAccess userpostaccess = null;
        ClassDataBaseAccess userwallaccess = null;
        ClassDataBaseAccess usertimelineaccess = null;
        try
        {
            post.Postid = getPostId(post.UserId,url).ToString();
            updatePostId(post.UserId, url,Int32.Parse( post.Postid));
            userpostaccess = new ClassDataBaseAccess(databaseurl + url + "//" + "USER" + "//" + post.UserId + "//" + "posts" + "//" + "post.mdb");
            userpostaccess.con.Open();
            executeQuery("insert into post (postdate,caption,imageid,linkdetails,posttype,postid) values (" + post.Postdate + ",'" + post.Postcaption + "','" + post.Postimageurl + "','" + post.Postlink + "','" + post.Posttype + "'," + Int32.Parse(post.Postid) + ");", userpostaccess);

            databaseaccess = new ClassDataBaseAccess(databaseurl + url + "//" + "DATABASE" + "//" + "POSTS" + "//" + "postmasterDB.mdb");
            databaseaccess.con.Open();
            executeQuery("insert into post (postid,profid,postdate,posttype,profname) values (" + Int32.Parse(post.Postid) + "," + post.UserId + "," + post.Postdate + ",'" + post.Posttype + "','" + post.ProfName + "');", databaseaccess);

            userwallaccess = new ClassDataBaseAccess(databaseurl + url + "//" + "USER" + "//" + post.UserId + "//" + "wall" + "//" + "wall.mdb");
            userwallaccess.con.Open();
            executeQuery("insert into wall (postid,userid,isnew,postdate,profname) values ("+Int32.Parse(post.Postid)+","+post.UserId+",'yes',"+post.Postdate+",'"+post.ProfName+"');",userwallaccess);
            usertimelineaccess = new ClassDataBaseAccess(databaseurl + url + "//" + "USER" + "//" + post.UserId + "//" + "timeline" + "//" + "timeline.mdb");
            usertimelineaccess.con.Open();
            executeQuery("insert into timeline (postid,userid,isnew,postdate,profname) values (" + Int32.Parse(post.Postid) + "," + post.UserId + ",'yes'," + post.Postdate + ",'" + post.ProfName + "');", usertimelineaccess);
            post = readPostMasterDbByUserIdandPostId(post, url + "//" + "DATABASE" + "//" + "POSTS" + "//" + "postmasterDB.mdb");
            flag = true;
        }
        catch (Exception e)
        {
            if (databaseaccess != null)
            {
                handaleError(e, databaseaccess);
            }
            if (userpostaccess != null)
            {
                handaleError(e,userpostaccess);
            }
            if (userwallaccess != null)
            {
                handaleError(e,userwallaccess);
            }
            if (usertimelineaccess != null)
            {
                handaleError(e,usertimelineaccess);
            }
        }
        finally
        {
            if (databaseaccess != null)
            {
                closeConnection(databaseaccess);
            }
            if (userpostaccess != null)
            {
                closeConnection(userpostaccess);
            }
            if (userwallaccess != null)
            {
                closeConnection(userwallaccess);
            }
            if (usertimelineaccess != null)
            {
                closeConnection(usertimelineaccess);
            }
        }
        return flag;
    }


    public int getPostId(int userId,string url)
    {
        int postid = 0;
        ClassDataBaseAccess databaseaccess = null;
        try
        {
            //C:\inetpub\wwwroot\SOCIALNETWORKING\USER\3\posts\postid.mdb
            String baseurl = url + "USER//" + userId + "//" + "posts" + "//" + "postid.mdb";
            databaseaccess = new ClassDataBaseAccess(databaseurl+baseurl);
            databaseaccess.con.Open();
            executeSelectCommandusingdr("select * from postid;",databaseaccess);
            if (databaseaccess.dr.HasRows)
            {
                while (databaseaccess.dr.Read())
                {
                    postid = Int32.Parse(databaseaccess.dr["nextpostid"].ToString());
                }
            }
        }
        catch (Exception e)
        {
            handaleError(e, databaseaccess);
        }
        finally
        {
            closeConnection(databaseaccess);
        }
        return postid;
    }

    public bool updatePostId(int userId, string url,int postid)
    {
        url = databaseurl + url;
        postid++;
        bool flag = false;
        ClassDataBaseAccess databaseaccess = null;
        try
        {
            databaseaccess = new ClassDataBaseAccess(databaseurl+url + "USER//" + userId + "//" + "posts" + "//" + "postid.mdb");
            databaseaccess.con.Open();
            executeQuery("update postid set nextpostid = "+postid+" where id = 1 ;", databaseaccess);
            flag = true;
        }
        catch (Exception e)
        {
            handaleError(e, databaseaccess);
        }
        finally
        {
            closeConnection(databaseaccess);
        }
        return flag;
    }

    public List<ClassFriend> getAllFriendList(int userId, string url)
    {
       
        List<ClassFriend> friendlist = null;
        ClassDataBaseAccess databaseaccess = null;
        try
        {
            databaseaccess = getConnection(url + "USER//" + userId + "//" + "friendlist" + "//" + "frienddatabase.mdb");
            executeSelectCommandusingdr("select * from friendlist;", databaseaccess);
            if (databaseaccess.dr.HasRows)
            {
                while (databaseaccess.dr.Read())
                {
                    ClassFriend friend = new ClassFriend();
                    friend.Profid = databaseaccess.dr["profileid"].ToString();
                    friend.Name = databaseaccess.dr["profilename"].ToString();

                }
            }
        }
        catch (Exception e)
        {
            handaleError(e, databaseaccess);
        }
        finally
        {
            closeConnection(databaseaccess);
        }
        return friendlist;
    }


    public bool insertintoUserDetails(ClassUserId userid, String url)
    {
        ClassDataBaseAccess dbAccess = null;
        bool flag = false;
        try
        {
            dbAccess = getConnection(url);
            executeQuery("insert into userdetails (custname) values('" + userid.Name + "');", dbAccess);
            flag = true;
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            closeConnection(dbAccess);
        }
        return flag;
    }

    public ClassUserDetails readUserDetails(ClassUserId userid,String url)
    {
        ClassDataBaseAccess dbaccess = null;
         ClassUserDetails user  = null;
        try
        {
            dbaccess = getConnection(url);
            executeSelectCommandusingdr("select * from userdetails;", dbaccess);
            if (dbaccess.dr.HasRows)
            {
                user = new ClassUserDetails();
                while (dbaccess.dr.Read())
                {
                    user.Name = dbaccess.dr["custname"].ToString();
                    user.Mobno = dbaccess.dr["mobno"].ToString();
                    user.Occupation = dbaccess.dr["occupation"].ToString();
                    user.Schoolname = dbaccess.dr["schoolname"].ToString();
                    
                }
            }
        }
        catch (Exception e)
        {
            handaleError(e, dbaccess);
        }
        finally
        {
            closeConnection(dbaccess);
        }
        return user;
    }

    public ClassPostDetails readPostMasterDbByUserIdandPostId(ClassPostDetails post,String url)
    {
        ClassDataBaseAccess dbAccess = null;
        try
        {
            dbAccess = getConnection(url);
            executeSelectCommandusingdr("select * from post where postid = " + post.Postid + " and profid = " + post.UserId + ";", dbAccess);
            if (dbAccess.dr.HasRows)
            {
                while (dbAccess.dr.Read())
                {
                    post.ProfName = dbAccess.dr["profname"].ToString();
                    post.Id = Int32.Parse(dbAccess.dr["id"].ToString());
                    
                }
            }
        }
        catch (Exception e)
        {
            handaleError(e, dbAccess);
        }
        finally
        {
            closeConnection(dbAccess);
        }
        return post;
    }

    public bool updatelastPostId(ClassPostDetails post,string url)
    {
        bool flag = false;
        ClassDataBaseAccess dbAccess = null;
        try
        {
            dbAccess = getConnection(url);
            executeQuery("update lastpost set lastpostindex = "+post.Id+" where id = 1;",dbAccess);
            flag = true;
        }
        catch (Exception e)
        {
            handaleError(e, dbAccess);
        }
        finally
        {
            closeConnection(dbAccess);
        }
        return flag;
    }


    public List<ClassPostDetails> readUserMasterDbForACirtainLimit(string url,ClassPostDetails post)
    {
        List<ClassPostDetails> postList = null;
        ClassDataBaseAccess dbAccess = null;
        try
        {
            dbAccess = getConnection(url);
            executeSelectCommandusingdr("select * from post where id > " + post.Id + ";", dbAccess);
            if (dbAccess.dr.HasRows)
            {
                while (dbAccess.dr.Read())
                {
                }
            }

        }
        catch (Exception e)
        {
            handaleError(e, dbAccess);
        }
        finally
        {
            closeConnection(dbAccess);
        }
        return postList;
    }

    public bool insertIntoWall(ClassPostDetails post, string url)
    {
        bool flag = false;
        ClassDataBaseAccess dbAccess = null;
        try
        {
            dbAccess = getConnection(url);
            executeQuery("insert into wall (postid,userid,isnew,postdate,profname) values (" + Int32.Parse(post.Postid) + "," + post.UserId + ",'yes'," + post.Postdate + ",'" + post.ProfName + "');",dbAccess);
            flag = true;
        }
        catch (Exception e)
        {
            handaleError(e, dbAccess);
        }
        finally
        {
            closeConnection(dbAccess);
        }
        return flag;
    }

    public bool insertIntoTimeline(ClassPostDetails post, string url)
    {
        bool flag = false;
        ClassDataBaseAccess dbAccess = null;
        try
        {
            dbAccess = getConnection(url);
            executeQuery("insert into timeline (postid,userid,isnew,postdate,profname) values (" + Int32.Parse(post.Postid) + "," + post.UserId + ",'yes'," + post.Postdate + ",'" + post.ProfName + "');",dbAccess);
            flag = true;
        }
        catch (Exception e)
        {
            handaleError(e, dbAccess);
        }
        finally
        {
            closeConnection(dbAccess);
        }
        return flag;
    
    }

    public List<ClassPostDetails> readWall(string url)
    {
        ClassDataBaseAccess dbAccess = null;
        List<ClassPostDetails> postList = null;
        try
        {
            dbAccess = getConnection(url);
            executeSelectCommandusingdr("select * from wall;", dbAccess);
            if (dbAccess.dr.HasRows)
            {
                postList = new List<ClassPostDetails>();
                while (dbAccess.dr.Read())
                {
                    ClassPostDetails post = new ClassPostDetails();
                    post.ProfName = dbAccess.dr["profname"].ToString();
                    post.Id = Int32.Parse(dbAccess.dr["id"].ToString());
                    //postid,userid,isnew,postdate,profname
                    post.UserId = Int32.Parse(dbAccess.dr["userid"].ToString());
                    post.Postid = dbAccess.dr["postid"].ToString();

                    if (dbAccess.dr["isnew"].ToString().Equals("yes"))
                    {
                        post.IsNewPost = true;
                    }
                    else
                    {
                        post.IsNewPost = false;
                    }
                    post.Postdate = dbAccess.dr["postdate"].ToString();
                    post.ProfName = dbAccess.dr["profname"].ToString();
                    postList.Add(post);
                }
            }
        }
        catch (Exception e)
        {
            handaleError(e, dbAccess);
        }
        finally
        {
            closeConnection(dbAccess);
        }
        return postList;
    }


    public List<ClassPostDetails> readTimeline(string url)
    {
        ClassDataBaseAccess dbAccess = null;
        List<ClassPostDetails> postList = null;
        try
        {
            dbAccess = getConnection(url);
            executeSelectCommandusingdr("select * from wall;", dbAccess);
            if (dbAccess.dr.HasRows)
            {
                postList = new List<ClassPostDetails>();
                while (dbAccess.dr.Read())
                {
                    ClassPostDetails post = new ClassPostDetails();
                    post.ProfName = dbAccess.dr["profname"].ToString();
                    post.Id = Int32.Parse(dbAccess.dr["id"].ToString());
                    //postid,userid,isnew,postdate,profname
                    post.UserId = Int32.Parse(dbAccess.dr["userid"].ToString());
                    post.Postid = dbAccess.dr["postid"].ToString();

                    if (dbAccess.dr["isnew"].ToString().Equals("yes"))
                    {
                        post.IsNewPost = true;
                    }
                    else
                    {
                        post.IsNewPost = false;
                    }
                    post.Postdate = dbAccess.dr["postdate"].ToString();
                    post.ProfName = dbAccess.dr["profname"].ToString();
                    postList.Add(post);
                }
            }
        }
        catch (Exception e)
        {
            handaleError(e, dbAccess);
        }
        finally
        {
            closeConnection(dbAccess);
        }
        return postList;
    }


    public bool checkIfFriend(ClassUserId friend,string url)
    {
        bool isFriend = false;
        ClassDataBaseAccess dbaccess = null;
        try
        {
            dbaccess = getConnection(url);
            executeSelectCommandusingdr("select * from friendlist where profileid = "+friend.Userid,dbaccess);
            if (dbaccess.dr.HasRows)
            {
                isFriend = true;
            }
        }
        catch (Exception e)
        {
            handaleError(e, dbaccess);
        }
        finally
        {
            closeConnection(dbaccess);
        }
        return isFriend;
    }

    public ClassPostDetails readLastpostId(string url)
    {
        ClassPostDetails post = null;
        ClassDataBaseAccess dbaccess = null;
        try
        {
            dbaccess = getConnection(url);
            executeSelectCommandusingdr("select * from lastpost;", dbaccess);
            if (dbaccess.dr.HasRows)
            {
                post = new ClassPostDetails();
                while (dbaccess.dr.Read())
                {
                    post.Id = Int32.Parse(dbaccess.dr["lastpostindex"].ToString());
                }
            }
        }
        catch (Exception e)
        {
            handaleError(e, dbaccess);
        }
        finally
        {
            closeConnection(dbaccess);
        }
        return post;
    }


    public bool insertInTOChatMasterDb(string url,ClassChatDetails chat)
    {
        bool flag = false;
        return flag;
    }

    public bool insertInToChatTable(string url,ClassChatDetails chat)
    {
        bool flag = false;
        return flag;
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocialNetworkingSiteLibrary;
using System.Collections;

public partial class Usertimeline : System.Web.UI.Page
{
    PostHandlerService.PostHandlerWebService posthandlerService = new PostHandlerService.PostHandlerWebService();
    RegistrationService.RegistrationWebService registrationservice = new RegistrationService.RegistrationWebService();
    ClassConvertClientDataToServerSideData clienttoserver = new ClassConvertClientDataToServerSideData();
    PostHandlerService.ClassFriend friend = null;
    PostHandlerService.ClassUserId userid = null;
    PostHandlerService.ClassUserId idofQuery = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        message.Visible = false;
        addfriend.Visible = false;
        ignore.Visible = false;
        unfriend.Visible = false;
        if (Session["user"] != null)
        {
            ClassUserId id = new ClassUserId();
            id.Userid = Int32.Parse(Request.QueryString["id"]);
            RegistrationService.ClassUserDetails userdetails = registrationservice.getUserDetails(clienttoserver.convertToServerSideClassUserId(id));
            LinkButton9.PostBackUrl="~//friendlist.aspx?id="+id.Userid;
            if (userdetails != null)
            {
                List<RegistrationService.ClassUserDetails> userDetailsList = new List<RegistrationService.ClassUserDetails>();
                userDetailsList.Add(userdetails);
                HyperLink1.NavigateUrl = "~//userdetails.aspx?id=" + id.Userid;
            }
            friend = new PostHandlerService.ClassFriend();
            userid = clienttoserver.convertToServerSideClassUserId(((RegistrationService.ClassUserId)Session["user"]));
            friend.Profid = Request.QueryString["id"];
            friend.Name = userdetails.Name ;
            idofQuery = new PostHandlerService.ClassUserId();
            idofQuery.Userid = Int32.Parse(friend.Profid);
            friend.Dateoffriendship = DateTime.Today.ToShortDateString();
            ClassUserDetails user = new ClassUserDetails();
            user.Userid = Int32.Parse( Request.QueryString["id"]);
            
            Image1.ImageUrl = "~/ImageHandler.ashx?url=" + user.Userid + "//image//profilepic.png";
            bindData();
            if (((RegistrationService.ClassUserId)Session["user"]).Userid == user.Userid)
            {
                message.Visible = false;
                addfriend.Visible = false;
                ignore.Visible = false;
                unfriend.Visible = false;
            }
            else
            {
                
                if (posthandlerService.isFriend(userid, friend))
                {
                    message.Visible = true;
                    unfriend.Visible = true;
                }
                else
                {
                    if (posthandlerService.hasFriendRequest(userid, friend))
                    {
                        addfriend.Text = "ACCEPT REQUEST";
                        addfriend.CommandName = "accept";
                        addfriend.Visible = true;
                        ignore.Visible = true;
                    }
                    else
                    {
                        addfriend.Visible = true;
                    }
                }
            }
            bindData();
        }
        else
        {
            Response.Redirect("~/index.aspx");
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        bindData();
    }
    protected void DataPagerRepeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "like")
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                HiddenField userField = (HiddenField)e.Item.FindControl("userid");
                HiddenField postField = (HiddenField)e.Item.FindControl("postid");
                try
                {
                    ClassPostDetails post = new ClassPostDetails();
                    post.UserId = Int32.Parse(userField.Value);
                    post.Postid = postField.Value;
                    PostHandlerService.ClassLike like = new PostHandlerService.ClassLike();
                    like.Profid = ((RegistrationService.ClassUserId)Session["user"]).Userid.ToString();
                    like.Profname = ((RegistrationService.ClassUserId)Session["user"]).Profname;
                    posthandlerService.insertLike(clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"]), like, clienttoserver.convertToServerSidePostDetails(post));
                }
                catch (Exception em)
                {
                }

            }
        }
    }
    protected void DataPagerRepeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Image img = (Image)e.Item.FindControl("postImage");
            HyperLink link = (HyperLink)e.Item.FindControl("postLink");
            LinkButton like = (LinkButton)e.Item.FindControl("LinkButton6");
            ClassPostDetails post = (ClassPostDetails)e.Item.DataItem;
            if (post.IsLiked == true)
            {
                like.Visible = false;
            }
            img.Visible = false;
            link.Visible = false;

            switch (post.Posttype)
            {
                case "textpost":
                    img.Visible = false;
                    link.Visible = false;
                    break;
                case "linkpost":
                    img.Visible = false;
                    link.Visible = true;
                    break;
                case "imagepost":

                    img.Visible = true;
                    link.Visible = false;
                    break;
                default:
                    img.Visible = false;
                    link.Visible = false;
                    break;
            }


        }
    }

    private void bindData()
    {
        if (posthandlerService.constructUserWall(idofQuery) != null)
        {
            List<PostHandlerService.ClassPostDetails> postlist = new List<PostHandlerService.ClassPostDetails>(posthandlerService.constructTimeline(idofQuery));
            ArrayList al = new ArrayList();

            for (int i = 0; i < postlist.Count; i++)
            {
                ClassPostDetails post = new ClassPostDetails();
                PostHandlerService.ClassPostDetails target = postlist[i];
                post.Postcaption = target.Postcaption;
                post.Postdate = target.Postdate;
                post.Postid = target.Postid;
                post.Postimageurl = target.Postimageurl;
                post.Postlike = target.Postlike;
                post.Postlink = target.Postlink;
                post.Posttype = target.Posttype;
                post.ProfName = target.ProfName;
                post.UserId = target.UserId;
                post.IsLiked = target.IsLiked;
                post.Noofcomments = target.Noofcomments;
                post.Nooflikes = target.Nooflikes;
                post.Imgurl = post.UserId + "//image//profilepic.png";
                post.Postimageurl = post.UserId + "//image//" + post.Postid + ".png";
                al.Add(post);
            }
            DataPagerRepeater1.DataSource = al;
            DataPagerRepeater1.DataBind();
        }
    }

    protected void Button1_Click(object sender,EventArgs e)
    {
        if (((Button)sender).CommandName.Equals("accept"))
        {
            posthandlerService.acceptFriendRequest(userid, friend);
        }
        else
        {
            posthandlerService.sendRequest(userid, friend);
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
    }
    protected void message_Click(object sender, EventArgs e)
    {
        Response.Redirect("~//chat.aspx?uid="+idofQuery.Userid);
    }
    protected void ignore_Click(object sender, EventArgs e)
    {
        posthandlerService.ignoreRequest(userid, friend);
    }
    
    protected void Unnamed1_Tick(object sender, EventArgs e)
    {
        bindData();
    }
}

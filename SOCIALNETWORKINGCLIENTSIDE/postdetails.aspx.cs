using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocialNetworkingSiteLibrary;
using System.Collections;

public partial class postdetails : System.Web.UI.Page
{
    PostHandlerService.PostHandlerWebService posthandlerService = new PostHandlerService.PostHandlerWebService();
    RegistrationService.RegistrationWebService registrationservice = new RegistrationService.RegistrationWebService();
    ClassConvertClientDataToServerSideData clienttoserver = new ClassConvertClientDataToServerSideData();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            bindData();
            bindLikeData();
            bindCommentData();
            Label4.Visible = false;
        }
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
                    bindLikeData();
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
        try
        {
            
                ClassPostDetails temppost = new ClassPostDetails();
                temppost.Postid = Request.QueryString["pid"].ToString();
                temppost.UserId = Int32.Parse(Request.QueryString["uid"].ToString());
                List<PostHandlerService.ClassPostDetails> postlist = null;
                if (posthandlerService.getPostDetails(clienttoserver.convertToServerSidePostDetails(temppost),clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"])) != null)
                {
                    postlist = new List<PostHandlerService.ClassPostDetails>(posthandlerService.getPostDetails(clienttoserver.convertToServerSidePostDetails(temppost),clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"])));
                }
                if (postlist != null)
                {
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
        catch (Exception e)
        {
        }
    }

    private void bindCommentData()
    {
        try
        {
            ClassPostDetails temppost = new ClassPostDetails();
                temppost.Postid = Request.QueryString["pid"].ToString();
                temppost.UserId = Int32.Parse(Request.QueryString["uid"].ToString());
                List<PostHandlerService.ClassComment> postList = null;
                if (posthandlerService.getAllComments(clienttoserver.convertToServerSidePostDetails(temppost)) != null)
                {
                    postList = new List<PostHandlerService.ClassComment>(posthandlerService.getAllComments(clienttoserver.convertToServerSidePostDetails(temppost)));
                }
                if (postList != null)
                {
                    DataPagerRepeater2.DataSource = postList;
                    DataPagerRepeater2.DataBind();
                }


        }
        catch (Exception e)
        {
        }
    }
    private void bindLikeData()
    {
        try
        {
            ClassPostDetails temppost = new ClassPostDetails();
            temppost.Postid = Request.QueryString["pid"].ToString();
            temppost.UserId = Int32.Parse(Request.QueryString["uid"].ToString());
            List<PostHandlerService.ClassLike> likeList = null;
            if (posthandlerService.getAllLikes(clienttoserver.convertToServerSidePostDetails(temppost)) != null)
            {
                likeList = new List<PostHandlerService.ClassLike>(posthandlerService.getAllLikes(clienttoserver.convertToServerSidePostDetails(temppost)));
            }
            if (likeList != null)
            {
                DataPagerRepeater3.DataSource = likeList;
                DataPagerRepeater3.DataBind();
            }
        }
        catch (Exception e)
        {
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != null && TextBox1.Text.Trim() != null)
        {
            try
            {
                PostHandlerService.ClassComment comment = new PostHandlerService.ClassComment();
                comment.Comment = TextBox1.Text;
                comment.Commentdate = DateTime.Today.ToShortDateString();
                comment.Profid = ((RegistrationService.ClassUserId)Session["user"]).Userid.ToString();
                comment.Profname = ((RegistrationService.ClassUserId)Session["user"]).Profname;
                ClassPostDetails temppost = new ClassPostDetails();
                temppost.Postid = Request.QueryString["pid"].ToString();
                temppost.UserId = Int32.Parse(Request.QueryString["uid"].ToString());
               bool flag = posthandlerService.insertComment(comment, clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"]), clienttoserver.convertToServerSidePostDetails(temppost));
               if (flag)
               {
                   Label4.Visible = true;
                   Label4.Text = "SUCCESSFULLY POSTED!!!";
               }
               bindCommentData();
            }
            catch (Exception em)
            {
                Label4.Visible = true;
                Label4.Text = em.Message;
            }
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        bindCommentData();
    }
}

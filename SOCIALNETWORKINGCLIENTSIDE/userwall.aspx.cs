using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using SocialNetworkingSiteLibrary;
using System.IO;

public partial class userwall : System.Web.UI.Page
{
    PostHandlerService.PostHandlerWebService posthandlerService = new PostHandlerService.PostHandlerWebService();
    RegistrationService.RegistrationWebService registrationservice = new RegistrationService.RegistrationWebService();
    ChatService.ChatService chatservice = new ChatService.ChatService();
    ClassConvertClientDataToServerSideData clienttoserver = new ClassConvertClientDataToServerSideData();
    ChatService.ClassUserId userid = new ChatService.ClassUserId();
    protected void Page_Load(object sender, EventArgs e)
    {


        if (Session["user"] != null)
        {
            ownLink.Text = ((RegistrationService.ClassUserId)Session["user"]).Profname;
            ownLink.NavigateUrl = "~//Usertimeline.aspx?id=" + ((RegistrationService.ClassUserId)Session["user"]).Userid;
            Image1.ImageUrl = "~/ImageHandler.ashx?url=" + ((RegistrationService.ClassUserId)Session["user"]).Userid + "//image//profilepic.png";
            userid.Userid = ((RegistrationService.ClassUserId)Session["user"]).Userid;
            if (!IsPostBack)
            {

                LabelMsg.Visible = false;



            }
            bindData();
            bindFriendRequests();
            bindNewMessage();
            bindNotificationData();
            bindOnlineFriends();
        }
        else
        {
            Response.Redirect("~//index.aspx");
        }
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != null)
        {
            ClassPostDetails post = new ClassPostDetails();
            post.Postcaption = TextBox1.Text.ToString().Trim();
            post.Postdate = DateTime.Now.ToShortDateString();
            post.Posttype = "textpost";
            
            bool flag = posthandlerService.shareNewPost(clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"]), clienttoserver.convertToServerSidePostDetails(post));
            LabelMsg.Visible = true;
            if (flag)
            {

                LabelMsg.Text = "SUCCESSFULLY POSTED!!!";
            }
            else
            {
                LabelMsg.Text = "ERROR OCCURED!!!";
            }
            bindData();
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
                HyperLink link = (HyperLink)e.Item.FindControl("profLink");
                try
                {
                    ClassPostDetails post = new ClassPostDetails();
                    post.UserId = Int32.Parse(userField.Value);
                    post.Postid = postField.Value;
                    post.ProfName = link.Text;
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
        bindData();
    }
    protected void DataPagerRepeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item||e.Item.ItemType== ListItemType.AlternatingItem)
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
           
            switch(post.Posttype)
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text != null&&FileUpload1.FileBytes!=null)
        {
            ClassPostDetails post = new ClassPostDetails();
            post.Postcaption = TextBox2.Text.ToString().Trim();
            post.Postdate = DateTime.Now.ToShortDateString();
            post.Posttype = "imagepost";

            bool flag = posthandlerService.shareNewImagePost(clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"]), clienttoserver.convertToServerSidePostDetails(post),FileUpload1.FileBytes);
            LabelMsg.Visible = true;
            if (flag)
            {

                LabelMsg.Text = "SUCCESSFULLY POSTED!!!";
            }
            else
            {
                LabelMsg.Text = "ERROR OCCURED!!!";
            }
            bindData();
        }
    }

    private void bindData()
    {
        if (posthandlerService.constructUserWall(clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"])) != null)
        {
            List<PostHandlerService.ClassPostDetails> postlist = new List<PostHandlerService.ClassPostDetails>(posthandlerService.constructUserWall(clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"])));
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
                post.Imgurl = post.UserId+"//image//profilepic.png";
                post.Noofcomments = target.Noofcomments;
                post.Nooflikes = target.Nooflikes;
                post.Postimageurl = post.UserId + "//image//" + post.Postid+".png";
                al.Add(post);
            }
            al.Reverse();
            DataPagerRepeater1.DataSource =al ;
            DataPagerRepeater1.DataBind();
        }
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        bindData();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~//editprofile.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        UploadFile();
    }

    private void UploadFile()
    {
        try
        {
            // get the exact file name from the path
            

            // create an instance fo the web service
            RegistrationService.RegistrationWebService client = new RegistrationService.RegistrationWebService();

            // get the file information form the selected file
           

            // get the length of the file to see if it is possible
            // to upload it (with the standard 4 MB limit)
            

            // Default limit of 4 MB on web server
            // have to change the web.config to if
            // you want to allow larger uploads
            
                // pass the byte array (file) and file name to the web service
            byte[] data = FileUpload2.FileBytes;
                bool flag = client.uploadImage((RegistrationService.ClassUserId)Session["user"],data);
              

                // this will always say OK unless an error occurs,
                // if an error occurs, the service returns the error message
               // MessageBox.Show("File Upload Status: " + sTmp, "File Upload");
            }
            
        
        catch (Exception ex)
        {
            // display an error message to the user
           // MessageBox.Show(ex.Message.ToString(), "Upload Error");
        }
    }
    protected void Timer2_Tick(object sender, EventArgs e)
    {

    }

    private void bindFriendRequests()
    {
        List<PostHandlerService.ClassFriend> requestList = null;
        if(posthandlerService.getAllFriendRequests(clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"]))!=null)
        requestList = new List<PostHandlerService.ClassFriend>(posthandlerService.getAllFriendRequests(clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"])));
        DataPagerRepeater2.DataSource = requestList;
        DataPagerRepeater2.DataBind();
    }

    private void bindNewMessage()
    {
        List<ChatService.ClassChatDetails> messageList = null;
        if (chatservice.getNewMessages(userid) != null)
        {
            messageList = new List<ChatService.ClassChatDetails>(chatservice.getNewMessages(userid));
            DataPagerRepeater4.DataSource = messageList;
            DataPagerRepeater4.DataBind();
        }
    }
    protected void DataPagerRepeater5_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            HyperLink link =(HyperLink) e.Item.FindControl("profLink");
            PostHandlerService.ClassNotification note = (PostHandlerService.ClassNotification)e.Item.DataItem;
            if (note.Notificationtype.Equals("like") || note.Notificationtype.Equals("comment"))
            {
                link.NavigateUrl = "~//postdetails.aspx?pid=" + note.Postid + "&uid=" + note.Sharerid;
            }
            else if (note.Notificationtype.Equals("accept"))
            {
                link.NavigateUrl = "~//Usertimeline.aspx?id="+note.Sharerid;
            }

        }
    }

    private void bindNotificationData()
    {
        List<PostHandlerService.ClassNotification> noteList = null;
        if (posthandlerService.getAllNotifications(clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"])) != null)
        {
            noteList = new List<PostHandlerService.ClassNotification>( posthandlerService.getAllNotifications(clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"])));
            DataPagerRepeater5.DataSource = noteList;
            DataPagerRepeater5.DataBind();
        }
    }
    protected void Timer4_Tick(object sender, EventArgs e)
    {
        bindNotificationData();
    }

    private void bindOnlineFriends()
    {
        List<PostHandlerService.ClassFriend> onlineFriends = null;
        if (posthandlerService.getAllOnlineFriends(clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"])) != null)
        {
            onlineFriends = new List<PostHandlerService.ClassFriend>(posthandlerService.getAllOnlineFriends(clienttoserver.convertToServerSideClassUserId((RegistrationService.ClassUserId)Session["user"])));
            DataPagerRepeater3.DataSource = onlineFriends;
            DataPagerRepeater3.DataBind();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class chat : System.Web.UI.Page
{
    ChatService.ChatService chatservice = new ChatService.ChatService();
    ChatService.ClassChatDetails chatdetails = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Visible = false;
        if (Session["user"] != null)
        {
            chatdetails = new ChatService.ClassChatDetails();
            chatdetails.Recieverid = Request.QueryString["uid"].ToString().Trim();
            chatdetails.Senderid = ((RegistrationService.ClassUserId)Session["user"]).Userid.ToString();
            bindChatData();
        }
        else
        {
            Response.Redirect("~//index.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            chatdetails.Message = TextBox1.Text.Trim();
            chatdetails.Chatdate = DateTime.Now.ToShortDateString();
            bool flag = chatservice.sendSms(chatdetails);
            if (flag)
            {
                Label3.Visible = false;
                Label3.Text = "MESSAGE SENT!!!";
                bindChatData();
            }
        }
        catch (Exception em)
        {
            Label3.Visible = false;
            Label3.Text = em.Message;
        }
    }

    private void bindChatData()
    {
        try
        {
            List<ChatService.ClassChatDetails> chatList = null;
            if (chatservice.getAllMessage(chatdetails) != null)
            {
                chatList = new List<ChatService.ClassChatDetails>(chatservice.getAllMessage(chatdetails));
                chatList.Reverse();
            }
            if (chatList != null)
            {
                DataPagerRepeater3.DataSource = chatList;
                DataPagerRepeater3.DataBind();
            }
        }
        catch (Exception e)
        {
            Label3.Visible = true;
            Label3.Text = e.Message;
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        bindChatData();
    }
}

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net.Mail;

public partial class contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            MailMessage email = new MailMessage();
            email.Body ="FROM :     "+TextBox1.Text+"\n"+"QUERY :       "+TextBox2.Text+"\n"+"DATE :    "+DateTime.Now.ToShortDateString()+"\n"+"-------------------------";
            email.From = new MailAddress("info@tutrangaanchalsikshaniketan.in");
            email.To.Add("info@tutrangaanchalsikshaniketan.in");
            SmtpClient client = new SmtpClient();
            client.Host = "127.0.0.1";
            client.Port = 25;
           // client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("info@tutrangaanchalsikshaniketan.in", "9933897844");
            client.Send(email);
            try
            {
                MailMessage email1 = new MailMessage();
                email1.Body = "Thank u for your query.We will get back to u as early as passible!!Keep visting our sites to know about latest events.";
                email1.From = new MailAddress("info@tutrangaanchalsikshaniketan.in");
                email1.To.Add(TextBox1.Text);
                SmtpClient client1 = new SmtpClient();
                client1.Host = "tutrangaanchalsikshaniketan.in";
                client1.Port = 25;
               // client1.EnableSsl = true;
                client1.Credentials = new System.Net.NetworkCredential("info@tutrangaanchalsikshaniketan.in", "9933897844");
                client1.Send(email1);
                Label1.Visible = true;
                Label1.Text = "SUCCESSFULLY SUBMITTED!!!";
            }
            catch (Exception ee)
            {
                Session["error"] = ee.Message;
            }
            finally
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                if (Session["error"] != null)
                {
                    Response.Redirect("~/error.aspx");
                }
            }
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
  /*private  void MailTestClick()
    {
        MailMessage email = new MailMessage();
        email.Body = "FROM :     " + TextBox1.Text + "\n" + "QUERY :       " + TextBox2.Text + "\n" + "DATE :    " + DateTime.Now.ToShortDateString() + "\n" + "-------------------------";
        email.From = new MailAddress(TextBox1.Text);
        email.To.Add("soumyaghosh.ghosh@gmail.com");
        SmtpClient client = new SmtpClient();
        client.Host = "smtp.gmail.com";
        client.Port = 587;
        client.EnableSsl = true;
        client.Credentials = new System.Net.NetworkCredential("soumyaghosh.ghosh@gmail.com", "tutun1239933897844");
        client.Send(email);
        try
        {
            //mes += " Attempting send mail.";
            SmtpMail.Send(MyMail);
            mes += " Message sent to " + MyMail.To;
            mes += " TESTS COMPLETED SUCCESSFULLY!";
            MakeMessage(true, mes);
        }
        catch (Exception ex)
        {
            mes += " " + ex.Message;
            mes += " TESTS FAILED!";
            MakeMessage(false, mes);
        }
    }*/
        
}

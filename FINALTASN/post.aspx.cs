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
using System.Data.SqlClient;
using System.Net.Mail;

public partial class ARTICLE : System.Web.UI.Page
{
    dbconnection database = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        bindData();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            database.con.Open();
            String date = DateTime.Now.ToShortDateString();
            database.cmd.CommandText = "insert into comment values(@name,@address,@pst,@date)";
            database.cmd.Parameters.AddWithValue("name",TextBox1.Text);
            database.cmd.Parameters.AddWithValue("address",TextBox2.Text);
            database.cmd.Parameters.AddWithValue("pst",TextBox3.Text);
            database.cmd.Parameters.AddWithValue("date",date);
            database.cmd.Connection = database.con;
            database.cmd.ExecuteNonQuery();
            MailMessage email = new MailMessage();
            email.Body = TextBox2.Text+"       FROM :::"+"info@tutrangaanchalsikshaniketan.in";
            email.From = new MailAddress("info@tutrangaanchalsikshaniketan.in");
            email.To.Add("info@tutrangaanchalsikshaniketan.in");
            SmtpClient client = new SmtpClient();
            client.Host = "127.0.0.1";
            client.Port = 25;
           // client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("info@tutrangaanchalsikshaniketan.in", "9933897844");
            client.Send(email);
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            database.con.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            bindData();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
    protected void bindData()
    {
        try
        {
            database.con.Open();
            database.cmd.CommandText = "select * from comment";
            database.cmd.Connection = database.con;
            SqlDataAdapter da = new SqlDataAdapter(database.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            database.cmd.ExecuteNonQuery();
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            database.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
}

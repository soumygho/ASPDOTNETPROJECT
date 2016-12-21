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
using System.Drawing;

public partial class query : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Label1.Visible = false;
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        DatabaseConnection db = new DatabaseConnection();
         UserDetails user = new UserDetails();
         String status = "";
         Boolean flag = false;
        try
        {
            db.con.Open();
            db.cmd.Connection = db.con;
            db.cmd.CommandText = "select * from userdetails where id=@id and name=@name;";
            db.cmd.Parameters.AddWithValue("id",idquery.Text.Trim());
            db.cmd.Parameters.AddWithValue("name",namequery.Text.Trim());
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.HasRows)
            {
                while (db.dr.Read())
                {
                    user.name = db.dr["name"].ToString();
                    user.id = db.dr["id"].ToString();
                    user.dob = db.dr["dob"].ToString();
                    user.emailid = db.dr["emailid"].ToString();
                    user.mobileno = db.dr["mobno"].ToString();
                    user.voterid = db.dr["voterid"].ToString();
                    user.pan = db.dr["pan"].ToString();
                    user.date = db.dr["date"].ToString();
                    status = db.dr["status"].ToString();
                    user.passportphoto = db.dr["passporturl"].ToString();
                    flag = true;
                }
            }
            else
            {
                Label1.Visible =true;
                Label1.Text = "SORRY!!! NO DATA FOUND WITH THIS NAME AND ID!!!";
            }
            if (flag)
            {
                name.Text = user.name;
                dob.Text = user.dob;
                mobno.Text = user.mobileno;
                id.Text = user.id;
                email.Text = user.emailid;
                pan.Text = user.pan;
                status1.Text = status;
                date.Text = user.date;
                passport.ImageUrl = "~/picture" + "//" + user.passportphoto;
                Panel1.Visible = true;
                if (status.Equals("VALID"))
                {
                    status1.ForeColor = Color.Green;
                }
                else if (status.Equals("INVALID"))
                {
                    status1.ForeColor = Color.Red;
                }
                else
                {
                    status1.ForeColor = Color.Blue;
                }
                rationcardno.Text = user.voterid.Trim();
            }
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            db.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
}

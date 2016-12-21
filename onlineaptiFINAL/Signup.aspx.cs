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

public partial class Signup : System.Web.UI.Page
{
    DatabaseConnection db = new DatabaseConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label4.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Image2.Visible = false;
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        try
        {
            bool flag = false;
            db.con.Open();
            db.cmd.CommandText = "Select username from members";
            db.cmd.Connection = db.con;
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.HasRows)
            {
                while (db.dr.Read())
                {
                    if (TextBox2.Text.Equals(db.dr["username"].ToString()))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    Label1.Visible = true;
                    Label1.Text = "Username already taken";
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Username available";
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Username available";
            }
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            db.dr.Close();
            db.con.Close();
        }
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        if (TextBox3.Text.Length <= 9&&TextBox3.Text.Length >6)
        {
            Label2.Visible = true;
            Label2.Text = "Security level: low";
            Image2.Visible = true;
            Image2.ImageUrl = "~/PIC/low.png";
        }
        else if (TextBox3.Text.Length >= 10 && TextBox3.Text.Length <= 15)
        {
            Label2.Visible = true;
            Label2.Text = "Security level: midium";
            Image2.Visible = true;
            Image2.ImageUrl = "~/PIC/mid.png";
        }
        else if (TextBox3.Text.Length >= 16)
        {
            Label2.Visible = true;
            Label2.Text = "Security level: High";
            Image2.Visible = true;
            Image2.ImageUrl = "~/PIC/hi.png";
        }
        else
        {
            Label2.Visible = true;
            Label2.Text = "Your password  must be 7  TO 20 characters long";
        }
    }
    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {
        if (TextBox3.Text.Equals(TextBox6.Text))
        {
            Label3.Visible = true;
            Label3.Text = "PASSWORD MATCHED";
        }
        else
        {
            Label3.Visible = true;
            Label3.Text = "PASSWORD DID NOT MATCHED";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool flag = false;
        String sex = null;
        try
        {
             flag = false;
            db.con.Open();
            db.cmd.CommandText = "Insert into  MEMBERS (username,password,dob,year,mobno,email,sex,name) values(@username,@password,@dob,@year,@mobno,@email,@sex,@name)";
            db.cmd.Parameters.AddWithValue("@username",TextBox2.Text);
            Session["username"] = TextBox2.Text;
            Session["name"] = TextBox1.Text;
            Session["password"] = TextBox3.Text;
            db.cmd.Parameters.AddWithValue("@password", TextBox3.Text);
            db.cmd.Parameters.AddWithValue("@dob", TextBox7.Text);
            db.cmd.Parameters.AddWithValue("@year", TextBox8.Text);
            db.cmd.Parameters.AddWithValue("@mobno", TextBox4.Text);
            db.cmd.Parameters.AddWithValue("@email", TextBox5.Text);
            db.cmd.Parameters.AddWithValue("@name",TextBox1.Text);
            sex = Session["SEX"].ToString();
            db.cmd.Parameters.AddWithValue("@sex", sex);
            db.cmd.Connection = db.con;
            db.cmd.ExecuteNonQuery();
            flag = true;
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            db.con.Close();
        }
        if (flag)
        {
            Response.Redirect("~/LoginDetails.aspx");
        }
        else
        {
            Label4.Visible = true;
            Label4.Text = "SORRY!!REGISTRATION NOT SUCCESSFUL";
        }
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        Session["SEX"] = RadioButton1.Text;
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        Session["SEX"] = RadioButton2.Text;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Signup.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/HOMEPAGE.aspx");
    }
}

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
using System.IO;
using System.Net.Mail;

public partial class finalview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        failedLbl.Visible = false;
        if (Session["user"] != null)
        {
            UserDetails user = (UserDetails)Session["user"];
            name.Text = user.name;
            guardian.Text = user.guardian;
            guardianname.Text = user.guardianname;
            dob.Text = user.dob;
            pan.Text = user.pan;
            adhaar.Text = user.adhaarcardno;
            gender.Text = user.gender;
            marital.Text = user.maritalstatus;
            natinality.Text = user.nationality;
            qualification.Text = user.educationalqualification;
            mobno.Text = user.mobileno;
            telno.Text = user.telephoneno;
            emailid.Text = user.emailid;
            address.Text = user.address;
            town.Text = user.town;
            district.Text = user.district;
            state.Text = user.state;
            pin.Text = user.pincode;
            votercard.Text = user.voterid;
           // id.Text = user.id.Trim();
            thumbimpression.ImageUrl = "~/picture" + "\\" + user.thumbimpression;
            passport.ImageUrl = "~/picture"+"\\"+user.passportphoto;
            signature.ImageUrl = "~/picture" + "\\" + user.signature;
            date.Text = user.date;
            passport.Visible = true;
        }
        else
        {
            Response.Redirect("~/registartion.aspx");
        }
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        bool flag = false;
        DatabaseConnection data = new DatabaseConnection();
        UserDetails user = (UserDetails)Session["user"];
        try
        {
            data.con.Open();
            data.cmd.Connection = data.con;
            data.cmd.CommandText = "insert into userdetails(id,name,guardian,guardianname,dob,pan,adhaarcardno,gender,maritalstatus,natinality,qualification,mobno,telno,emailid,address,town,district,state,pin,voterid,passporturl,thumburl,signatureurl,date,status)";
            data.cmd.CommandText+="values('" + user.id + "','" + user.name + "','" + user.guardian + "','" + user.guardianname + "','" + user.dob + "','" + user.pan + "','" + user.adhaarcardno + "','" + user.gender + "','" + user.maritalstatus + "','" + user.nationality + "','" + user.educationalqualification + "','" + user.mobileno + "','" + user.telephoneno + "','" + user.emailid + "','" + user.address + "','" + user.town + "','" + user.district + "','" + user.state + "','" + user.pincode + "','" + user.voterid + "','" + user.passportphoto + "','" + user.thumbimpression + "','" + user.signature + "','" + user.date + "','NOT REGISTERED');";
            data.cmd.ExecuteNonQuery();
            flag = true;
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            data.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
            generateID(user);
            sendEmail(user);
            sendEmailtoClient(user);
            if (flag)
            {
                Response.Redirect("~/successful.aspx");
            }
        }
    }
    protected void cancel_Click(object sender, EventArgs e)
    {
        UserDetails user = (UserDetails)Session["user"];
        bool flag = false;
        try
        {
            String path = null;
            String path1 = Server.MapPath("~/picture");
            path = path1;
            path += "\\" + user.passportphoto;
            File.Delete(path);
            path = path1;
            path += "\\" + user.signature;
            File.Delete(path);
            path = path1;
            path += "\\" + user.thumbimpression;
            File.Delete(path);
            flag = true;
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
            
        }
        finally
        {
            Session["user"] = null;
            if (flag)
            {
                Response.Redirect("~/registartion.aspx");
            }
            Response.Redirect("~/error.aspx");
        }
    }
    private void sendEmail(UserDetails user)
    {
        try
        {
            /* database.con.Open();
            String date = DateTime.Now.ToShortDateString();
            database.cmd.CommandText = "insert into comment values(@name,@address,@pst,@date)";
             database.cmd.Parameters.AddWithValue("name",TextBox1.Text);
             database.cmd.Parameters.AddWithValue("address",TextBox2.Text);
             database.cmd.Parameters.AddWithValue("pst",TextBox3.Text);
             database.cmd.Parameters.AddWithValue("date",date);
             database.cmd.Connection = database.con;
             database.cmd.ExecuteNonQuery();*/
            MailMessage email = new MailMessage();
            email.Body = "NEW REGISTRATION DONE PLEASE CHECK THE ADMIN PAGE TO VIEW DETAILS!!! USER ID IS:  " + user.id + "NAME IS : " + user.name;
            email.From = new MailAddress("info.at8ar@gmail.com");
            email.To.Add("info.at8ar@gmail.com");
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("info.at8ar@gmail.com", "avater@87at8ar123");
            client.Send(email);
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            // database.con.Close();
            // bindData();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
    private void sendEmailtoClient(UserDetails user)
    {
        try
        {
            MailMessage mail = new MailMessage();
            mail.Body = "CONGRATULATION FOR YOUR SUCCESSFUL REGISTRATION IN A.V.A.T.E.R CLUB!!!YOUR APPLICATION IS WAITING FOR ADMINISTRATION APPROVAL!!BE WITH US AND THANKS AGAIN!!!";
            mail.Body += "PLEASE NOTE THE DETAILS YOUR USER ID IS "+user.id+" PLEASE KEEP IT CAREFULY FOR FUTURE REFERENCE!!THANK U!!";
            mail.From = new MailAddress("info.at8ar@gmail.com");//email address here
            mail.To.Add(new MailAddress("info.at8ar@gmail.com"));
            //mail.ReplyTo = new MailAddress("info@tutrangaanchalsikshaniketan.in");
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("info.at8ar@gmail.com", "avater@87at8ar123");
            client.Send(mail);
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
            Response.Redirect("~/error.aspx");
        }

    }
    private void generateID(UserDetails user)
    {
        DatabaseConnection database = new DatabaseConnection();
        String num = "";
        try
        {
            database.con.Open();
            database.cmd.CommandText = "select num from userdetails where name=@name and emailid=@email";
            database.cmd.Parameters.AddWithValue("name", user.name);
            database.cmd.Parameters.AddWithValue("email",user.emailid);
            database.cmd.Connection = database.con;
            database.dr=database.cmd.ExecuteReader();

            if (database.dr.HasRows)
            {
                while (database.dr.Read())
                {
                    num = database.dr["num"].ToString().Trim();
                }
            }
            database.dr.Close();
            user.id = user.name.Substring(1, 4).Replace(' ', '_').ToString() + user.mobileno.Substring(4, 3)+num.Trim();
            database.cmd.CommandText = "update userdetails set id=@id where num=@num";
            database.cmd.Parameters.AddWithValue("id",user.id);
            database.cmd.Parameters.AddWithValue("num",num);
            database.cmd.ExecuteNonQuery();
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            database.con.Close();
            DatabaseConnection data = new DatabaseConnection();
            if (Session["error"] != null)
            {
                try
                {
                    data.con.Open();
                    data.cmd.Connection = data.con;
                    data.cmd.CommandText = "delete from userdetails where name=@name and emailid=@email";
                    data.cmd.Parameters.AddWithValue("name", user.name);
                    data.cmd.Parameters.AddWithValue("email", user.emailid);
                    data.cmd.ExecuteNonQuery();
                }
                catch (Exception ee)
                {
                    Session["error"] = ee.Message;
                }
                finally
                {
                    data.con.Close();
                    if (Session["error"] != null)
                    {
                        Response.Redirect("~/error.aspx");
                    }
                    else
                    {
                        failedLbl.Visible = true;
                        failedLbl.Text = "SUBMSSION FAILED!!!PLEASE TRY AFTER SOMETIME!!";
                    }
                }
            }
        }
    }
}

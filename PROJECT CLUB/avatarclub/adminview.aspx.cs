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

public partial class adminview : System.Web.UI.Page
{
    DatabaseConnection db = new DatabaseConnection();
    String id = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/adminlogin.aspx");
        }
        warning.Visible = false;
        if(!IsPostBack)
        {
            if (Request.QueryString["id"]!= null)
            {
                id = Request.QueryString["id"].ToString().Trim();
                Session["id"] = id;
                selectDetails(id);
                
            }
            else
            {
                Response.Redirect("~/adminhome.aspx");
            }
        }
    }
    private bool selectDetails(String id)
    {
        UserDetails user = new UserDetails();
        String status = null;
        try
        {
            db.con.Open();
            db.cmd.CommandText = "select * from userdetails where id=@id";
            db.cmd.Connection = db.con;
            db.cmd.Parameters.AddWithValue("id",Session["id"].ToString().Trim());
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.HasRows)
            {
                while (db.dr.Read())
                {
                    user.id = db.dr["id"].ToString();
                    user.name = db.dr["name"].ToString();
                    user.guardian = db.dr["guardian"].ToString();
                    user.guardianname = db.dr["guardianname"].ToString();
                    user.dob = db.dr["dob"].ToString();
                    user.pan = db.dr["pan"].ToString();
                    user.adhaarcardno = db.dr["adhaarcardno"].ToString();
                    user.gender = db.dr["gender"].ToString();
                    user.maritalstatus = db.dr["maritalstatus"].ToString();
                    user.nationality = db.dr["natinality"].ToString();
                    user.educationalqualification = db.dr["qualification"].ToString();
                    user.mobileno = db.dr["mobno"].ToString();
                    user.telephoneno = db.dr["telno"].ToString();
                    user.emailid = db.dr["emailid"].ToString();
                    user.address = db.dr["address"].ToString();
                    user.town = db.dr["town"].ToString();
                    user.district = db.dr["district"].ToString();
                    user.state = db.dr["state"].ToString();
                    user.pincode = db.dr["pin"].ToString();
                    user.voterid = db.dr["voterid"].ToString();
                    user.passportphoto = db.dr["passporturl"].ToString();
                    user.thumbimpression = db.dr["thumburl"].ToString();
                    user.signature = db.dr["signatureurl"].ToString();
                    user.date = db.dr["date"].ToString();
                    status = db.dr["status"].ToString();
                }
            }
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
            statuslabel.Text = status;
            idlabel.Text = user.id;
            thumbimpression.ImageUrl = "~/picture" + "\\" + user.thumbimpression;
            passport.ImageUrl = "~/picture" + "\\" + user.passportphoto;
            signature.ImageUrl = "~/picture" + "\\" + user.signature;
            date.Text = user.date;
            //passport.Visible = true;
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
        return true;
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        if (!Status.SelectedItem.Text.Equals("--SELECT STATUS--"))
        {
            try
            {
                db.con.Open();
                db.cmd.CommandText = "update userdetails set status = '" + Status.SelectedItem.Text + "' where id= '" + Session["id"].ToString().Trim() + "'";
                //db.cmd.Parameters.AddWithValue("status",Status.SelectedItem.Text);
                // db.cmd.Parameters.AddWithValue("id1",id);
                db.cmd.Connection = db.con;
                db.cmd.ExecuteNonQuery();
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
                selectDetails(id);
            }
        }
        else
        {
            warning.Visible = true;
            warning.Text = "PLEASE SELECT A VALID STATUS";
        }
    }
}

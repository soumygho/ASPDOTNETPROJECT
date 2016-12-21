using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class registartion : System.Web.UI.Page
{
    String passport = "";
    String thumb = "";
    String sign = "";
    String imgurl = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        warn.Visible = false;
        emaillbl.Visible = false;
        voterlbl.Visible = false;
        thumblbl.Visible = false;
        signlbl.Visible = false;
        genlbl.Visible = false;
        quallbl.Visible = false;
        marlbl.Visible = false;
        rellbl.Visible = false;
        statelbl.Visible = false;
        if (!IsPostBack)
        {
            Panel3.Visible=true;
           // Panel2.Visible = false;
            Session["user"] = null;
        }
    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton11_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton12_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton13_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton7_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton8_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton9_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox10_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox13_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox14_TextChanged(object sender, EventArgs e)
    {

    }
    private bool uploadImage(String imgurl, FileUpload FileUpload1,Label warning,String name)
    {
        String filename = imgurl;
        String path = "";
        bool flag = false;
        try
        {
                String ext = Path.GetExtension(FileUpload1.FileName.ToString());
                if (ext.Equals(".JPG") || ext.Equals(".jpg") || ext.Equals(".PNG") || ext.Equals(".png") || ext.Equals(".BMP") || ext.Equals(".bmp"))
                {
                    path = Server.MapPath("~/picture").ToString() + "\\" + filename;
                    FileUpload1.SaveAs(path);
                    flag = true;
                   // name = filename;
                    warning.Visible = true;
                    warning.Text = "SUCCESSFULLY UPLOADED";
                    return true;
                }
                else
                {
                    warning.Visible = true;
                    warning.Text = "FILE FORMAT NOT SUPPORTED!!! SUPPORTED EXTENSIONS ARE .jpg,.JPG,.BMP,.bmp,.png,.PNG"; 
                }
            }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        if (Session["error"] != null)
        {
            Response.Redirect("~/error.aspx");
        }
        return false;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
     
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        FileInfo file;
        bool qual = true;
        bool gen = true;
        bool mar = true;
        bool rel = true;
        bool sta = true;
        bool thumbupload = false;
        bool photoupload = false;
        bool signupload = false;
        DatabaseConnection database = new DatabaseConnection();
        bool emailflag = false;
        try
        {
            database.con.Open();
            database.cmd.CommandText = "SELECT EMAILID FROM USERDETAILS";
            database.cmd.Connection = database.con;
            database.dr = database.cmd.ExecuteReader();
            if (database.dr.HasRows)
            {
                while (database.dr.Read())
                {
                    if (database.dr["emailid"].ToString().Trim().Equals(emailid.Text.Trim()))
                    {
                        emailflag = true;
                        break;
                    }
                }
            }
            if (emailflag)
            {
                emaillbl.Visible = true;
                emaillbl.Text = "EMAIL ADDRESS IS ALREADY IN USED!!!";
            }
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
        if (qualification.SelectedItem.Value.Trim().Equals("-SELECT QUALIFICATION-"))
        {
            qual = false;
            quallbl.Visible = true;
            quallbl.Text = "*Required";
        }
        if (state.SelectedItem.Value.Trim().Equals("-SELECT STATE-"))
        {
            sta = false;
            statelbl.Visible = true;
            statelbl.Text = "*Required";
        }
        if (maritalstatus.SelectedItem.Value.Trim().Equals("-SELECT MARITAL STATUS-"))
        {
            mar = false;
            marlbl.Visible = true;
            marlbl.Text = "*Required";
        }
        if (gender.SelectedItem.Value.Trim().Equals("-SELECT GENDER-"))
        {
            gen = false;
            genlbl.Visible = true;
            genlbl.Text = "*Required";
        }
        if (gurdian.SelectedItem.Value.Trim().Equals("-SELECT RELATIONSHIP-"))
        {
            rel = false;
            rellbl.Visible = true;
            rellbl.Text = "*Required";
        }
        if (!emailflag&&rel&&gen&&mar&&qual)
        {
            bool flag = false;
            bool flag1 = false;
            bool flag3 = false;
            if (FileUpload2.HasFile)
            {
                imgurl = FileUpload2.FileName.ToString();
                String ext = Path.GetExtension(imgurl);
                imgurl = name.Text + dob.Text + rationcardno.Text + "thumb" + ext;
                imgurl = imgurl.Replace('/', '_');
                thumb = imgurl;
                long size = FileUpload2.PostedFile.ContentLength;
                if (size <= 8192)
                {
                    thumbupload = uploadImage(imgurl, FileUpload2, warn,thumb);
                    if (thumbupload)
                    {
                        flag = true;
                    }
                }
                else
                {
                   thumblbl.Visible = true;
                   thumblbl.Text = "FILE SIZE IS GREATER THAN 8KB";
                }
            }
            if (flag)
            {
                if (FileUpload1.HasFile)
                {
                    imgurl = FileUpload1.FileName.ToString().Replace('/', '_');
                    String ext = Path.GetExtension(imgurl);
                        imgurl = name.Text + dob.Text + rationcardno.Text + ext;
                        imgurl = imgurl.Replace('/', '_');
                        passport = imgurl;
                        long size = FileUpload1.PostedFile.ContentLength;
                        if (size <= 25600)
                        {
                            photoupload = uploadImage(imgurl, FileUpload1, warn,passport);
                            if (photoupload)
                            {
                                flag1 = true;
                            }
                        }
                        else
                        {
                            voterlbl.Visible = true;
                            voterlbl.Text = "FILE SIZE IS GREATER THAN 25KB";
                        }
                    }
            }
            if (flag1)
            {
                if (FileUpload3.HasFile)
                {
                    imgurl = FileUpload3.FileName.ToString().Replace('/', '_');
                    String ext = Path.GetExtension(imgurl);
                    imgurl = name.Text + dob.Text + rationcardno.Text + "signature" + ext;
                    imgurl = imgurl.Replace('/', '_');
                    sign = imgurl;
                    long size = FileUpload3.PostedFile.ContentLength;
                    if (size <= 8192)
                    {
                        signupload = uploadImage(imgurl, FileUpload3, warn,sign);
                        if (signupload)
                        {
                            flag3 = true;
                        }
                    }
                    else
                    {
                       signlbl.Visible = true;
                       signlbl.Text = "FILE SIZE IS GREATER THAN 8KB";
                    }
                }
            }
            if (flag3)
            {
                UserDetails user = new UserDetails();
                user.name = name.Text.Trim().ToString();
                user.dob = dob.Text.Trim().ToString();
                user.address = address.Text.Trim().ToString();
                if (!adhaarcardno.Text.Trim().Replace(',',' ').Equals(",")&&!adhaarcardno.Text.Trim().Equals(""))
                {
                    user.adhaarcardno = adhaarcardno.Text.Trim().ToString();
                }
                user.district = district.Text.Trim().ToString();
                if (!telno.Text.Trim().Equals(",")&&!telno.Text.Trim().Equals(""))
                {
                    user.telephoneno = telno.Text.Trim();
                }
                user.town = town.Text.ToString().Replace(',', ' ').Trim();
                user.state = state.SelectedItem.Text.Trim();
                user.guardian=gurdian.SelectedItem.Value.ToString().Trim();
                user.maritalstatus=maritalstatus.SelectedItem.Value.ToString().Trim();
                user.gender=gender.SelectedItem.Value.ToString().Trim();
                user.educationalqualification=qualification.SelectedItem.Value.ToString().Trim();
                if (!pan.Text.Trim().Equals(""))
                {
                    user.pan = pan.Text.Trim();
                }
                user.guardianname = guardianname.Text.Trim();
                user.nationality = natinality.Text.Trim();
                user.mobileno = mobno.Text;
                user.pincode = pincode.Text;
                //user.state = state.SelectedItem.Text;
                if (!rationcardno.Text.Trim().Equals(",")&&!rationcardno.Text.Trim().Equals(""))
                {
                    user.voterid = rationcardno.Text;
                }
                user.passportphoto = passport;
                user.signature = sign;
                user.thumbimpression = thumb;
                user.emailid = emailid.Text.Trim();
                user.date = DateTime.Today.ToShortDateString();
                Session["user"] = user;
                Response.Redirect("~/finalview.aspx");
            }
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
       
    }
    protected void download_Click(object sender, EventArgs e)
    {

    }
    protected void emailid_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        name.Text = "";
        gurdian.SelectedIndex = -1;
        guardianname.Text = "";
        qualification.SelectedIndex = -1;
        dob.Text = "";
        pan.Text = "";
        adhaarcardno.Text = "";
        gender.SelectedIndex = -1;
        maritalstatus.SelectedIndex = -1;
        natinality.Text = "";
        mobno.Text = "";
        telno.Text = "";
        emailid.Text = "";
   
        address.Text= "";
        town.Text = "";
        district.Text = "";
        state.SelectedIndex = -1;
        pincode.Text = "";
        rationcardno.Text = "";

    }
}

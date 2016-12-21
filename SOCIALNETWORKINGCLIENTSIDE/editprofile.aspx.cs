using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocialNetworkingSiteLibrary;

public partial class editprofile : System.Web.UI.Page
{
    ClassConvertClientDataToServerSideData conv = new ClassConvertClientDataToServerSideData();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (Session["user"] == null)
        {
            Response.Redirect("~//index.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                bindData();
            }
        }
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       bool flag =  createData();
       bindData();
       if (flag)
       {
           Label1.Visible = true;
           Label1.Text = "SUCCESSFULLY UPDATED!!!!";
       }
    }

    private void bindData()
    {
        RegistrationService.RegistrationWebService client = new RegistrationService.RegistrationWebService();
        RegistrationService.ClassUserDetails userdetails = null;
        try
        {
            userdetails = client.getUserDetails((RegistrationService.ClassUserId)Session["user"]);
        }
        catch (Exception e)
        {

        }
        if (userdetails != null)
        {
            try
            {
                TextDob.Text = DateTime.Parse(userdetails.Dob).ToShortDateString();
            }
            catch (Exception e)
            {
            }
            TextAbout.Text = userdetails.About;
            TextAddress.Text = userdetails.Address;
            TextCollegeName.Text = userdetails.Collegename;
            TextDesignation.Text = userdetails.Designation;
            //TextDob.Text = userdetails.Dob;
            TextFavouriteQuote.Text = userdetails.Favouritequote;
            TextMob.Text = userdetails.Mobno;
            TextSchoolName.Text = userdetails.Schoolname;
            TextSchoolpassingyear.Text = userdetails.Schoolpassingyear;
            TextSecondaryMob.Text = userdetails.Secondarymobno;
            if (userdetails.Gender.Equals("MALE"))
            {
                RadioButton1.Checked = true;
            }
            else
            {
                RadioButton2.Checked = true;
            }
            try
            {
            TextStudentFrom.Text = DateTime.Parse(userdetails.Studentfrom).ToShortDateString();
             }
            catch (Exception e)
            {
            }
            TextWorksAt.Text = userdetails.Worksat;
            try
            {
            TextWorksFrom.Text = DateTime.Parse(userdetails.Worksfrom).ToShortDateString();
             }
            catch (Exception e)
            {
            }
            TextOccupation.Text = userdetails.Occupation;
            TextName.Text = userdetails.Name;
            TextSpecialization.Text = userdetails.Specialization;
            
        }
    }
    private bool createData()
    {
        bool flag = false;
        RegistrationService.RegistrationWebService client = new RegistrationService.RegistrationWebService();
        RegistrationService.ClassUserDetails userdetails = new RegistrationService.ClassUserDetails();
        userdetails.About = TextAbout.Text;
         userdetails.Address = TextAddress.Text;
          userdetails.Collegename = TextCollegeName.Text;
          userdetails.Designation = TextDesignation.Text;
          userdetails.Dob = TextDob.Text;
          userdetails.Favouritequote = TextFavouriteQuote.Text;
          userdetails.Mobno = TextMob.Text;
          userdetails.Schoolname = TextSchoolName.Text;
          userdetails.Schoolpassingyear = TextSchoolpassingyear.Text;
          userdetails.Secondarymobno = TextSecondaryMob.Text;
          userdetails.Studentfrom = TextStudentFrom.Text;
          userdetails.Worksat = TextWorksAt.Text;
          userdetails.Worksfrom =  TextWorksFrom.Text;
          userdetails.Occupation = TextOccupation.Text;
          userdetails.Name = TextName.Text;
          userdetails.Specialization = TextSpecialization.Text;
          if (RadioButton1.Checked)
          {
              userdetails.Gender = RadioButton1.Text;
          }
          else if (RadioButton2.Checked)
          {
              userdetails.Gender = RadioButton2.Text;
          }
          try
          {
              client.updateUserDetails((RegistrationService.ClassUserId)Session["user"], userdetails);
              flag = true;
          }
          catch (Exception e)
          {
              Label1.Visible = true;
              Label1.Text = e.Message;
          }
          return flag;
    }


}

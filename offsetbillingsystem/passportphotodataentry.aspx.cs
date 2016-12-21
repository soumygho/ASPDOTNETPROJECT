using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;

public partial class passportphotodataentry : System.Web.UI.Page
{
    PasspostPhotoOperation photoops = new PasspostPhotoOperation();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Visible = false;
        if (!IsPostBack)
        {
            bindData();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Label3.Visible = true;
        try
        {
            PassportPhoto photo = new PassportPhoto();
            photo.Rateperphoto = float.Parse(TextBox1.Text);
            bool flag = photoops.insertIntoPassport(photo);
            if (flag)
            {
                Label3.Text = "SUCCESSFULLY INSERTED!!!";
            }
        }
        catch (Exception em)
        {
            Label3.Text = em.Message;
        }
    }

    private void bindData()
    {
        try
        {
            List<PassportPhoto> photos = photoops.readPassport();
            if (photos != null && photos.Count > 0)
            {
                Button1.Visible = false;
                TextBox1.Text = photos[0].Rateperphoto.ToString();
            }
            else
            {
                Button2.Visible = false;
            }

        }
        catch (Exception e)
        {
            Label3.Text = e.Message;
            Label3.Visible = true;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        Label3.Visible = true;
        try
        {
            PassportPhoto photo = new PassportPhoto();
            photo.Id = 1;
            photo.Rateperphoto = float.Parse(TextBox1.Text);
            bool flag = photoops.upadtePassport(photo);
            if (flag)
            {
                Label3.Text = "SUCCESSFULLY UPDATED!!!";
            }
            bindData();
        }
        catch (Exception em)
        {
            Label3.Text = em.Message;
        }
    }
}

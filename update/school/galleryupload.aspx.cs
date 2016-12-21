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
using System.Windows.Forms;

public partial class galleryupload : System.Web.UI.Page
{
    dbconnection database = new dbconnection();
    String filename = null;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool flag =false;
        try
        {
        if(FileUpload1.HasFile)
        {
        String ext = Path.GetExtension(FileUpload1.FileName.ToString());
        filename = TextBox1.Text + ext;
        String path = Server.MapPath("~/GALLERY").ToString()+"\\"+filename;
        FileUpload1.SaveAs(path);
        flag = true;
        MessageBox.Show("IMAGE UPLOADED");
        }
        }
        catch(Exception ee)
        {
            MessageBox.Show(ee.Message);
        }
        finally
        {
            database.con.Close();
        }
        if (flag)
        {
            try
            {
                database.con.Open();
                database.cmd.CommandText = "insert into gallery values('" + filename + "',@title,@description)";
                database.cmd.Parameters.AddWithValue("title", TextBox1.Text);
                database.cmd.Parameters.AddWithValue("description", TextBox2.Text);
                database.cmd.Connection = database.con;
                database.cmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                database.con.Close();
            }
        }
    }
}

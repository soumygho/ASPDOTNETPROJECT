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
using AjaxControlToolkit;
public partial class gallery : System.Web.UI.Page
{
    DatabaseConnection database = new DatabaseConnection();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //popup.Visible = true;
        if (!IsPostBack)
        {
            try
            {
                database.con.Open();
                database.cmd.CommandText = "select * from gallery";
                database.cmd.Connection = database.con;
                SqlDataAdapter da = new SqlDataAdapter(database.cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
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
    protected void Image3_Click(object sender, ImageClickEventArgs e)
    {
    }
    
  /*  protected void itemclicked(object source, RepeaterCommandEventArgs e)
    {
        RepeaterItem rep = e.Item;
        Image img = (Image)rep.FindControl("image");
        Image2.ImageUrl = img.ImageUrl;
        Label2.Text = "ANIMAL";
        popup.Visible = true;
        Repeater1_ModalPopupExtender.Show();
    }*/
  
}

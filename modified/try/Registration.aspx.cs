using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }
    protected void checkpar_CheckedChanged(object sender, EventArgs e)
    {
        permanentText.Text = presentText.Text.ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String path = Server.MapPath("~/Registration") + "//" + "registrationdb.accdb";
        String tablename = "RAGISTRATION";
        String connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path;
        OleDbConnection con = new OleDbConnection(connectionstring);
        OleDbCommand cmd = new OleDbCommand();
        try
        {
            con.Open();
            cmd.CommandText = "insert into REGISTRATION (NAME,MOBNO,EMAILID,PRESENTADDRESS,PERMANENTADDRESS,YEAROFPASSING,CLASSPASS,OCCUPATION) values('" + nameText.Text.ToString().Trim() + "','" + mobText.Text.ToString().Trim() + "','" + emailText.Text.ToString().Trim() + "','" + presentText.Text.ToString() + "','" + permanentText.Text.ToString().Trim() + "','" + year.SelectedValue.ToString().Trim() + "','" + classDropdown.SelectedValue.ToString().Trim() + "','" + occupationText.Text.ToString().Trim() + "');";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label1.Visible = true;
            Label1.Text = "SUCCESSFULLY REGISTERED!!!";
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
}

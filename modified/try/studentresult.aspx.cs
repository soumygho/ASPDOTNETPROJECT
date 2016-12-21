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
using System.Data.OleDb;
using System.IO;

public partial class studentresult : System.Web.UI.Page
{
    DatabaseConnection data = new DatabaseConnection();
    System.Data.DataSet ds = new System.Data.DataSet();
    String filename = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
        Label1.Visible = false;
        Panel1.Visible = false;
    }
    protected void submit_Click1(object sender, EventArgs e)
    {
        bool flag = false;
        String path = Server.MapPath("~/database");
        String status = "TRUE";
        path += "\\";
        try
        {
            data.con.Open();
            data.cmd.CommandText = "select * from filerecord where class like'" + cls.SelectedItem.Text.Trim() + "' and year like '" + year.SelectedItem.Text.Trim() + "' and exam like '" + examname.SelectedItem.Text.Trim() + "' ;";
            data.cmd.Connection = data.con;
            data.dr = data.cmd.ExecuteReader();
            if (data.dr.HasRows)
            {
                while (data.dr.Read())
                {
                    filename = data.dr["filename"].ToString().Trim();
                    status = data.dr["status"].ToString().Trim();
                }
                path += filename;
                if (status.Equals("TRUE"))
                {
                    flag = true;
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "NO DATA FOUND !!!";
            }
            data.dr.Close();

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
            if (flag)
            {
                String tablename = "class" + cls.SelectedItem.Text.ToString();
                String connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path;
                OleDbConnection con = new OleDbConnection(connectionstring);
                OleDbCommand cmd = new OleDbCommand();
                try
                {
                    con.Open();
                    cmd.CommandText = "select * from " + tablename + " where name = '" + name.Text.Trim() + "'and ROLLNO = " + Int32.Parse(rollText.Text.ToString().Trim()) + ";";
                    cmd.Connection = con;
                    OleDbDataAdapter dr = new OleDbDataAdapter(cmd);
                    dr.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;
                    if (count != 0)
                    {
                        Panel1.Visible = true;
                        result.DataSource = ds;
                        result.DataBind();
                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "NO RESULT FOUND !!! PLEASE CONTACT WITH THE SCHOOL AUTHORITY!!!";
                    }
                }
                catch (Exception ee)
                {
                    Label1.Visible = true;
                    Label1.Text = ee.Message;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}

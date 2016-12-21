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

public partial class addadmin : System.Web.UI.Page
{
    DatabaseConnection data = new DatabaseConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label2.Visible = false;
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        bool flag = false;
        try
        {
            data.con.Open();
            data.cmd.CommandText = "Select ADMINID from ADMIN ";
            data.cmd.Connection = data.con;
            data.dr = data.cmd.ExecuteReader();
            if (data.dr.HasRows)
            {
                while (data.dr.Read())
                {
                    if (data.dr["adminid"].ToString().Equals(TextBox1.Text))
                    {
                        flag = true;
                        break;
                    }
                }
            }
            data.dr.Close();
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            //Label1.Text = array[0].ToString();
            data.con.Close();
        }
        if (flag)
        {
            Label1.Visible = true;
            Label1.Text = "USERID NOT AVAILABLE";
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "USERID IS AVAILABLE";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool flag = false;
        try
        {
            data.con.Open();
            data.cmd.CommandText = "Select ADMINID from ADMIN ";
            data.cmd.Connection = data.con;
            data.dr = data.cmd.ExecuteReader();
            if (data.dr.HasRows)
            {
                while (data.dr.Read())
                {
                    if (!data.dr["adminid"].ToString().Equals(TextBox1.Text))
                    {
                        flag = true;
                        break;
                    }
                }
            }
            else
            {
                flag = true;
            }
            data.dr.Close();
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            //Label1.Text = array[0].ToString();
            data.con.Close();
        }
        if (flag)
        {
            try
            {
                data.con.Open();
                data.cmd.CommandText = "INSERT INTO ADMIN (ADMINID,PASSWORD) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "') ";
                data.cmd.Connection = data.con;
                data.dr = data.cmd.ExecuteReader();
                Label2.Visible = true;
                Label2.Text = "SUCCESSFULLY REGISTERED PLEASE GOTO ADMIN LOGIN PAGE AND LOGIN";
            }
            catch (Exception EE)
            {
                Label2.Visible = true;
                Label2.Text = EE.Message;
            }
            finally
            {
                data.con.Close();
            }
        }
        else
        {
            Label2.Visible = true;
            Label2.Text = "USERID ALREADY TAKEN";
        }
    }
}

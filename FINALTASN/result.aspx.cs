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

public partial class result : System.Web.UI.Page
{
    dbconnection cn = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Label17.Visible = false;
        if (!IsPostBack)
        {
            try
            {
                cn.con.Open();
                cn.cmd.CommandText = "select * from table_name";
                cn.cmd.Connection = cn.con;
                cn.dr = cn.cmd.ExecuteReader();
                DropDownList1.Items.Add("--SELECT CLASS--");
                DropDownList2.Items.Add("--SELECT YEAR--");
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        DropDownList1.Items.Add(new ListItem(cn.dr["class"].ToString().Trim(), cn.dr["class"].ToString().Trim()));
                        DropDownList2.Items.Add(new ListItem(cn.dr["year"].ToString().Trim(), cn.dr["year"].ToString().Trim()));
                    }
                    DropDownList1.DataBind();
                    DropDownList2.DataBind();
                }
                else
                {
                    DropDownList1.Visible = false;
                    DropDownList2.Visible = false;
                    panel2.Visible = false;
                    Label17.Visible = true;
                    Button1.Visible = false;
                    Label17.Text = "NO RESULT IS UPLOADED YET!!!";
                }
            }
            catch (Exception ee)
            {
                Session["error"] = ee.Message;
            }
            finally
            {
                cn.con.Close();
                if (Session["error"] != null)
                {
                    Response.Redirect("~/error.aspx");
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string table_name = null;
        int roll = Convert.ToInt32(TextBox1.Text);
        try
        {
            String[] subject = new String[100];
            cn.cmd.Connection = cn.con;
            cn.con.Open();
            cn.cmd.CommandText = "SELECT table_name from table_name where class ='"+DropDownList1.SelectedItem.Value+"' and year ='"+DropDownList2.SelectedItem.Value+"';";
            cn.dr = cn.cmd.ExecuteReader();
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    table_name = cn.dr["table_name"].ToString().Trim(); 
                }
            }
            cn.dr.Close();
            cn.cmd.CommandText = "SELECT * FROM SUBJECT WHERE TABLENAME = '"+table_name+"'";
            cn.dr = cn.cmd.ExecuteReader();
            subject[0] = "name";
            subject[1] = "roll";
            subject[2] = "class";
            int i=3;
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    subject[i] = cn.dr["subname"].ToString().Trim();
                    i++;
                }
            }
            int m=i;
            cn.dr.Close();
            cn.cmd.CommandText = "SELECT * FROM "+table_name+" where roll=@roll";
            cn.cmd.Parameters.AddWithValue("roll",TextBox1.Text);
            cn.dr = cn.cmd.ExecuteReader();
            i = 0;
            Label18.Text="";
            if (cn.dr.HasRows)
            {
                Label table = new Label();
                table.Text = "<div><center><table style='border: medium solid #000000; background-color: #FFFFFF'><tr><td></td><td></td><td></td><td>RESULT</td><td></td><td></td><td></td></tr>";
                Panel1.Controls.Add(table);
                while (cn.dr.Read())
                {
                    while (i < m)
                    {
                        Label name = new Label();
                        Label value = new Label();
                        name.Text = "<tr><td></td><td></td><td>" + subject[i] + "  :   </td><td></td>";
                        name.Style["font-weight"] = "700";
                        name.Style["color"] = "#FF0000";
                        value.Text = "<td>" + cn.dr[subject[i]].ToString() + "</td><td></td><td></td></tr>";
                        value.Style["font-weight"] = "700";
                        value.Style["color"] = "#FF0000";
                        Panel1.Controls.Add(name);
                        Panel1.Controls.Add(value);
                        i++;
                    }
                   // Label18.Text += cn.dr[subject[i]].ToString();
                      //  i++;
                }
                Label tab = new Label();
                tab.Text = "</div></center></table>";
                Panel1.Controls.Add(tab);
                Panel1.Visible = true;
                cn.dr.Close();
            }
            else
            {
                Label17.Visible = true;
                Label17.Text = "SORRY RESULT NOT AVAILABLE WITH THIS ROLL NO";
            }
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            cn.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
}

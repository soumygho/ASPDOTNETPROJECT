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
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string table_name = DropDownList1.SelectedItem.Value.ToString() + DropDownList2.SelectedItem.Value.ToString();
        int roll = Convert.ToInt32(TextBox1.Text);
        try
        {
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "SELECT * FROM "+table_name+" where roll="+roll+"";
            cn.con.Open();
            cn.dr = cn.cmd.ExecuteReader();
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    Label1.Text = DropDownList2.SelectedItem.Text;
                    Label2.Text = DropDownList1.SelectedItem.Text;
                    Label3.Text = roll.ToString();
                    Label4.Text = cn.dr["name"].ToString();
                    Label5.Text = cn.dr["beng"].ToString();
                    Label6.Text = cn.dr["eng"].ToString();
                    Label7.Text = cn.dr["math"].ToString();
                    Label8.Text = cn.dr["phys"].ToString();
                    Label9.Text = cn.dr["bios"].ToString();
                    Label10.Text = cn.dr["hist"].ToString();
                    Label11.Text = cn.dr["geo"].ToString();
                    Label12.Text = cn.dr["edu"].ToString();
                    Label13.Text = cn.dr["comp"].ToString();
                    Label14.Text = cn.dr["sans"].ToString();
                    Label15.Text = cn.dr["evs"].ToString();
                    //Label16.Text = Convert.ToInt32(cn.dr["beng"]) + Convert.ToInt32(cn.dr["eng"]) + Convert.ToInt32(cn.dr["math"]) + Convert.ToInt32(cn.dr["phys"]) + Convert.ToInt32(cn.dr["bios"]) + Convert.ToInt32(cn.dr["hist"]) + Convert.ToInt32(cn.dr["geo"]) + Convert.ToInt32() + Convert.ToInt32() + Convert.ToInt32() + Convert.ToInt32();

                }
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
            Label17.Visible = true;
            Label17.Text = ee.Message;
        }
        finally
        {
            cn.con.Close();
        }
    }
}

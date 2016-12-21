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
using System.Collections.Generic;
using System.Windows.Forms;

public partial class Default2 : System.Web.UI.Page
{
    CONNECTION cn = new CONNECTION();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("-Select-");
            cn.con.Open();
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "SELECT STNAME,STID FROM STATE";
            cn.dr = cn.cmd.ExecuteReader();
            while (cn.dr.Read())
            {
                DropDownList1.Items.Add(new ListItem(cn.dr["STNAME"].ToString(), cn.dr["STID"].ToString()));
            }
            cn.dr.Close();
            cn.con.Close();
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 0)
        {
            MessageBox.Show("Plz Select another item", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
        else
        {
            int id = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("-Select-");
            try
            {
                cn.con.Open();
                cn.cmd.Connection = cn.con;
                cn.cmd.CommandText = "SELECT * FROM DIST WHERE stid=" + id + "";
                cn.dr = cn.cmd.ExecuteReader();
                while (cn.dr.Read())
                {


                    DropDownList2.Items.Add(new ListItem(cn.dr["dtname"].ToString(), cn.dr["dtid"].ToString()));

                }
            }
            catch (Exception ee)
            {
                Label1.Text = ee.Message;
            }
            finally
            {
                cn.dr.Close();
                cn.con.Close();
            }

        }
    }
}
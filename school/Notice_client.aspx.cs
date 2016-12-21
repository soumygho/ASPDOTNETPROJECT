﻿using System;
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
using System.Windows.Forms;

public partial class Notice_client : System.Web.UI.Page
{
    dbconnection cn = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        string ID = Request.QueryString["id"].ToString();
        int m=Convert.ToInt32(ID);
        try
        {
            String path = null;
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "SELECT * FROM notice WHERE id='"+m+"' ";
            cn.con.Open();
            cn.dr = cn.cmd.ExecuteReader();
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    path = cn.dr["path"].ToString();
                }
                if (path != null)
                {

                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("REQUESTED NOTICE NOT FOUND");
            }
        }
        catch(Exception ee)
        {
            System.Windows.Forms.MessageBox.Show(ee.Message);
        }
        finally
        {
            cn.dr.Close();
            cn.con.Close();
        }
    }
}

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

public partial class gallery : System.Web.UI.Page
{
   
    
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    [System.Web.Services.WebMethodAttribute(), System.Web.Script.Services.ScriptMethodAttribute()]
    public static AjaxControlToolkit.Slide[] GetSlides(string contextKey)
    {
        AjaxControlToolkit.Slide[] slides = null;
        dbconnection database = new dbconnection();
        try
        {
            int count = 0;
            database.con.Open();
            database.cmd.CommandText = "select * from gallery";
            database.cmd.Connection = database.con;
            database.dr = database.cmd.ExecuteReader();
            if (database.dr.HasRows)
            {
                while (database.dr.Read())
                {
                    count++;
                }
            }
            database.dr.Close();
            slides = new AjaxControlToolkit.Slide[count];
            AjaxControlToolkit.Slide img;
            database.cmd.CommandText = "select * from gallery";
            database.dr = database.cmd.ExecuteReader();
            if (database.dr.HasRows)
            {
                int i = 0;
                while (database.dr.Read())
                {
                    img = new AjaxControlToolkit.Slide();
                    img.Description = database.dr["description"].ToString();
                    img.Name = database.dr["title"].ToString();
                    img.ImagePath = "GALLERY" +"\\"+database.dr["picname"].ToString();
                    slides[i] = img;
                    i++;
                }
            }
        }
        catch (Exception ee)
        {
            MessageBox.Show(ee.Message);
        }
        finally
        {
            database.con.Close();
        }
        return slides;
    }
}

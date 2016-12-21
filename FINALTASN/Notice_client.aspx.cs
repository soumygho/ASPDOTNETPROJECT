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
using System.Net;
using System.IO;

public partial class Notice_client : System.Web.UI.Page
{
    dbconnection cn = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        string ID = Request.QueryString["id"].ToString();
        int m=Convert.ToInt32(ID);
        String path=null;
        try
        {
            path = null;
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "SELECT * FROM notice WHERE id=@id ";
            cn.cmd.Parameters.AddWithValue("id",m);
            cn.con.Open();
            cn.dr = cn.cmd.ExecuteReader();
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    path =cn.dr["path"].ToString();
                }
            }
            else
            {
                
            }
        }
        catch(Exception ee)
        {
            
        }
        finally
        {
            cn.dr.Close();
            cn.con.Close();
        }
        if (path != null)
        {
            // try
            // {
            /* WebClient req=new WebClient();
              HttpResponse response = HttpContext.Current.Response;
              response.Clear();
                  response.ClearContent();
                  response.ClearHeaders();
                  response.Buffer= true;
                  response.AddHeader("Content-Disposition","attachment;filename=\"" +path+ "\"");
                  byte[]data=req.DownloadData(Server.MapPath("~/NOTICES").ToString()+"\\"+path);
                  response.BinaryWrite(data);
                  response.End();*/
            string fName = Server.MapPath("~/NOTICES").ToString() + "\\" + path;
            FileInfo fi = new FileInfo(fName);
            long sz = fi.Length;

            Response.ClearContent();
            String filename = "\""+System.IO.Path.GetFileName(fName).ToString()+"\"";
            Response.ContentType = MimeType(Path.GetExtension(fName));
            Response.AddHeader("Content-Disposition", string.Format("attachment; filename = {0}", filename));
            Response.AddHeader("Content-Length", sz.ToString("F0"));
            Response.TransmitFile(fName);
            Response.End();
            //  }
            //  catch (Exception ee)
            // {
            //  MessageBox.Show(ee.Message);
            // }
            // finally
            // {
            //}
        }
    }
    public static string MimeType(string Extension)
    {
      string mime = "application/octetstream";
      if (string.IsNullOrEmpty(Extension))
        return mime;
      string ext = Extension.ToLower();
      Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
      if (rk != null && rk.GetValue("Content Type") != null)
        mime = rk.GetValue("Content Type").ToString();
      return mime;
    } 
}
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
using System.Data.SqlClient;

public partial class noticedetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        try
        {
            db.con.Open();
            db.cmd.CommandText = "select * from notice";
            db.cmd.Connection = db.con;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(db.cmd);
            da.Fill(ds);
            ListView1.DataSource = ds;
            ListView1.DataBind();
           // int i = 1;
           /* if (db.dr.HasRows)
            {
                System.Web.UI.WebControls.Label num1 = new System.Web.UI.WebControls.Label();
                System.Web.UI.WebControls.Label num2 = new System.Web.UI.WebControls.Label();
                num1.Text = "<br/><br/><center>";
                num2.Text = "</center>";
                Panel1.Controls.Add(num1);
                HtmlTable noticeTable = notices;
                while (db.dr.Read())
                {
                    /*HyperLink link = new HyperLink();
                    link.NavigateUrl = "~/Notice_client.aspx"+"?"+"id="+db.dr["id"].ToString();
                    System.Web.UI.WebControls.Label num = new System.Web.UI.WebControls.Label();
                    System.Web.UI.WebControls.Label br = new System.Web.UI.WebControls.Label();
                    br.Text = "<br/>";
                    num.Text = i.ToString()+".";
                    link.Text = db.dr["sub"].ToString()+"dated" + db.dr["date"].ToString();
                    HtmlTableRow row = new HtmlTableRow();
                    row.Align = "center";
                    HtmlTableCell cell1 = new HtmlTableCell();
                    cell1.Align = "center";
                    Controls.Add(num);
                    Controls.Add(link);
                    Controls.Add(br);*/
                   /* System.Web.UI.WebControls.Label num = new System.Web.UI.WebControls.Label();
                    System.Web.UI.WebControls.Label br = new System.Web.UI.WebControls.Label();
                    String text = db.dr["sub"].ToString()+"dated" + db.dr["date"].ToString();
                    String url = "~/Notice_client.aspx" + "?" + "id=" + db.dr["id"].ToString();
                    HyperLink link = new HyperLink();
                    link.NavigateUrl = "~/Notice_client.aspx" + "?" + "id=" + db.dr["id"].ToString();
                    link.Text = text;
                    num.Text = "&nbsp;&nbsp;&nbsp;";
                    br.Text = "<br/>";
                  //  HtmlTableRow noticeRow = new HtmlTableRow(); 
                   // HtmlTableCell noticeSerial = new HtmlTableCell(); 
                    //noticeSerial.InnerHtml = i.ToString()+"."; 
                    //HtmlTableCell noticeCellForLink = new HtmlTableCell(); 
                   // noticeCellForLink.InnerHtml = "<a href=\"Notice_client.aspx" + "?" + "id=" + db.dr["id"].ToString() + "\">" + db.dr["sub"].ToString() + "dated" + db.dr["date"].ToString() + "</a>"; 
                   // noticeRow.Cells.Add(noticeSerial);
                  //  noticeRow.Cells.Add(noticeCellForLink);
                   // noticeTable.Rows.Add(noticeRow);
                    i++;
                    Panel1.Controls.Add(num);
                    Panel1.Controls.Add(link);
                    Panel1.Controls.Add(br);
                   // Panel1.Controls.Add(tab);
                }
               // Panel1.Controls.Add(num2);
            }*/
        }
        catch (Exception m)
        {
            MessageBox.Show("Error occured:"+m.Message);
        }
        finally
        {
            db.con.Close();
        }
    }
}

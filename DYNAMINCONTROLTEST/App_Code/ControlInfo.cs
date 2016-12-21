using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for ControlInfo
/// </summary>
public class ControlInfo
{
    public String controlid = null;
    public String controltype = null;
    public String top = null;
    public String left = null;
	public ControlInfo(String id,String type,String top,String left)
	{
		//
		// TODO: Add constructor logic here
		//
        controlid = id;
        controltype = type;
        this.top = top;
        this.left = left;
        //eventhandler = handler;
	}
}

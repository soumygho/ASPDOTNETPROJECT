using System;
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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            GetSlides();

    }

    [System.Web.Services.WebMethodAttribute(), System.Web.Script.Services.ScriptMethodAttribute()]
    public static AjaxControlToolkit.Slide[] GetSlides()
    {
        AjaxControlToolkit.Slide[] slides = new AjaxControlToolkit.Slide[4];
        slides[0] = new AjaxControlToolkit.Slide("SLIDE SHOW/0.JPG", "A", "B");
        slides[1] = new AjaxControlToolkit.Slide("SLIDE SHOW/1.JPG", "C", "D");
        slides[2] = new AjaxControlToolkit.Slide("SLIDE SHOW/2.JPG", "E", "F");
        slides[3] = new AjaxControlToolkit.Slide("SLIDE SHOW/3.JPG", "G", "H");
        //return default(AjaxControlToolkit.Slide[]);
        return slides;
        //return default(AjaxControlToolkit.Slide[]);
    }
}

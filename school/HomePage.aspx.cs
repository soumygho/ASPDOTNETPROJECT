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

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [System.Web.Services.WebMethodAttribute(), System.Web.Script.Services.ScriptMethodAttribute()]
    public static AjaxControlToolkit.Slide[] GetSlides(string contextKey)
    {
        AjaxControlToolkit.Slide[] slides = new AjaxControlToolkit.Slide[7];
        slides[0] = new AjaxControlToolkit.Slide("SLIDE/1.JPG", "SCHOOL BUILDING FRONT VIEW", "VIEW_FRONT");
        slides[1] = new AjaxControlToolkit.Slide("SLIDE/2.jpg", "HOSTEL BUILDING FRONT VIEW", "VIEW_HOSTEL_FRONT");
        slides[2] = new AjaxControlToolkit.Slide("SLIDE/3.jpg", "PLAYGROUND", "a");
        slides[3] = new AjaxControlToolkit.Slide("SLIDE/4.jpg", "OLD BUILDING", "b");
        slides[4] = new AjaxControlToolkit.Slide("SLIDE/5.jpg", "COMPUTER LAB", "c");
        slides[5] = new AjaxControlToolkit.Slide("SLIDE/6.jpg", "FIRST FLOOR OF THE MAIN BUILDING", "d");
        slides[6] = new AjaxControlToolkit.Slide("SLIDE/7.jpg", "FIRST FLOOR OF THE MAIN BUILDING", "e");
        return slides;
    }
}


<%@ WebHandler Language="C#" Class="ImageHandler" %>

using System;
using System.Web;

public class ImageHandler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        imageWebService.imageWebService client = new imageWebService.imageWebService();
        string url = context.Request["url"];
        byte[] image = client.getImageFile(url);
        if (image.Length == 1)
        {
        }
        else
        {
            context.Response.ContentType = "image/jpeg";
            context.Response.BinaryWrite(image);
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}
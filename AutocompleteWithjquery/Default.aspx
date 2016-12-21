<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="js/jquery-ui.css"/>
 
<link rel="stylesheet" type="text/css" href="js/autocomplete.css"/>
 
<script type="text/javascript" src="js/jquery.js"></script>
 
<script type="text/javascript" src="js/jquery-ui.min.js" ></script>
 
<script type="text/javascript" src="js/jquery.ui.autocomplete.html.js"></script>
 
<script type="text/javascript">
    window.onload = function() {
        /* $.ajax({
        url: "http://localhost:1537/AutocompleteWithjquery/autocompleteservice.asmx/getList",
        data: "", //ur data to be sent to server
        contentType: "application/json; charset=utf-8",
        type: "POST",
        success: function(data) {

            var obj = JSON.parse(data.d);
        alert(obj[0].Id);
        },
        error: function(x, y, z) {
        alert(x.responseText + "  " + x.status);
        }
        });*/
        var obj;

        $("#<%=TextName.ClientID %>").autocomplete(
        {


            source: function(request, response) {
                $.ajax(
    {
        url: "http://localhost:1537/AutocompleteWithjquery/autocompleteservice.asmx/getList",
        data: "",
        contentType: "application/json; charset=utf-8",
        type: "POST",
        success: function(data) {
            obj = JSON.parse(data.d);
            var list = [obj[0].Name, obj[1].Name];
            response(list);

        },
        failure: function(errMsg) {
            alert("ERROR OCCURED");
        }
    }
    );
            },
            select: function(event, ui) {
                $("#<%=TextName.ClientID %>").val(ui.item.value);
                for (var i = 0; i < obj.length; i++) {
                    if (ui.item.value == obj[i].Name) {

                        $("#<%=idfield.ClientID %>").val(obj[i].Id);
                        $("#<%=email.ClientID %>").text(obj[i].Id);
                        alert( $("#<%=idfield.ClientID %>").val());
                        break;
                    }
                }

            }
        }
    );
    };
    
</script>
</head>
<body >
    <form id="form1" runat="server">
    <div>
    <center>AUTO COMPLEMETE DEMO WITH JQUERY</center>
        <br />
        ENTER NAME
        <asp:TextBox type="text" id ="TextName" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="FIND" />
        <br />
        <asp:HiddenField ID="idfield" runat="server" />
        <br />
        <asp:Panel ID="Panel1" runat="server">
            EMAIL :
            <asp:Label ID="email" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
        <div id = "jsonDiv">
        </div>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        ShowFooter="True" DataKeyNames="roll" 
                        onrowcancelingedit="GridView1_RowCancelingEdit" 
                        onrowcommand="GridView1_RowCommand" onrowdeleting="GridView1_RowDeleting" 
                        onrowediting="GridView1_RowEditing" onrowupdating="GridView1_RowUpdating" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:TemplateField HeaderText="Operations">
                                <EditItemTemplate>
                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Update">Update</asp:LinkButton>
                                    &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:LinkButton ID="LinkButton4" runat="server" CommandName="AddData">Add</asp:LinkButton>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="EDIT">Edit</asp:LinkButton>
                                    &nbsp;
                                    <asp:LinkButton ID="LinkButton5" runat="server" CommandName="DELETE" OnClientClick="return confirm('Do you want to delete this record?');">Delete</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Name">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%#Eval("stuname") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("stuname") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Roll">
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("roll") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Class">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%#Eval("class") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("class") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Sec">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox4" runat="server" Text='<%#Eval("sec") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("sec") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="4" rowspan="4" style="text-align: center">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

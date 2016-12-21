<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

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
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td colspan="3" rowspan="6">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        Height="133px" onrowcommand="GridView1_command" style="text-align: center" 
                        Width="397px" DataKeyNames="roll" onrowcancelingedit="GridView1_Cancel" 
                        onrowdeleting="GridView1_Delete" onrowediting="GridView1_Edit" 
                        onrowupdating="GridView1_Update" ShowFooter="True">
                        <Columns>
                            <asp:TemplateField HeaderText="OPERATION">
                                <EditItemTemplate>
                                    <asp:LinkButton ID="LinkButton3" runat="server" CommandName="Update">UPDATE</asp:LinkButton>
                                    &nbsp;<asp:LinkButton ID="LinkButton4" runat="server" CommandName="Cancel">CANCEL</asp:LinkButton>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:LinkButton ID="LinkButton5" runat="server" CommandName="Add">ADD</asp:LinkButton>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">EDIT</asp:LinkButton>
                                    &nbsp;
                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Delete">DELETE</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="NAME">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<% #Eval("name")%>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%#Eval("name") %>'></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("name") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="CLASS">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("class") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Eval("class") %>'></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("class") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ROLL">
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Eval("roll") %>'></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("roll") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
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
                    &nbsp;</td>
                <td style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Text="Label" style="text-align: center"></asp:Label>
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

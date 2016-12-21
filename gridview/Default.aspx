<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            border: 4px solid #00FFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        Height="285px" Width="1225px" ShowFooter="True" DataKeyNames="st_id" 
                        onrowcancelingedit="GridView1_RowCancelingEdit" 
                        onrowcommand="GridView1_RowCommand" onrowdeleting="GridView1_RowDeleting" 
                        onrowediting="GridView1_RowEditing" onrowupdating="GridView1_RowUpdating" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged">
                        <FooterStyle BackColor="BlueViolet" />
                        <Columns>
                            <asp:TemplateField HeaderText="OPERATIONS">
                                <AlternatingItemTemplate>
                                    &nbsp;
                                </AlternatingItemTemplate>
                                <EditItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="UPDATE">UPDATE</asp:LinkButton>
                                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CommandName="CANCEL">CANCEL</asp:LinkButton>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:LinkButton ID="LinkButton5" runat="server" BackColor="#99FF99" 
                                        CommandName="ADD">ADD</asp:LinkButton>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton3" runat="server" CommandName="EDIT">EDIT</asp:LinkButton>
                                    &nbsp;<asp:LinkButton ID="LinkButton4" runat="server" CommandName="DELETE">DELETE</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="STUDENT ID">
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox10" runat="server" Text='<%#Eval("st_id") %>'></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("st_id") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="STUDENT NAME">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Height="42px" Width="303px" Text='<%#Eval("st_name") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Height="41px" Width="309px" Text='<%#Eval("st_name") %>'></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("st_name") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="STUDENT ADDRESS">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Height="41px" Width="301px" Text='<% #Eval("st_address")%>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox4" runat="server" Height="41px" Width="303px" Text='<% #Eval("st_address")%>'></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server"  Text='<% #Eval("st_address")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="STUDENT ROLL">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox5" runat="server" Height="48px" Width="314px" Text='<% #Eval("st_roll")%>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox6" runat="server" Height="48px" Width="318px" Text='<% #Eval("st_roll")%>'></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<% #Eval("st_roll")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="STUDENT COURSE">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox9" runat="server" Height="47px" Width="342px" Text='<% #Eval("st_course")%>'></asp:TextBox>
         
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox8" runat="server" Height="44px" Width="347px" Text='<% #Eval("st_course")%>'></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<% #Eval("st_course")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
    
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
                <td colspan="3" rowspan="4">
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

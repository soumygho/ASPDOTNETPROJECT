<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            border: 4px solid #000080;
            background-color: #00FFFF;
        }
        .style2
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
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        BackColor="#FF66FF" BorderColor="Blue" DataKeyNames="stu_id" 
                        ForeColor="#99FF99" onrowcancelingedit="GridView1_Cancel" 
                        onrowcommand="GridView1_Add" onrowdeleting="GridView1_Delete" 
                        onrowediting="GridView1_Edit" onrowupdating="GridView1_Update" 
                        ShowFooter="True" onselectedindexchanged="GridView1_SelectedIndexChanged1">
                        <Columns>
                            <asp:TemplateField HeaderText="OPERATION">
                                <EditItemTemplate>
                                    <asp:LinkButton ID="LinkButton3" runat="server" CommandName="UPDATE">UPDATE</asp:LinkButton>
                                    &nbsp;
                                    <asp:LinkButton ID="LinkButton4" runat="server" CommandName="CANCEL">CANCEL</asp:LinkButton>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:LinkButton ID="LinkButton5" runat="server" CommandName="ADD">ADD</asp:LinkButton>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="EDIT">EDIT</asp:LinkButton>
                                    &nbsp;&nbsp;&nbsp;
                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="DELETE">DELETE</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="STUDENT ID">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="214px"></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Width="217px" Text='<%#Eval("stu_id") %>'></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("stu_id") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="STUDENT NAME">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Height="24px" Width="218px" Text='<%#Eval("stu_name") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox4" runat="server" Width="216px" Text='<%#Eval("stu_name") %>'></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("stu_name") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="COURSE">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox5" runat="server" Height="24px" Width="214px" Text='<%#Eval("stu_course") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox6" runat="server" Width="217px" Text='<%#Eval("stu_course") %>'></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("stu_id") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="SUBJECT">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox7" runat="server" Height="22px" Width="219px" Text='<%#Eval("stu_sub") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBox8" runat="server" Text='<%#Eval("stu_sub") %>'></asp:TextBox>
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("stu_sub") %>'></asp:Label>
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
                <td colspan="4" rowspan="5">
                    <br />
                    <br />
                    <table class="style2">
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td rowspan="4">
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
                    </table>
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
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
            </tr>
            <tr>
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
            </tr>
            <tr>
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

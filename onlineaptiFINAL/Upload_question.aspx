<%@ Page Language="C#" MasterPageFile="~/HOME.master" AutoEventWireup="true" CodeFile="Upload_question.aspx.cs" Inherits="Upload_question" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
        }
        .style4
        {
            font-size: large;
            color: #FF3300;
        }
        .style5
        {
            font-size: large;
            font-weight: bold;
            color: #FF3300;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style3">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style5" style="text-align: center">
                UPLOAD QUESTIONS AND ANSWERS</td>
            <td class="style4" style="font-weight: 700; text-align: center">
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
                    BackColor="Aqua" onrowcancelingedit="Cancel" onrowdeleting="Delete" 
                    onrowediting="Edit" onrowupdating="Update" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" 
                    DataKeyNames="quesid" Height="188px" Width="1035px" ShowFooter="True" 
                    BorderColor="#000066" onrowcommand="Add">
                    <Columns>
                        <asp:TemplateField HeaderText="OPERATION">
                            <EditItemTemplate>
                                <asp:Button ID="Button3" runat="server" Text="UPDATE" 
                                    
                                    style="font-weight: 700; font-size: large; color: #FF3300; background-color: #00FFCC" 
                                    CommandName="Update" />
                                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button4" runat="server" Text="CANCEL" 
                                    
                                    style="font-weight: 700; font-size: large; color: #FF3300; background-color: #00FFCC" 
                                    CommandName="Cancel" />
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:Button ID="Button5" runat="server" Text="ADD" 
                                    
                                    style="font-weight: 700; font-size: large; color: #FF3300; background-color: #00FFCC" 
                                    CommandName="Add" />
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" Text="EDIT" 
                                    
                                    style="font-weight: 700; color: #FF0000; font-size: large; background-color: #CCFFCC" 
                                    CommandName="Edit" />
                                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button2" runat="server" Text="DELETE" 
                                    
                                    style="font-weight: 700; color: #FF3300; font-size: large; background-color: #CCFFCC" 
                                    CommandName="Delete" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="QUESTION">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Text='<%#Eval("question") %>'></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="TextBox2" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Text = "PLEASE WRITE"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="TextBox3" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" 
                                    style="font-weight: 700; font-size: large; color: #000099" Text='<%#Eval("question") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="OPTION A">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%#Eval("optiona") %>'></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ControlToValidate="TextBox4" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="TextBox5" runat="server" Text = "PLEASE WRITE"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                    ControlToValidate="TextBox5" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" 
                                    style="font-weight: 700; font-size: large; color: #000099" Text='<%#Eval("optiona") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="OPTION B">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox6" runat="server" Text='<%#Eval("optionb") %>'></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                    ControlToValidate="TextBox6" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="TextBox7" runat="server" Text = "PLEASE WRITE"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                    ControlToValidate="TextBox7" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" 
                                    style="font-weight: 700; font-size: large; color: #000099" Text='<%#Eval("optionb") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="OPTION C">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox8" runat="server" Text='<%#Eval("optionc") %>'></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                    ControlToValidate="TextBox8" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="TextBox9" runat="server" Text = "PLEASE WRITE"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                    ControlToValidate="TextBox9" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" 
                                    style="font-weight: 700; font-size: large; color: #000099" Text='<%#Eval("optionc") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="OPTION D">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox10" runat="server" Text='<%#Eval("optiond") %>'></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                    ControlToValidate="TextBox10" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="TextBox11" runat="server" Text = "PLEASE WRITE"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                    ControlToValidate="TextBox11" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" 
                                    style="font-weight: 700; font-size: large; color: #000099" Text='<%#Eval("optiond") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="RIGHT ANS">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox12" runat="server" Text='<%#Eval("ans") %>'></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                    ControlToValidate="TextBox12" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="TextBox13" runat="server" Text = "PLEASE WRITE"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                                    ControlToValidate="TextBox13" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server" 
                                    style="font-weight: 700; font-size: large; color: #FF3300" Text='<%#Eval("ans") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
            <td>
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
            <td>
                &nbsp;</td>
            <td style="text-align: center; font-weight: 700; color: #FF3300">
                TOTAL NO OF QUESTIONS IN THE DATABASE:=
                <asp:Label ID="Label8" runat="server" 
                    style="font-size: x-large; color: #000099" Text="Label"></asp:Label>
            </td>
            <td style="text-align: center">
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
            <td style="text-align: center">
                <asp:Label ID="Label7" runat="server" style="color: #FF3300; font-size: large; font-weight: 700;" 
                    Text="Label"></asp:Label>
            </td>
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
            <td style="font-weight: 700; text-align: center">
                <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#FF3300" 
                    onclick="LinkButton1_Click" style="font-size: x-large">Log out&gt;&gt;</asp:LinkButton>
            </td>
            <td style="font-weight: 700; text-align: center">
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
</asp:Content>


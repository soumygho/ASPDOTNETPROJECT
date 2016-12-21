<%@ Page Title="" Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="userdetails.aspx.cs" Inherits="userdetails" %>

<%@ Register assembly="DataPagerRepeater" namespace="DataPagerRepeater" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <cc1:DataPagerRepeater ID="DataPagerRepeater2" runat="server" 
                                         PersistentDataSource="true" 
        onitemcommand="DataPagerRepeater2_ItemCommand">
        <HeaderTemplate>
            <div>
                <br />
            </div>
        </HeaderTemplate>
        <ItemTemplate>
            <div style=" border: thin solid #000066;background-color :White;">
                <div>
                    <table>
                        <tr>
                            <td>
                                                               NAME 
                                                            </td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                ADDRESS</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text='<%#Eval("Address") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                DATE OF BIRTH</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("Dob") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                OCCUPATION</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text='<%#Eval("Occupation") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                WORKS AT</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text='<%#Eval("Worksat") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                DESIGNATION</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text='<%#Eval("Designation") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                WORKS FROM</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text='<%#Eval("Worksfrom") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                COLLEGE NAME</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text='<%#Eval("Collegename") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                STUDIED</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text='<%#Eval("Specialization") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                SCHOOL NAME</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text='<%#Eval("Schoolname") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                STUDENT FROM</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label12" runat="server" Text='<%#Eval("Studentfrom") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                PASSED FROM SCHOOL IN</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label13" runat="server" Text='<%#Eval("Schoolpassingyear") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                MOBILE NO</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label14" runat="server" Text='<%#Eval("Mobno") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                SECONDARY MOBILE NO</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label15" runat="server" Text='<%#Eval("Secondarymobno") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                EMAIL ADDRESS</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label16" runat="server" Text='<%#Eval("Emailaddress") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                FAVOURITE QUOTE 
                            </td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label17" runat="server" Text='<%#Eval("Favouritequote") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                ABOUT</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label18" runat="server" Text='<%#Eval("About") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                GENDER</td>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="Label19" runat="server" Text='<%#Eval("Gender") %>'></asp:Label>
                            </td>
                        </tr>
                    </table>
                </div>
        </ItemTemplate>
        <FooterTemplate>
        </FooterTemplate>
        <SeparatorTemplate>
            <div>
                <br />
            </div>
        </SeparatorTemplate>
    </cc1:DataPagerRepeater>

</asp:Content>


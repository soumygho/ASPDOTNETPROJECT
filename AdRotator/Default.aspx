<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="aj" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
       .abc1
        {
        	background-color:Blue;
        	color:Red;
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
                <td colspan="4" rowspan="3">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
              <Triggers>
              <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
              </Triggers>
                        <ContentTemplate>
                       
                            <asp:ScriptManager ID="ScriptManager1" runat="server" >
                            </asp:ScriptManager>
                            <asp:AdRotator ID="AdRotator1" runat="server" 
                                AdvertisementFile="~/AdvertisementFile.xml" KeywordFilter="ABC" 
                                Target="_blank" />
                            <br />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <aj:TextBoxWatermarkExtender ID="ab" runat="server" WatermarkText="Enter Your Name" TargetControlID="TextBox1" WatermarkCssClass="abc1"></aj:TextBoxWatermarkExtender>
                </td>
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
                    <asp:Timer ID="Timer1" runat="server" Interval="5000">
                    </asp:Timer>
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
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Wizard ID="Wizard1" runat="server" BackColor="#FFFBD6" 
                        BorderColor="#FFDFAD" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em">
                        <SideBarTemplate>
                            <asp:DataList ID="SideBarList" runat="server">
                                <ItemTemplate>
                                    <asp:LinkButton ID="SideBarButton" runat="server" ForeColor="White"></asp:LinkButton>
                                </ItemTemplate>
                                <SelectedItemStyle Font-Bold="True" />
                            </asp:DataList>
                        </SideBarTemplate>
                        <StartNavigationTemplate>
                            aaaaaaaaaa
                        </StartNavigationTemplate>
                        <WizardSteps>
                            <asp:WizardStep runat="server" title="Step 1">
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" title="Step 2">
                            </asp:WizardStep>
                        </WizardSteps>
                        <SideBarButtonStyle ForeColor="White" />
                        <NavigationButtonStyle BackColor="White" BorderColor="#CC9966" 
                            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
                            ForeColor="#990000" />
                        <SideBarStyle BackColor="#990000" Font-Size="0.9em" VerticalAlign="Top" />
                        <HeaderStyle BackColor="#FFCC66" BorderColor="#FFFBD6" BorderStyle="Solid" 
                            BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="#333333" 
                            HorizontalAlign="Center" />
                        <HeaderTemplate>
                            Hello
                        </HeaderTemplate>
                    </asp:Wizard>
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
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

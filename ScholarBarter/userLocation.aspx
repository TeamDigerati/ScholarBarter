<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userLocation.aspx.cs" Inherits="ScholarBarter.userLocation" %>


<%@ Register assembly="Reimers.Google.Map" namespace="Reimers.Google.Map" tagprefix="Reimers" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>


                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click"  Text="Button" />


                <Reimers:Map ID="Map1" runat="server" Width="600" Height="400" DefaultMapType="Terrain">
    <Center Latitude="51.477" Longitude="0.0" />

</Reimers:Map>     

      </ContentTemplate>
                </asp:UpdatePanel>

    </form>
</body>
</html>
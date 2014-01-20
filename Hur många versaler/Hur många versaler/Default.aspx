<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hur_många_versaler.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Style/Style.css" rel="stylesheet" type="text/css" />
    <title>Versalräknare</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="Text" runat="server" Height="200px" Width="400px" TextMode="MultiLine" autofocus="true" CssClass="textbox"></asp:TextBox>
        <asp:Button ID="Button" runat="server" Text="Submit" OnClick="Button1_Click" />
        <p>
        <asp:Label ID="Result" runat="server" Text=""></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>

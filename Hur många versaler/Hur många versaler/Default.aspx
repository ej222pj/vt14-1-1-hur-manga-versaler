<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hur_många_versaler.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="Text" runat="server" Height="158px" Width="379px"></asp:TextBox>
        
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Button1_Click" />
            <asp:Button ID="Reset" runat="server" Text="Reset" OnClick="Button1_Click1" />
        <p>
        <asp:Label ID="Result" runat="server" Text=""></asp:Label>
        </p>
        </div>
    </form>
</body>
</html>

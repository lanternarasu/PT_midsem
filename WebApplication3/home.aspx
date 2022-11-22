<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication3.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="HOME PAGE"></asp:Label>
        </p>
        <asp:Label ID="Label2" runat="server" Text="CLICK YOUR CHOICE"></asp:Label>
        <p>
            <asp:RadioButton ID="RadioButton1" runat="server"  Text="UG" />
        </p>
        <asp:RadioButton ID="RadioButton2" runat="server" Text="PG" />
        <p>
            <asp:Button ID="Button1" runat="server" Text="GO" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>

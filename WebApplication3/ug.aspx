<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ug.aspx.cs" Inherits="WebApplication3.ug" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Enter Reg_No"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="get details" />
        <p>
            <asp:Label ID="Label2" runat="server" Text="reg_no"></asp:Label>
            <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="name"></asp:Label>
            <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="year"></asp:Label>
            <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="course"></asp:Label>
            <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Label ID="Label6" runat="server" Text="sub_name"></asp:Label>
        <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Label ID="Label7" runat="server" Text="test1"></asp:Label>
            <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Label ID="Label8" runat="server" Text="test2"></asp:Label>
        <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Label ID="Label9" runat="server" Text="test3"></asp:Label>
            <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Label ID="Label10" runat="server" Text="assignment"></asp:Label>
        <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Label ID="Label20" runat="server" Text="attendance"></asp:Label>
            <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="calculate" />
        <p>
            <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
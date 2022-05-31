<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NullOrEmptyOrNaN.aspx.cs" Inherits="WebApplicationProjectForTheService.NullOrEmptyOrNaN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <asp:Label ID="Label1" runat="server" Text="Неверный символ или значение NAN"></asp:Label>

        </div>
        <asp:Button ID="Button" runat="server" Text="Go back" OnClick="Button_Click" />
        </div>
    </form>
</body>
</html>

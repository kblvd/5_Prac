<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCalc.aspx.cs" Inherits="WebApplicationProjectForTheService.WebFormCalc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxArgA" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
&nbsp;<asp:TextBox ID="TextBoxArgB" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            <asp:Button ID="ButtonCalcAdd" runat="server" OnClick="ButtonCalcAdd_Click" Text="Сложение" />            
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCalcSubst" runat="server" OnClick="ButtonCalcSubst_Click" Text="Вычитание" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCalcDiv" runat="server" OnClick="ButtonCalcDiv_Click" Text="Деление" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCalcMult" runat="server" OnClick="ButtonCalcMult_Click" Text="Умножение" />
            &nbsp;&nbsp;&nbsp;
            <br />
            <br /><br /><asp:Label ID="Label4Answer" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

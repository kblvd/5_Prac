<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl.ascx.cs" Inherits="Prac5.WebUserControl" %>
<asp:TextBox ID="TextBoxVarA" runat="server"></asp:TextBox>
<p>
    &nbsp;</p>
<asp:TextBox ID="TextBoxVarB" runat="server"></asp:TextBox>
<p>
    &nbsp;</p>
<p>
<asp:Button ID="ButtonCalcAdd" runat="server" OnClick="ButtonCalcAdd_Click" Text="Сложение" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonCalcSubst" runat="server" OnClick="ButtonCalcSubst_Click" Text="Вычитание" Width="80px" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonCalcDiv" runat="server" OnClick="ButtonCalcDiv_Click" Text="Деление" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonCalcMult" runat="server" OnClick="ButtonCalcMult_Click" Text="Умножение" Width="90px" />    
</p>
<br />
<br />
<asp:Label ID="LabelAnswer" runat="server"></asp:Label>


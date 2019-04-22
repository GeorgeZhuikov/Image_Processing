<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SE_WA.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="scm" runat="server">
            </asp:ScriptManager>
            <asp:Panel ID="pnl" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Поисковик"></asp:Label>
                <br />
                <br />
            </asp:Panel>
            <asp:UpdatePanel ID="updSearch" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:TextBox ID="txb" runat="server" Placeholder="Введите запрос"></asp:TextBox>
                    <asp:Button ID="btn" runat="server" Text="Искать" OnClick="btn_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
                <br />
            <asp:UpdatePanel ID="updResult" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>

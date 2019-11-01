<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaInicial.aspx.cs" Inherits="Projeto25._10.PaginaInicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Boas vindas visitantes!</h3>
        <p>&nbsp;</p>
        <h4>Lista de cursos abertos para o ano de 2019:</h4>
        <p>
            <asp:GridView ID="GVMatricula" runat="server">
            </asp:GridView>
        </p>
        <div>
            Deseja se Increver? Clique aqui<br />
            <asp:Button ID="btnAluno" runat="server" OnClick="btnAluno_Click" Text="Matricule-se" />
            <br />
            <br />
            Já é incrito? Clique aqui e consulte quem mais se increveu!<br />
            <asp:Button ID="txtLogar" runat="server" Text="Logar" OnClick="txtLogar_Click" />
        </div>
    </form>
</body>
</html>

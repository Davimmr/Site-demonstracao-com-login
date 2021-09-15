<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Deletar.aspx.cs" Inherits="projetoSemente.Deletar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="imgfundo">   
    <div>
        <img id="logo" src="images/tecladofull2.png" />
    <nav id="menu">
    <ul>
        <li><a href="inicio.aspx">Home</a></li>
        <li><a href="trabalhe.aspx">Trabalhe Conosco</a></li>
        <li><a href="sobre.aspx">Sobre</a></li>
        <li><a href="local.aspx">Como Chegar</a></li>
        <li><a href="login.aspx">Login</a></li>
    </ul>
</nav>
    </div>
            </div>
        <div>
    <h2>Deletar Contato</h2>
    Informe o código do contato : 
    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
    <p />
    <asp:Button ID="btnDeletar" runat="server" Text="Deletar Contato" OnClick="btnDeletar_Click"/>
    <p />
    <asp:Label ID="lblmsg" runat="server" EnableViewState="False"></asp:Label>
    <p />
    <a href="sistema.aspx">Retorna o Menu</a>
        </div>
        <br />
        <br />
<footer>
       <p> Copyright © Action Finger 2017. Todos os direitos reservados.<br />
        Email: ActionFinger@Hotmail.com - TEL(11)4002-8922 </p>
</footer>
    </form>
</body>
</html>

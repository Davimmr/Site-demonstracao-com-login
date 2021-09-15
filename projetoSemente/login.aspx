<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="projetoSemente.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TIO - Login</title>
    <style type="text/css">
        #menu {
            height: 166px;
            width: 1119px;
            margin-right: 0px;
        }
        .auto-style2 {
            width: 103px;
        }
        .auto-style3 {
            width: 89px;
        }
    </style>
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
        
        <div style="text-align:center;">
    <h1 style="margin-left:0px;">Efetue o Login</h1>
        Usuário<br />
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        Senha<br />
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />
        <br />
        <asp:Literal ID="processamento" runat="server"></asp:Literal>
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


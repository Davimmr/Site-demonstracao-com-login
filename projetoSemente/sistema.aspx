<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sistema.aspx.cs" Inherits="projetoSemente.sistema" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Funcionario</title>
    <link href="css/estilos.css" rel="stylesheet" />
</head>

<body>
      <style type="text/css">
          .style1 {
          text-align:center;
           font-size:15pt;
          }
          #menu {
            height: 166px;
            width: 1119px;
            margin-right: 0px;
        }
    </style>
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
        <asp:Literal ID="DadosLogon" runat="server"></asp:Literal>
        <br />
            <h1 style="margin:0px;text-align:center;">Cadastro de Funcionario</h1>
              <table class="style" style="text-align:center; font-size:16pt; text-decoration:none;">
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center;">
                    &nbsp;          
                    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Incluir.aspx" style="font-family: 'Trebuchet MS'">Incluir novo Funcionario </asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <br /><asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Atualizar.aspx" style="font-family: 'Trebuchet MS'">Atualizar Funcionario</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <br /><asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/Deletar.aspx" style="font-family: 'Trebuchet MS'">Deletar Funcionario</asp:LinkButton>
                </td>
                
            </tr>
            <tr>
                <td style="text-align: center">
                 <br /><asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/Listar.aspx" style="font-family: 'Trebuchet MS'">Listar Funcionario</asp:LinkButton>
                </td>
            </tr>

            <tr>
                <td><br /><asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" /></td>
                <td class="style4">
                </td>
            </tr>
            <tr>
                <td>
                   </td>
            </tr>
        </table>
        <div>

    </div>
        <br />
<footer>
       <p> Copyright © Action Finger 2017. Todos os direitos reservados.<br />
        Email: ActionFinger@Hotmail.com - TEL(11)4002-8922 </p>
</footer>
    </form>
    <p>
        </p>

</body>
</html>



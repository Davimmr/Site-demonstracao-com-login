<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Atualizar.aspx.cs" Inherits="projetoSemente.Atualizar" %>

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
            <h1>Atualizar tablea Funcionario</h1>
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            <asp:Button ID="btnGetDetalhes" runat="server" Text="Obter Detalhes" OnClick="btnGetDetalhes_Click" />
            Codigo: <asp:TextBox ID="Codigo" runat="server"></asp:TextBox><span id="vCodigo"></span>
            <br />
            <br />
            Nome: <asp:TextBox ID="Nome" runat="server"></asp:TextBox><span id="vNome"></span>
            <br />
            <br />
            Endereço: <asp:TextBox ID="Endereco" runat="server"></asp:TextBox><span id="vEndereco"></span>
            <br />
            <br />
            Bairro: <asp:TextBox ID="Bairro" runat="server"></asp:TextBox><span id="vBairro"></span>
            <br />
            <br />
            CEP: <asp:TextBox ID="cep" runat="server"></asp:TextBox><span id="vcep"></span>
            <br />
            <br />
            Municipio: <asp:TextBox ID="Municipio" runat="server"></asp:TextBox><span id="vMunicipio"></span>
            <br />
            <br />
             UF: <asp:TextBox ID="uf" runat="server"></asp:TextBox><span id="vuf"></span>
            <br />
            <br />
            DataAdmissao <asp:TextBox ID="DataAdmissao" runat="server"></asp:TextBox><span id="vDataAdmissao"></span>
            <br />
            <br />
            Telefone: <asp:TextBox ID="Telefone" runat="server"></asp:TextBox><span id="vTelefone"></span>
            <br />
            <br />
            Email: <asp:TextBox ID="Email" runat="server"></asp:TextBox><span id="vEmail"></span>
            <br />
            <br />
            CPF : <asp:TextBox ID="cpf" runat="server"></asp:TextBox><span id="vcpf"></span>
            <br />
            <br />
            Cargo: <asp:TextBox ID="Cargo" runat="server"></asp:TextBox><span id="vCargo"></span>
            <br />
            <br />
            Departamento: <asp:TextBox ID="Departamento" runat="server"></asp:TextBox><span id="vDepartamento"></span>
            <br />
            <br />
        <asp:Button ID="btnAtualiza" runat="server" Text="Atualizar Contato" Enabled="false" OnClick="btnAtualizar_Click" /><br />
        <br />
        <asp:Label ID="lblmsg" runat="server" EnableViewState="False"></asp:Label><br />
        <p />
        <a href="sistema.aspx">Retornar ao Menu</a>
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

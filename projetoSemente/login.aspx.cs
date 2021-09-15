using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projetoSemente
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // ação login
            string usuario, senha;
            bool resultado;

            usuario = txtUsuario.Text;
            senha = txtSenha.Text;

            negocio.cadastro objCadastro;

            objCadastro = new negocio.cadastro(); // instancia da classe

            objCadastro.usuario = usuario;
            objCadastro.senha = senha;

            resultado = objCadastro.login();

            if (resultado==true)
            {
                Session["usuariologado"] = true;

                Session["DadosLogon"] = usuario;

                Response.Redirect("sistema.aspx");

            }
            else
            {
                processamento.Text = "Usuário/senha invalido.";
            }

           
        }
    }
}
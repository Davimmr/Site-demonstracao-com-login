using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace projetoSemente
{
    public partial class Incluir : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            funcionarioDAL ctDal = new funcionarioDAL();
            funcionario _contato = new funcionario();
            _contato.Codigo = Int32.Parse(Codigo.Text);
            _contato.Nome = Nome.Text;
            _contato.Endereco = Endereco.Text;
            _contato.Bairro = Bairro.Text;
            _contato.Cep = Int32.Parse(cep.Text);
            _contato.Municipio = Municipio.Text;
            _contato.Uf = uf.Text;
            _contato.DataAdmissao = DateTime.Parse(DataAdmissao.Text);
            _contato.Telefone = Int32.Parse(Telefone.Text);
            _contato.Email = Email.Text;
            _contato.Cpf = Int32.Parse(cpf.Text);
            _contato.Cargo = Cargo.Text;
            _contato.Departamento = Departamento.Text;
           
            try
            {
                ctDal.incluirContato(_contato);
                lblMsg.Text = "Contato incluído com sucesso!";
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error -> " + ex.Message;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projetoSemente
{
    public partial class Atualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGetDetalhes_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                lblmsg.Text = "Código inválido";
                return;
            }

            funcionario c = funcionarioDAL.GetContato(Int32.Parse(txtCodigo.Text));
            if (c != null)
            {
                Codigo.Text = c.Codigo.ToString();
                Nome.Text = c.Nome;
                Endereco.Text = c.Endereco;
                Bairro.Text = c.Bairro;
                cep.Text = c.Cep.ToString();
                Municipio.Text = c.Municipio;
                uf.Text = c.Uf;
                DataAdmissao.Text = c.DataAdmissao.ToString();
                Telefone.Text = c.Telefone.ToString();
                Email.Text = c.Email;
                cpf.Text = c.Cpf.ToString();
                Cargo.Text = c.Cargo;
                Departamento.Text = c.Departamento;
                btnAtualiza.Enabled = true;
            }
            else
            {
                lblmsg.Text = "Contato não encontrado";
                btnAtualiza.Enabled = false;
            }

        }
        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
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
                funcionarioDAL.atualizarContato(_contato);
                lblmsg.Text = "Contato excluído com sucesso!";
            }
            catch (Exception ex)
            {
                lblmsg.Text = "Error -> " + ex.Message;
            }
        }
    }
}
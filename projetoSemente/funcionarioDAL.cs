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
    public class funcionarioDAL
    {
            public static DataSet GetContatos()
            {
                SqlConnection con = new SqlConnection(AcessoDB.ConnectionString);
                SqlDataAdapter da = new SqlDataAdapter("CarregarDados", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds, "contatos");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return ds;
            }

            public static funcionario GetContato(int codigo)
            {
                SqlConnection con = new SqlConnection(AcessoDB.ConnectionString);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("getContato", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        funcionario ct = new funcionario();
                        ct.Codigo = Int32.Parse(dr["codigo"].ToString());
                        ct.Nome = dr["nome"].ToString();
                        ct.Endereco = dr["endereco"].ToString();
                        ct.Bairro = dr["bairro"].ToString();
                        ct.Cep = Int32.Parse(dr["CEP"].ToString());
                        ct.Municipio = dr["municipio"].ToString();
                        ct.Uf = dr["UF"].ToString();
                        ct.DataAdmissao = DateTime.Parse(dr["dataAdmissao"].ToString());
                        ct.Telefone = Int32.Parse(dr["telefone"].ToString());
                        ct.Email = dr["email"].ToString();
                        ct.Cpf = Int32.Parse(dr["CPF"].ToString());
                        ct.Cargo = dr["cargo"].ToString();
                        ct.Departamento = dr["departamento"].ToString();
                        return ct;
                    }
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }

            public void incluirContato(funcionario contato)
            {
                SqlConnection con = new SqlConnection(AcessoDB.ConnectionString);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("InserirDados", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", contato.Codigo);
                    cmd.Parameters.AddWithValue("@nome", contato.Nome);
                    cmd.Parameters.AddWithValue("@endereco", contato.Endereco);
                    cmd.Parameters.AddWithValue("@bairro", contato.Bairro);
                    cmd.Parameters.AddWithValue("@CEP", contato.Cep);
                    cmd.Parameters.AddWithValue("@municipio", contato.Municipio);
                    cmd.Parameters.AddWithValue("@UF", contato.Uf);
                    cmd.Parameters.AddWithValue("@dataAdmissao", contato.DataAdmissao);
                    cmd.Parameters.AddWithValue("@telefone", contato.Telefone);
                    cmd.Parameters.AddWithValue("@email", contato.Email);
                    cmd.Parameters.AddWithValue("@CPF", contato.Cpf);
                    cmd.Parameters.AddWithValue("@cargo", contato.Cargo);
                    cmd.Parameters.AddWithValue("@departamento", contato.Departamento);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;  // retorna mensagem de erro
                }
                finally
                {
                    con.Close();
                }
            }
            public static string deletarContato(int codigo)
            {
                SqlConnection con = new SqlConnection(AcessoDB.ConnectionString);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DeletarDados", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.ExecuteNonQuery();
                    return null; // success 
                }
                catch (Exception ex)
                {
                    throw ex;  // retorna mensagem de erro
                }
                finally
                {
                    con.Close();
                }
            }
            public static string atualizarContato(funcionario contato)
            {
                SqlConnection con = new SqlConnection(AcessoDB.ConnectionString);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AtualizarDados", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", contato.Codigo);
                    cmd.Parameters.AddWithValue("@nome", contato.Nome);
                    cmd.Parameters.AddWithValue("@endereco", contato.Endereco);
                    cmd.Parameters.AddWithValue("@bairro", contato.Bairro);
                    cmd.Parameters.AddWithValue("@CEP", contato.Cep);
                    cmd.Parameters.AddWithValue("@municipio", contato.Municipio);
                    cmd.Parameters.AddWithValue("@UF", contato.Uf);
                    cmd.Parameters.AddWithValue("@dataAdmissao", contato.DataAdmissao);
                    cmd.Parameters.AddWithValue("@telefone", contato.Telefone);
                    cmd.Parameters.AddWithValue("@email", contato.Email);
                    cmd.Parameters.AddWithValue("@CPF", contato.Cpf);
                    cmd.Parameters.AddWithValue("@cargo", contato.Cargo);
                    cmd.Parameters.AddWithValue("@departamento", contato.Departamento);
                    cmd.ExecuteNonQuery();
                    return null; // success 
                }
                catch (Exception ex)
                {
                    throw ex;  // retorna mensagem de erro
                }
                finally
                {
                    con.Close();
                }
            }
    }

}

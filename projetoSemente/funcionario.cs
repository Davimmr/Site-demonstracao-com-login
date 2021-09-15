using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projetoSemente
{
    public class funcionario
    {
            public int Codigo { get; set; }
            public string Nome { get; set; }
            public string Endereco { get; set; }
            public string Bairro { get; set; }
            public int Cep { get; set; }
            public string Municipio { get; set; }
            public string Uf { get; set; }
            public DateTime DataAdmissao { get; set; }
            public int Telefone { get; set; }
            public string Email { get; set; }
            public int Cpf { get; set; }
            public string Cargo { get; set; }
            public string Departamento { get; set; }
    }
}
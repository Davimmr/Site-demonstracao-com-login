using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Configuration;

namespace projetoSemente
{
    public class AcessoDB
    {
        static public String ConnectionString
        {
            get
            {    // pega a string de conexão do web.config
                return WebConfigurationManager.ConnectionStrings["ActionFinger"].ConnectionString;
            }
        }
    }
}

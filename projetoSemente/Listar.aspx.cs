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
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                     
                GridView1.DataSource = funcionarioDAL.GetContatos();
                GridView1.DataBind();

            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projetoSemente
{
    public partial class sistema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["usuariologado"] == null)
            {
                Response.Redirect("login.aspx");
            }

            if ( (bool)Session["usuariologado"] == false )
            {
                Response.Redirect("login.aspx");
            }

            DadosLogon.Text = Session["DadosLogon"].ToString() + " - " + DateTime.Now.ToString("dd/MM/yy - HH:mm:ss");
            
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["usuariologado"] = false;
            Response.Redirect("inicio.aspx");
        }
    }
}
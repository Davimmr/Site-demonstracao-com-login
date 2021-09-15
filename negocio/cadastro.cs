using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class cadastro
    {

        public string usuario { get; set; }
        public string senha { get; set; }

        public bool login()
        {
            if (string.IsNullOrEmpty(usuario))
            {
                return false;
            }

            if (string.IsNullOrEmpty(senha))
            {
                return false;
            }

            if (usuario.Substring(0,1) != senha.Substring(0, 1))
            {
                return false;
            }

            return true;
        }


    }
}

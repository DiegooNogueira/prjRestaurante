using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauranteDBTB.controle
{
    static class Conexao
    {
        // classe que devolve string de conexão com o MYSQL
        public static string Open(string Servidor,
            string Database, string User, string Password)
        {
            string strcon = "server=" + Servidor + ";"
                + "user id=" + User + ";"
                + "database=" + Database + ";" +
                "password=" + Password + ";" +
                "persist security info=True";

            return strcon;
        }
    }
}

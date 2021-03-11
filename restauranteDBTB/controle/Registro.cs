using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauranteDBTB.controle
{
    class Registro
    {
        public static string ler(String caminho, string parametro)
        {
            RegistryKey Key = Registry.CurrentUser.OpenSubKey(@caminho);

            if (Key != null)
            {
                return Key.GetValue(parametro).ToString();
            }

            return String.Empty;
        }

        public static void gravar(String caminho, string parametro, string valor)
        {
            RegistryKey Key = Registry.CurrentUser.CreateSubKey(@caminho);
            Key.SetValue(parametro, valor);
        }

    }
}

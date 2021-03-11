using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace restauranteDBTB.controle
{
    class Cripto
    {
        const string chave = "123456";

        public static string criptografar(string texto)
        {
            byte[] Results;
            UTF8Encoding UTF8 = new UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(chave));
            TripleDESCryptoServiceProvider TDESAalgoritmo = new TripleDESCryptoServiceProvider();
            TDESAalgoritmo.Key = TDESKey;
            TDESAalgoritmo.Mode = CipherMode.ECB;
            TDESAalgoritmo.Padding = PaddingMode.PKCS7;
            byte[] DataToEncrypt = UTF8.GetBytes(texto);

            try
            {
                ICryptoTransform Encriptor = TDESAalgoritmo.CreateEncryptor();
                Results = Encriptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                TDESAalgoritmo.Clear();
                HashProvider.Clear();
            }
            return Convert.ToBase64String(Results);
        }

        public static string decodificar(string texto)
        {
            byte[] Results;
            UTF8Encoding UTF8 = new UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(chave));
            TripleDESCryptoServiceProvider TDESAalgoritmo = new TripleDESCryptoServiceProvider();
            TDESAalgoritmo.Key = TDESKey;
            TDESAalgoritmo.Mode = CipherMode.ECB;
            TDESAalgoritmo.Padding = PaddingMode.PKCS7;
            
            byte[] DataToDecrypt = Convert.FromBase64String(texto);

            try
            {
                ICryptoTransform Decriptor = TDESAalgoritmo.CreateDecryptor();
                Results = Decriptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                TDESAalgoritmo.Clear();
                HashProvider.Clear();
            }

            return UTF8.GetString(Results);
        }

    }
}

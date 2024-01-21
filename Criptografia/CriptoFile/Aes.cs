using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Criptografia.CriptoFile
{

    class Aes
    {
        #region // Criptografia

        /// <summary>
        /// Efetua a Criptografia dos dados
        /// </summary>
        /// <param name="password"></param>
        /// <param name="text"></param>
        /// <exception cref="ArgumentException"></exception>
        public byte[] CriptografarString(string Password, string Text)
        {
            if (Password.Length > 16) throw new ArgumentException("Senha de Criptografia invalida necessita ter 16 digitos maximo");

            Password = Password.PadLeft(16, '0');

            // Convert o texto em bytes alem de pegar um IV aleatorio
            byte[] password = Encoding.UTF8.GetBytes(Password);
            byte[] Iv = GetBytesRandom();


            using (AesManaged aes = new AesManaged())
            {
                aes.Key = password;
                aes.IV = Iv;

                ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);

                using(MemoryStream ms = new MemoryStream())
                {
                    using(CryptoStream cryptoStream = new CryptoStream(ms, crypto, CryptoStreamMode.Write))
                    {
                        using(StreamWriter sw = new StreamWriter(cryptoStream))
                        {
                            sw.Write(Text);
                        }
                    }

                    return Iv.Concat(ms.ToArray()).ToArray();
                }
            }

        }

        public byte[] CriptografarArquivos(string Password, byte[] dadosArquivo)
        {
            if (Password.Length > 16) throw new ArgumentException("Senha de Criptografia invalida necessita ter 16 digitos maximo");

            Password = Password.PadLeft(16, '0');
            byte[] password = Encoding.UTF8.GetBytes(Password);

            // Gerar um IV aleatório
            byte[] iv = GetBytesRandom();

            // Criar uma instância AES
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = password;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Criar streams para criptografia
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Escrever os dados criptografados no stream
                        cs.Write(dadosArquivo, 0, dadosArquivo.Length);
                    }

                    return iv.Concat(ms.ToArray()).ToArray();
                }
            }
        }

        /// <summary>
        /// Gera um Byte aleatorio para servir como IV
        /// </summary>
        /// <returns>um byte aleatorio</returns>
        private byte[] GetBytesRandom()
        {
            using(RNGCryptoServiceProvider rngCsp =  new RNGCryptoServiceProvider())
            {
                byte[] iv = new byte[16];
                rngCsp.GetBytes(iv);
                return iv;
            }
        }

        #endregion

        #region // Descriptografia

        public string DesCriptografarString(string Password, byte[] Dados)
        {
            if (Password.Length > 16) throw new ArgumentException("Senha de Criptografia invalida necessita ter 16 digitos maximo");

            Password = Password.PadLeft(16, '0');

            byte[] iv = new byte[16];
            Array.Copy(Dados, 0, iv, 0, 16);

            byte[] dados = new byte[Dados.Length - 16];
            Array.Copy(Dados, 16, dados, 0, Dados.Length - 16);
            

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(Password);
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream ms = new MemoryStream(dados))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
        }






        public byte[] DescriptografarArquivos(string Password, byte[] Dados)
        {
            if (Password.Length > 16) throw new ArgumentException("Senha de Criptografia invalida necessita ter 16 digitos no máximo");

            Password = Password.PadLeft(16, '0');

            byte[] iv = new byte[16];
            Array.Copy(Dados, 0, iv, 0, 16);

            byte[] dados = new byte[Dados.Length - 16];
            Array.Copy(Dados, 16, dados, 0, Dados.Length - 16);

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(Password);
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(dados, 0, dados.Length);
                    }

                    return ms.ToArray();
                }
            }
        }


        #endregion

    }
}

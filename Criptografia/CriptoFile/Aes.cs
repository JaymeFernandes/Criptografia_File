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
        public byte[] CriptografarString(string password, string text)
        {
            if (password.Length > 16) throw new ArgumentException("Senha de Criptografia invalida necessita ter 16 digitos maximo");

            password = password.PadLeft(16, '0');

            //Valor para gerar uma chave unica
            byte[] salt = GerarSalt();

            // Convert o texto em bytes alem de pegar um IV aleatorio
            byte[] Password = DerivarChavePBKDF2(password, salt, 10000, 256 / 8);
            byte[]  Iv = GetBytesRandom();


            using (AesManaged aes = new AesManaged())
            {
                aes.Key = Password;
                aes.IV = Iv;

                ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);

                using(MemoryStream ms = new MemoryStream())
                {
                    using(CryptoStream cryptoStream = new CryptoStream(ms, crypto, CryptoStreamMode.Write))
                    {
                        using(StreamWriter sw = new StreamWriter(cryptoStream))
                        {
                            sw.Write(text);
                        }
                    }

                    byte[] dadosCriptografadosComSaltIV = salt.Concat(Iv).Concat(ms.ToArray()).ToArray();

                    return dadosCriptografadosComSaltIV;
                }
            }

        }

        public byte[] CriptografarArquivos(string senha, byte[] salt, byte[] dadosArquivo)
        {
            // Derivar a chave usando PBKDF2
            byte[] chaveDerivada = DerivarChavePBKDF2(senha, salt, 10000, 256 / 8);

            // Gerar um IV aleatório
            byte[] iv = GetBytesRandom();

            // Criar uma instância AES
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = chaveDerivada;
                aesAlg.IV = iv;

                // Criar um transformador de criptografia
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Criar streams para criptografia
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Escrever os dados criptografados no stream
                        cs.Write(dadosArquivo, 0, dadosArquivo.Length);
                    }

                    // Concatenar o salt, IV e os dados criptografados
                    byte[] dadosCriptografadosComSaltIV = salt.Concat(iv).Concat(ms.ToArray()).ToArray();

                    return dadosCriptografadosComSaltIV;
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

        public string DesCriptografarString(string password, byte[] dadosCriptografadosComSaltIV)
        {
            if (password.Length > 16) throw new ArgumentException("Senha de Criptografia invalida necessita ter 16 digitos maximo");

            // Extrair o salt do início do array
            int tamanhoSalt = 16;
            byte[] salt = new byte[tamanhoSalt];
            Array.Copy(dadosCriptografadosComSaltIV, 0, salt, 0, tamanhoSalt);

            // Extrair o IV após o salt
            int tamanhoIV = 16;
            byte[] iv = new byte[tamanhoIV];
            Array.Copy(dadosCriptografadosComSaltIV, tamanhoSalt, iv, 0, tamanhoIV);

            // Derivar a chave usando PBKDF2
            byte[] chaveDerivada = DerivarChavePBKDF2(password, salt, 10000, 256 / 8);

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = chaveDerivada;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream ms = new MemoryStream(dadosCriptografadosComSaltIV, tamanhoSalt + tamanhoIV, dadosCriptografadosComSaltIV.Length - tamanhoSalt - tamanhoIV))
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






        public byte[] DescriptografarArquivos(string password, byte[] dadosCriptografadosComSaltIV)
        {
            if (password.Length > 16) throw new ArgumentException("Senha de Criptografia invalida necessita ter 16 digitos maximo");

            int tamanhoSalt = 16;
            byte[] salt = new byte[tamanhoSalt];
            Array.Copy(dadosCriptografadosComSaltIV, 0, salt, 0, tamanhoSalt);

            int tamanhoIV = 16;
            byte[] iv = new byte[tamanhoIV];
            Array.Copy(dadosCriptografadosComSaltIV, tamanhoSalt, iv, 0, tamanhoIV);

            byte[] chaveDerivada = DerivarChavePBKDF2(password, salt, 10000, 256 / 8);


            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = chaveDerivada;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(dadosCriptografadosComSaltIV, tamanhoSalt + tamanhoIV, dadosCriptografadosComSaltIV.Length - tamanhoSalt - tamanhoIV);
                    }

                    byte[] dadosDescriptografados = ms.ToArray();

                    return dadosDescriptografados;
                }
            }
        }

        #endregion

        #region // Melhoramento de Senha

        static byte[] DerivarChavePBKDF2(string senha, byte[] salt, int iteracoes, int tamanhoChave)
        {
            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(senha, salt, iteracoes))
            {
                return pbkdf2.GetBytes(tamanhoChave);
            }
        }

        static byte[] GerarSalt()
        {
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                rngCsp.GetBytes(salt);
                return salt;
            }
        }

        #endregion
    }
}

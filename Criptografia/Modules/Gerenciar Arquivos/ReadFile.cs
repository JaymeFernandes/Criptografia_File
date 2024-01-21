using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia.Modules.Gerenciar_Arquivos
{
    static class ReadFile
    {
        public static byte[] GetBytes(string PathFile)
        {
            if (!File.Exists(PathFile)) throw new FileNotFoundException("O arquivo passado não existe/Foi excluido!");

            using (FileStream fileStream = new FileStream(PathFile, FileMode.Open, FileAccess.Read))
            {
                using(BinaryReader reader = new BinaryReader(fileStream))
                {
                    byte[] dados = reader.ReadBytes((int)fileStream.Length);

                    if(dados == null || dados.Length != fileStream.Length) throw new IOException($"O arquivo {nameof(PathFile)} não possui informações registradas.");

                    return dados;
                }
            }
        }
    }
}

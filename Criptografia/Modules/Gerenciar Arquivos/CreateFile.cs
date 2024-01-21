using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia.Modules.Gerenciar_Arquivos
{
    static class CreateFile
    {
        public static void CopyFile(byte[] Dados,string PathFile, string Extension)
        {
            string direotory = Path.GetDirectoryName(PathFile);
            string name = Path.GetFileNameWithoutExtension(PathFile);

            string newPath = Path.Combine(direotory, $"{PathFile}.{Extension}");

            using(FileStream filesteam = new FileStream(newPath, FileMode.Create, FileAccess.Write))
            {
                using(BinaryWriter write = new BinaryWriter(filesteam))
                {
                    write.Write(Dados);
                }
            }
        }
    }
}

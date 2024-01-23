using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia.Modules.Gerenciar_Arquivos
{
    static class CreateFile
    {
        public static void CopyFile(byte[] Dados,string PathFile)
        {

            using(FileStream filesteam = new FileStream(PathFile, FileMode.Create, FileAccess.Write))
            {
                using(BinaryWriter write = new BinaryWriter(filesteam))
                {
                    write.Write(Dados);
                }
            }
        }
    }
}

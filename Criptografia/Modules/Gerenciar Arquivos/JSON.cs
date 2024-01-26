using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Criptografia.Modules.Gerenciar_Arquivos
{
    class JSON
    {

        public static List<T> ConvertObject<T>(string json)
        {
            List<T> historico = new List<T>();
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        public static string ConvertJson<T>(List<T> values)
        {
            return JsonConvert.SerializeObject(values, Formatting.Indented);
        }
    }
}

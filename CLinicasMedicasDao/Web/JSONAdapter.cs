using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClinicasMedicasDao.Web
{
    public class JSONAdapter<T>
    {
        public T FromString(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }

        public string ToString(T jsonObject)
        {
            return JsonSerializer.Serialize(jsonObject);
        }
    }
}

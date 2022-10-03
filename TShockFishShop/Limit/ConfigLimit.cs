using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FishShop
{
    // �޹�����
    public class ConfigLimit
    {
        public List<PlayerLimitData> player = new List<PlayerLimitData>();
        public List<ServerLimitData> server = new List<ServerLimitData>();

        public static ConfigLimit Load(string path)
        {
            if (File.Exists(path))
            {
                return JsonConvert.DeserializeObject<ConfigLimit>(File.ReadAllText(path), new JsonSerializerSettings()
                {
                    Error = (sender, error) => error.ErrorContext.Handled = true
                });
            }
            else
            {
                var c = new ConfigLimit();
                File.WriteAllText(path, JsonConvert.SerializeObject(c, Formatting.Indented, new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Ignore
                }));
                return c;
            }
        }
    }
}
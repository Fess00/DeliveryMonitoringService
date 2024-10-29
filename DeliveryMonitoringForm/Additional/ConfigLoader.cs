using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryMonitoringForm.Additional
{
    public class ConfigLoader
    {
        public ConfigData Config { get; init; }

        public ConfigLoader()
        {
            using (StreamReader r = new StreamReader(
                Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName + @"\config.json"))
            {
                string json = r.ReadToEnd();
                Config = JsonConvert.DeserializeObject<ConfigData>(json);
            }
        }
    }
}

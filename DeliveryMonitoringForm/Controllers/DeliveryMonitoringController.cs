using DeliveryMonitoringDataModel;
using DeliveryMonitoringForm.Additional;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DeliveryMonitoringForm.Controllers
{
    public class DeliveryMonitoringController
    {
        HttpClient _client;
        ConfigLoader _configLoader;

        public DeliveryMonitoringController()
        {
            _client = new HttpClient();
            _configLoader = new ConfigLoader();
        }

        public async Task GetLog()
        {
            string url = "http://localhost:5021/api/DeliverySreviceController/getlog";
            HttpResponseMessage response = await _client.GetAsync(url);
            string fileContent = await response.Content.ReadAsStringAsync();
            string filePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName 
                + $"\\{_configLoader.Config.logFile}";
            await File.WriteAllTextAsync(filePath, fileContent);
        }

        public async Task GetFilterData(string region, string firstDate)
        {
            string jsonString = File.ReadAllText(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName
                + $"\\{_configLoader.Config.orderDataFile}");
            var d = JsonConvert.DeserializeObject<List<Order>>(jsonString);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            string url = $"http://localhost:5021/api/DeliverySreviceController?cityDistrict={region}&firstDeliveryDateTime={firstDate}";
            HttpResponseMessage response = await _client.PostAsync(url, content);
            string fileContent = await response.Content.ReadAsStringAsync();
            string filePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName 
                + $"\\{_configLoader.Config.resultFile}";
            await File.WriteAllTextAsync(filePath, fileContent);
        }
    }
}

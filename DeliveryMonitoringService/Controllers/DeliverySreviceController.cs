using DeliveryMonitoringDataModel;
using DeliveryMonitoringService.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DeliveryMonitoringService.Controllers
{
    [Route("api/DeliverySreviceController")]
    [ApiController]
    public class DeliverySreviceController : ControllerBase
    {

        private ILogService _logService;
        public DeliverySreviceController(ILogService logService)
        {
            _logService = logService;
        }

        [HttpGet]
        public IEnumerable<Order> Get([FromQuery] string cityDistrict, [FromQuery] string firstDeliveryDateTime, [FromQuery] List<Order> orders)
        {
            District filterDistrict = (District)Enum.Parse(typeof(District), cityDistrict);
            DeliveryDateTime filterDate = new();
            filterDate.SetDate(firstDeliveryDateTime);
            orders.Where(x => x.District == filterDistrict).Where(x => x.Date.DT >= filterDate.DT && x.Date.DT <= x.Date.DT.AddMinutes(30)).ToList();

            _logService.Log($"Фильтрация данных. Район: {cityDistrict} Дата и время: {firstDeliveryDateTime}");
            return orders;
        }

        [HttpGet("getlog")]
        public IActionResult DownloadTextFile()
        {
            _logService.Log("Возвращение логов клиенту.");
            using StreamReader reader = new StreamReader(
                Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName + "Log.txt");

            var content = reader.ReadToEnd();

            var byteArray = Encoding.UTF8.GetBytes(content);

            var fileName = "Log.txt";

            return File(byteArray, "text/plain", fileName);
        }
    }
}

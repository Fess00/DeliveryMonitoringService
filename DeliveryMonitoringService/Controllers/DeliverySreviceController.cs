using DeliveryMonitoringDataModel;
using DeliveryMonitoringService.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
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

        [HttpPost]
        public IActionResult Get([FromBody] List<Order> orders, [FromQuery] string cityDistrict, [FromQuery] string firstDeliveryDateTime)
        {
            District filterDistrict = (District)Enum.Parse(typeof(District), cityDistrict);
            var filtered = orders.Where(x => x.District == filterDistrict)
                .Where(x =>
                {
                    if (DateTime.TryParseExact(x.Date, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out var date)
                    && DateTime.TryParseExact(firstDeliveryDateTime, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out var filter))
                    {
                        return date >= filter && date <= date.AddMinutes(30);
                    }
                    return false;
                });
                

            _logService.Log($"Фильтрация данных. Район: {cityDistrict} Дата и время: {firstDeliveryDateTime}");
            return Ok(filtered);
        }

        [HttpGet("getlog")]
        public IActionResult Log()
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

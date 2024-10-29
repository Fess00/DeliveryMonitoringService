using System.IO;

namespace DeliveryMonitoringService.Services
{
    public class LogService : ILogService
    {
        public string _path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName + "Log.txt";
        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(_path, true))
            {
                writer.WriteLine("[" + DateTime.Now.ToString() + "] " + message);
            }
        }
    }
}

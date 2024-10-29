namespace DeliveryMonitoringDataModel
{
    public class Order
    {
        public Guid Id { get; set; }

        public double Weight { get; set; }

        public District District { get; set; }

        public string Date { get; set; }
    }
}

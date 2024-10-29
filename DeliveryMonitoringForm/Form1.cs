using DeliveryMonitoringDataModel;
using DeliveryMonitoringForm.Additional;
using Newtonsoft.Json;
using System.Runtime.InteropServices.Marshalling;

namespace DeliveryMonitoringForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _client = new();
            _configLoader = new();
            SetSelectors();
            regionSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            daySelector.DropDownStyle = ComboBoxStyle.DropDownList;
            monthSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            yearSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            hourSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            minuteSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            secondSelector.DropDownStyle = ComboBoxStyle.DropDownList;
    }

        public void SetSelectors()
        {
            foreach (var district in (District[])Enum.GetValues(typeof(District)))
            {
                regionSelector.Items.Add(district.ToString());
            }

            for (int i = 1; i < 32; i++)
            {
                daySelector.Items.Add(i.ToString());
            }

            for (int i = 1; i < 13; i++)
            {
                monthSelector.Items.Add(i.ToString());
            }

            for (int i = 1900; i < 2024; i++)
            {
                yearSelector.Items.Add(i.ToString());
            }

            for (int i = 0; i < 24; i++)
            {
                hourSelector.Items.Add(i.ToString());
            }

            for (int i = 0; i < 60; i++)
            {
                minuteSelector.Items.Add(i.ToString());
            }

            for (int i = 0; i < 60; i++)
            {
                secondSelector.Items.Add(i.ToString());
            }
        }

        private async void filterButton_Click(object sender, EventArgs e)
        {
            if (!isValidFilterData())
            {
                MessageBox.Show("Заполните данные для фильтрации полностью", "Заданы некорректные данные для фильтрации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var year = yearSelector.Text.Length < 2 ? "0" + yearSelector.Text : yearSelector.Text;
            var month = monthSelector.Text.Length < 2 ? "0" + monthSelector.Text : monthSelector.Text;
            var day = daySelector.Text.Length < 2 ? "0" + daySelector.Text : daySelector.Text;
            var hour = hourSelector.Text.Length < 2 ? "0" + hourSelector.Text : hourSelector.Text;
            var minute = minuteSelector.Text.Length < 2 ? "0" + minuteSelector.Text : minuteSelector.Text;
            var second = secondSelector.Text.Length < 2 ? "0" + secondSelector.Text : secondSelector.Text;

            await _client.GetFilterData(regionSelector.Text, $"{year}-{month}-{day} {hour}:{minute}:{second}");
        }

        public bool isValidFilterData()
        {
            return daySelector.Text.Length != 0 &&
                monthSelector.Text.Length != 0 &&
                yearSelector.Text.Length != 0 &&
                hourSelector.Text.Length != 0 &&
                minuteSelector.Text.Length != 0 &&
                secondSelector.Text.Length != 0 &&
                regionSelector.Text.Length != 0;
        }

        private async void logButton_Click(object sender, EventArgs e)
        {
            await _client.GetLog();
        }
    }
}

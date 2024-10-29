using DeliveryMonitoringForm.Additional;
using DeliveryMonitoringForm.Controllers;

namespace DeliveryMonitoringForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            regionSelector = new ComboBox();
            orderBindingSource = new BindingSource(components);
            regionLabel = new Label();
            day = new Label();
            month = new Label();
            year = new Label();
            hour = new Label();
            minute = new Label();
            second = new Label();
            daySelector = new ComboBox();
            monthSelector = new ComboBox();
            yearSelector = new ComboBox();
            hourSelector = new ComboBox();
            minuteSelector = new ComboBox();
            secondSelector = new ComboBox();
            filterButton = new Button();
            logButton = new Button();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // regionSelector
            // 
            regionSelector.FormattingEnabled = true;
            regionSelector.Location = new Point(74, 12);
            regionSelector.Name = "regionSelector";
            regionSelector.Size = new Size(160, 28);
            regionSelector.TabIndex = 0;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(DeliveryMonitoringDataModel.Order);
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new Point(16, 16);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new Size(52, 20);
            regionLabel.TabIndex = 2;
            regionLabel.Text = "Район";
            // 
            // day
            // 
            day.AutoSize = true;
            day.Location = new Point(240, 15);
            day.Name = "day";
            day.Size = new Size(44, 20);
            day.TabIndex = 3;
            day.Text = "День";
            // 
            // month
            // 
            month.AutoSize = true;
            month.Location = new Point(335, 15);
            month.Name = "month";
            month.Size = new Size(54, 20);
            month.TabIndex = 4;
            month.Text = "Месяц";
            // 
            // year
            // 
            year.AutoSize = true;
            year.Location = new Point(441, 16);
            year.Name = "year";
            year.Size = new Size(33, 20);
            year.TabIndex = 5;
            year.Text = "Год";
            // 
            // hour
            // 
            hour.AutoSize = true;
            hour.Location = new Point(554, 16);
            hour.Name = "hour";
            hour.Size = new Size(34, 20);
            hour.TabIndex = 6;
            hour.Text = "Час";
            // 
            // minute
            // 
            minute.AutoSize = true;
            minute.Location = new Point(640, 16);
            minute.Name = "minute";
            minute.Size = new Size(43, 20);
            minute.TabIndex = 7;
            minute.Text = "Мин.";
            // 
            // second
            // 
            second.AutoSize = true;
            second.Location = new Point(736, 16);
            second.Name = "second";
            second.Size = new Size(36, 20);
            second.TabIndex = 8;
            second.Text = "Сек.";
            // 
            // daySelector
            // 
            daySelector.FormattingEnabled = true;
            daySelector.Location = new Point(284, 13);
            daySelector.Name = "daySelector";
            daySelector.Size = new Size(46, 28);
            daySelector.TabIndex = 9;
            // 
            // monthSelector
            // 
            monthSelector.FormattingEnabled = true;
            monthSelector.Location = new Point(390, 12);
            monthSelector.Name = "monthSelector";
            monthSelector.Size = new Size(46, 28);
            monthSelector.TabIndex = 10;
            // 
            // yearSelector
            // 
            yearSelector.FormattingEnabled = true;
            yearSelector.Location = new Point(478, 12);
            yearSelector.Name = "yearSelector";
            yearSelector.Size = new Size(70, 28);
            yearSelector.TabIndex = 11;
            // 
            // hourSelector
            // 
            hourSelector.FormattingEnabled = true;
            hourSelector.Location = new Point(589, 12);
            hourSelector.Name = "hourSelector";
            hourSelector.Size = new Size(46, 28);
            hourSelector.TabIndex = 12;
            // 
            // minuteSelector
            // 
            minuteSelector.FormattingEnabled = true;
            minuteSelector.Location = new Point(684, 12);
            minuteSelector.Name = "minuteSelector";
            minuteSelector.Size = new Size(46, 28);
            minuteSelector.TabIndex = 13;
            // 
            // secondSelector
            // 
            secondSelector.FormattingEnabled = true;
            secondSelector.Location = new Point(775, 12);
            secondSelector.Name = "secondSelector";
            secondSelector.Size = new Size(46, 28);
            secondSelector.TabIndex = 14;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(16, 61);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(218, 29);
            filterButton.TabIndex = 15;
            filterButton.Text = "Фильтровать данные";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // logButton
            // 
            logButton.Location = new Point(16, 107);
            logButton.Name = "logButton";
            logButton.Size = new Size(218, 29);
            logButton.TabIndex = 16;
            logButton.Text = "Получить логи";
            logButton.UseVisualStyleBackColor = true;
            logButton.Click += logButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 162);
            Controls.Add(logButton);
            Controls.Add(filterButton);
            Controls.Add(secondSelector);
            Controls.Add(minuteSelector);
            Controls.Add(hourSelector);
            Controls.Add(yearSelector);
            Controls.Add(monthSelector);
            Controls.Add(daySelector);
            Controls.Add(second);
            Controls.Add(minute);
            Controls.Add(hour);
            Controls.Add(year);
            Controls.Add(month);
            Controls.Add(day);
            Controls.Add(regionLabel);
            Controls.Add(regionSelector);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        DeliveryMonitoringController _client;
        ConfigLoader _configLoader;

        private ComboBox regionSelector;
        private Label regionLabel;
        private Label day;
        private Label month;
        private Label year;
        private BindingSource orderBindingSource;
        private Label hour;
        private Label minute;
        private Label second;
        private ComboBox daySelector;
        private ComboBox monthSelector;
        private ComboBox yearSelector;
        private ComboBox hourSelector;
        private ComboBox minuteSelector;
        private ComboBox secondSelector;
        private Button filterButton;
        private Button logButton;
    }
}

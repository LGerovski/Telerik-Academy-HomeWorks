using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileDevice
{
    public class GSM
    {
        private string model = null;
        private string manufacturer = null;
        private decimal? price = null;
        private string owner = null;
        private Battery battery = null;
        private Display display = null;
        private static int iPhone4S = 0;
        private List<Call> callHistory = new List<Call>();

        public static int IPhone4S
        {
            get
            {
                return GSM.iPhone4S;
            }
            private set
            {
                GSM.iPhone4S = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
                if (this.model == "IPhone4S")
                {
                    GSM.IPhone4S++;
                }
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (Validator.ValidatePrice(price))
            {
                this.price = value;
            }
                else
                {
                    throw new IndexOutOfRangeException("The price can not be negative!");
                }
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        private List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }
        public GSM(string model, string manufacturer) 
            : this(model, manufacturer, null) { }
        public GSM(string model, string manufacturer, decimal? price) 
            : this (model, manufacturer, price, null) { }
        public GSM(string model, string manufacturer, decimal? price, string owner) 
            : this (model, manufacturer, price, owner, null) { }
        public GSM(string model, string manufacturer, decimal? price, string owner, string batteryModel)
            : this(model, manufacturer, price, owner, batteryModel, null) { }
        public GSM(string model, string manufacturer, decimal? price, string owner, string batteryModel, double? batteryIdleTime)
            : this(model, manufacturer, price, owner, batteryModel, batteryIdleTime, null) { }
        public GSM(string model, string manufacturer, decimal? price, string owner, string batteryModel, double? batteryIdleTime, 
            double? batteryTalkTime)
            : this(model, manufacturer, price, owner, batteryModel, batteryIdleTime, batteryTalkTime, null) { }
        public GSM(string model, string manufacturer, decimal? price, string owner, string batteryModel, double? batteryIdleTime,
           double? batteryTalkTime, double? displaySize)
            : this(model, manufacturer, price, owner, batteryModel, batteryIdleTime, batteryTalkTime, displaySize, null) { }
        public GSM(string model, string manufacturer, decimal? price, string owner, string batteryModel, double? batteryIdleTime,
           double? batteryTalkTime, double? displaySize, uint? displayColors)
            : this(model, manufacturer, price, owner, batteryModel, batteryIdleTime, batteryTalkTime, displaySize, displayColors, (BatteryType)1) { }
        public GSM(string model, string manufacturer, decimal? price, string owner, string batteryModel, double? batteryIdleTime, 
            double? batteryTalkTime, double? displaySize, uint? displayColors, BatteryType batteryType)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = new Battery(batteryModel, batteryIdleTime, batteryTalkTime, batteryType);
            this.display = new Display(displaySize, displayColors);
        }
        public override string ToString()
        {
            StringBuilder GSMString = new StringBuilder();
            GSMString.Append(string.Format("Model       :  {0, 10}", this.Model)).AppendLine();
            GSMString.Append(string.Format("Manufacturer:  {0, 10}", this.Manufacturer)).AppendLine();
            if (this.Price != null)
            {
                GSMString.Append(string.Format("Price:  {0, 10}", this.Price)).AppendLine();
            }
            if (this.Owner != null)
            {
                GSMString.Append(string.Format("Owner:  {0, 10}", this.Owner)).AppendLine();
            }
            if (this.battery.Model != null)
            {
                GSMString.Append(string.Format("Battery Model:  {0, 10}", this.battery.Model)).AppendLine();
            }
            if (this.battery.IdleTime != null)
            {
                GSMString.Append(string.Format("Battery Idle Time:  {0, 10}", this.battery.IdleTime)).AppendLine();
            }
            if (this.battery.TalkTime != null)
            {
                GSMString.Append(string.Format("Battery Talk Time:  {0, 10}", this.battery.TalkTime)).AppendLine();
            }
            if (this.battery.BatteryType != null)
            {
                GSMString.Append(string.Format("Battery Type:  {0, 10}", this.battery.BatteryType)).AppendLine();
            }
            if (this.display.Size != null)
            {
                GSMString.Append(string.Format("Display Size:  {0, 10}", this.display.Size)).AppendLine();
            }
            if (this.display.Colors != null)
            {
                GSMString.Append(string.Format("Display Colors:  {0, 10}", this.display.Colors)).AppendLine();
            }
            return GSMString.ToString();
        }
        public void AddCall(string number, int duration)
        {
            Call newCall = new Call(number, duration);
            this.callHistory.Add(newCall);
        }
        public void RemoveCall()
        {
            int longestDuration = 0;
            foreach (var item in this.callHistory)
            {
                if (item.Duration > longestDuration)
                {
                    longestDuration = item.Duration;
                }
            }
            this.callHistory.Remove(this.callHistory.First(x => x.Duration == longestDuration));
        }
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }
        public decimal GetCallsPrice(decimal pricePerMinute)
        {
            decimal callPrice = 0.0m;
            foreach (var item in this.callHistory)
            {
                callPrice += item.Duration * pricePerMinute;
            }
            return callPrice;
        }
        public void DisplayCallInformation()
        {
            if (this.callHistory.Count > 0)
            {
                foreach (var item in this.callHistory)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Current calls history is empty.\n");
            }
        }
    }
}

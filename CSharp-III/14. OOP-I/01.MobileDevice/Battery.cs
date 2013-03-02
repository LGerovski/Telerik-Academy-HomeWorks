namespace MobileDevice
{
    class Battery
    {
        private string model = null;
        private double? idleTime = null;
        private double? talkTime = null;
        private BatteryType? batteryType = null;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public double? IdleTime
        {
            get
            {
                return this.idleTime;
            }
            set
            {
                this.idleTime = value;
            }
        }
        public double? TalkTime
        {
            get
            {
                return this.talkTime;
            }
            set
            {
                this.talkTime = value;
            }
        }
        public BatteryType? BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
        public Battery(string model, double? idleTime, double? talkTime, BatteryType batteryType = (BatteryType)1)
        {
            this.Model = model;
            this.IdleTime = idleTime;
            this.TalkTime = talkTime;
            this.BatteryType = batteryType;
        }
    }
}

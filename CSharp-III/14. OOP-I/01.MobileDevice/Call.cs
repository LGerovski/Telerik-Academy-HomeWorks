using System;
using System.Text;

namespace MobileDevice
{
    class Call
    {
        private DateTime date;
        private DateTime time;
        private string phoneNumber;
        private int duration;

        public Call(string phoneNumber, int duration)
        {
            this.date = DateTime.Now;
            this.date = DateTime.Now;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }
        public Call(DateTime date, DateTime time, string phoneNumber, int duration) 
            : this (phoneNumber, duration)
        {
            this.date = date;
            this.time = time;
        }
        public DateTime Date
        {
            get
            {
                return this.date;
            }
        }
        public DateTime Time
        {
            get
            {
                return this.time;
            }
        }
        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                if (Validator.ValidateDuration(value))
                {
                    this.duration = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        private string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (Validator.ValidatePhoneNumber(value))
                {
                    this.phoneNumber = value;
                }
                else
	            {
                    throw new IndexOutOfRangeException();
	            }
            }
        }

        public override string ToString()
        {
            StringBuilder GSMString = new StringBuilder();
            GSMString.Append(string.Format("Date of call              :  {0, 10}", this.Date.ToString("dd.MM.yyyy"))).AppendLine();
            GSMString.Append(string.Format("Time of call              :  {0, 10}", this.Date.ToString("hh:mm tt"))).AppendLine();
            GSMString.Append(string.Format("Phone Number called       :  {0, 10}", this.PhoneNumber)).AppendLine();
            GSMString.Append(string.Format("Call Duration in seconds  :  {0, 10}", this.Duration)).AppendLine();
            return GSMString.ToString();
        }
    }
}

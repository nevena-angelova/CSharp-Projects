using System;

namespace MobileDevice
{
    // (ex. 8)

    public class Call
    {
        private DateTime dateAndTime;
        private string phoneNumber;
        private int duration; // minutes

        public Call(DateTime dateAndTime, string phoneNumber, int duration)
        {
            this.dateAndTime = dateAndTime;
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }

        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                if (String.IsNullOrEmpty(phoneNumber))
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.phoneNumber = value;
                }
            }
        }

        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.duration = value;
                }
            }
        }

    }
}

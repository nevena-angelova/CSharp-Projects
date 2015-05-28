using System;
using System.Text;

namespace MobileDevice
{
    public class Battery
    {
        // fields (ex. 1)

        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        // constructors (ex. 2)

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        public Battery(string model) // mandatory field
        {
            this.model = model;
            this.hoursIdle = 0;
            this.hoursTalk = 0;
            this.batteryType = BatteryType.LiIon;
        }

        // properties (ex. 5)


        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid battery model!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (hoursIdle < 0)
                {
                    throw new ArgumentException("Invalid hours idle!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (hoursTalk < 0)
                {
                    throw new ArgumentException("Invalid hours talk!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        // display method (ex. 4)

        public string BatteryInformation()
        {
            StringBuilder batteryInfo = new StringBuilder();
            batteryInfo.AppendLine("Battery model: " + this.model);
            batteryInfo.AppendLine("Battery hours idle: " + this.hoursIdle);
            batteryInfo.AppendLine("Battery hours talk: " + this.hoursTalk);
            batteryInfo.AppendLine("Battery Type: " + this.batteryType);

            return batteryInfo.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace MobileDevice
{
    public class GSM
    {
        // fields (ex. 1)

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

        // static field (ex. 6)

        private static GSM iPhone4S = new GSM("S-320", "iPhone", 980.50m, "Stella Grigorova", new Battery("KL330"), new Display("480x520", 320));

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        // (ex. 9)

        private List<Call> callHistory;

        //constructors (ex. 2)

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, Battery battery) // mandatory fields
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = 0;
            this.owner = null;
            this.battery = battery;
            this.display = new Display();
            this.callHistory = new List<Call>();
        }

        // properties (ex. 5)

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid model!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid manufacturer!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid owner!");
                }
                else
                {
                    this.owner = value;
                }
            }
        }


        // (ex. 9)

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        public void AddCalls(Call newCall)
        {
            this.callHistory.Add(newCall);
        }

        public void RemoveCalls(Call removedCall)
        {
            this.callHistory.Remove(removedCall);
        }

        // calculate total price (ex. 11)

        public decimal CalcTotalPrice(int pricePerMinute) // in stotinki
        {
            decimal totalPrice = 0;

            foreach (Call item in CallHistory)
            {
                totalPrice += item.Duration * pricePerMinute;
            }

            return totalPrice / 100; // in leva
        }

        // override ToString (ex. 4)

        public override string ToString()
        {
            StringBuilder phoneInfo = new StringBuilder();
            phoneInfo.AppendLine("Phone model: " + this.model);
            phoneInfo.AppendLine("Phone manufacturer: " + this.manufacturer);
            phoneInfo.AppendLine("Phone price: " + this.price);
            phoneInfo.AppendLine("Phone owner: " + this.owner);
            phoneInfo.Append("Phone battery: \n" + this.battery.BatteryInformation());
            phoneInfo.Append("Phone display: \n" + this.display.DisplayInformation());

            return phoneInfo.ToString();

        }


    }


}

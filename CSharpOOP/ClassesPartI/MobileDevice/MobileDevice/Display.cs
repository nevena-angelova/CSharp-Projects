using System;
using System.Text;

namespace MobileDevice
{
    public class Display
    {
        // fields (ex. 1)

        private string size;
        private int colors;

        // constructors (ex. 2)

        public Display()
        {
            this.size = null;
            this.colors = 0;
        }

        public Display(string size, int colors)
        {
            this.size = size;
            this.colors = colors;
        }

        // properties (ex. 5)

        public string Size
        {
            get { return this.size; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid size!");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int Colors
        {
            get { return this.colors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid colors!");
                }
                else
                {
                    this.colors = value;
                }
            }
        }

        // display method (ex. 4)

        public string DisplayInformation()
        {
            StringBuilder displayInfo = new StringBuilder();
            displayInfo.AppendLine("Display size: " + size);
            displayInfo.AppendLine("Colors size: " + colors);

            return displayInfo.ToString();
        }
    }
}

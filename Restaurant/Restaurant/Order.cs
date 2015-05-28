using System;
using System.IO;

namespace Restaurant
{
    public class Order : IOrder
    {
        private int amount;
        private int code;
        private string type;
        private double price;
        private bool isFood;
        private bool loadFromMenu; // true if the entered code is less than the menu items
        private const string file = "menu.txt";

        public Order(int code, int amount)
        {
            this.amount = amount;
            this.code = code;
            SetFromMenu(); // adds values to "price", "type", "isFood" and "loadFromMenu"
        }

        public int Amount
        {
            get { return this.amount; }
        }

        public string Type
        {
            get { return this.type; }
        }

        public double Price
        {
            get { return this.price; }
        }

        public bool IsFood
        {
            get { return this.isFood; }
        }

        public bool LoadFromMenu
        {
            get { return this.loadFromMenu; }
        }

        // reads from menu.txt and sets "type" and "price"

        private void SetFromMenu()
        {
            StreamReader reader = new StreamReader(file);

            using (reader)
            {
                code *= 3;
                string line = reader.ReadLine();
                int lineCount = 0;
                double tempPrice = 0;
                bool tempIsFood = true;
                string tempType = String.Empty;

                // goes to the "code"-th threesome (type, price, isFood) from the text file and takes its items
                // if the code is bigger than the menu items throws and catches an exception - loadFromMenu = false

                while (code != 0)
                {
                    try
                    {
                        if (code == 3)
                        {
                            tempType = line;
                        }
                        if (code == 2)
                        {
                            tempPrice = double.Parse(line);
                        }
                        if (code == 1)
                        {
                            tempIsFood = bool.Parse(line);
                        }

                        line = reader.ReadLine();
                        code--;

                        if (line == null)
                        {
                            throw new InvalidCodeException(lineCount/3, "Invalid code!");
                        }

                        lineCount++;
                    }
                    catch (InvalidCodeException ex)
                    {
                        Console.WriteLine(ex.Msg);
                        Console.WriteLine("The code must be from 0 to {0}", ex.LineCount);
                        this.loadFromMenu = false;
                        return;
                    }
                }

                this.isFood = tempIsFood; // "code"-th menu threesome, "i"-th item
                this.type = tempType; // "code"-th menu threesome, "i"-th item
                this.price = tempPrice; // "code"-th menu threesome, "i"-th item
                this.loadFromMenu = true;
            }
        }

    }
}

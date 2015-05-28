using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Waiter : Worker
    {
        private List<Table> tables;

        public Waiter(string name)
            : base(name)
        {
            this.tables = new List<Table>();
        }

        public void AddTable(Table table)
        {
            this.tables.Add(table);
        }

        public List<Table> Tables
        {
            get { return this.tables; }
        }

        // closing an account

        public void CloseTable(int number)
        {
            foreach (Table table in tables)
            {
                if (table.TableNumber == number)
                {
                    table.IsCurrent = false;
                }
            }
        }


        // prints current bill

        public void PrintBill(int number)
        {
            foreach (Table table in tables)
            {
                if (table.TableNumber == number)
                {
                    Console.WriteLine("Waiter: {0}", this.Name);
                    Console.WriteLine("===============================================");
                    Console.WriteLine(" Table | Order                | Amount | Price   ");
                    Console.WriteLine("===============================================");

                    foreach (Order order in table.Orders)
                    {
                        Console.WriteLine("{0,-8}{1,-20}{2,-10}{3,-12}", table.TableNumber, order.Type, order.Amount, order.Price);
                    }

                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Total bill: {0}", table.CalculateBill());
                    Console.WriteLine("===============================================");

                }
            }
        }

        public void CalculateTotal()
        {
            double profit = 0;

            Console.WriteLine("Waiter: {0}", this.Name);
            Console.WriteLine("===============================================");
            Console.WriteLine(" Table | Order                | Amount | Price   ");
            Console.WriteLine("===============================================");

            foreach (Table table in this.tables)
            {
                {
                    foreach (Order order in table.Orders)
                    {
                        Console.WriteLine("{0,-8}{1,-23}{2,-9}{3,-17}", table.TableNumber, order.Type, order.Amount, order.Price);
                    }

                    profit += table.CalculateBill();

                }
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Total: {0}", profit);
            Console.WriteLine("===============================================");
        }

        public void CalculatePercent(int number, double percent)
        {
            double calcPercent = 0;

            foreach (Table table in this.tables)
            {
                calcPercent += (this.tables[number].CalculateBill() * percent) / 100;
            }

            Console.WriteLine("The percent for {0} is {1}", this.Name, calcPercent);

       }

    }
}

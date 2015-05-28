using System;
using System.Text;
using System.Collections.Generic;

namespace Restaurant
{
    public class NewDay
    {
        private List<Worker> workers;
        private List<Waiter> waiters;

        public NewDay()
        {
            this.workers = new List<Worker>();
            this.waiters = new List<Waiter>();
        }

        public List<Waiter> Waiters
        {
            get { return this.waiters; }
        }

        // if the worker is waiter adds it also to the waiters list

        public void AddWorker(Worker worker)
        {
            this.workers.Add(worker);

            if (worker is Waiter)
            {
                this.waiters.Add(worker as Waiter);
            }

        }

        // gets a waiter from the list

        public Waiter GetWaiter(int number)
        {
            return this.waiters[number];
        }

        // prints the kitchen and bar profits. Also prints the kitchen an bar profit for every waiter

        public void CalculateKitchenAndBarProfit()
        {
            double kitchenPft = 0;
            double barPft = 0;
            double waiterKitchenPft = 0;
            double waiterBarPft = 0;
            StringBuilder kitchenStr = new StringBuilder();
            StringBuilder barStr = new StringBuilder();

            foreach (Waiter waiter in waiters)
            {
                waiterKitchenPft = 0;
                waiterBarPft = 0;
                kitchenStr = new StringBuilder();
                barStr = new StringBuilder();
                Console.WriteLine("Waiter: {0}", waiter.Name);
                Console.WriteLine();

                if (waiter.Tables.Count > 0)
                {
                    foreach (Table table in waiter.Tables)
                    {
                        foreach (Order order in table.Orders)
                        {
                            if (order.IsFood)
                            {
                                waiterKitchenPft += order.Price * order.Amount;
                                kitchenPft += waiterKitchenPft;
                                kitchenStr.Append("Table: " + table.TableNumber + ", Order: " + order.Type + ", Price: " + order.Price + ", Amount: " + order.Amount + "\n");
                            }
                            else if (!order.IsFood)
                            {
                                waiterBarPft += order.Price * order.Amount;
                                barPft += waiterBarPft;
                                barStr.Append("Table: " + table.TableNumber + ", Order: " + order.Type + ", Price: " + order.Price + ", Amount: " + order.Amount + "\n");
                            }
                        }
                    }

                    if (waiterKitchenPft > 0)
                    {
                        Console.WriteLine("Kitchen orders: ");
                        Console.WriteLine();
                        Console.WriteLine(kitchenStr.ToString());
                        Console.WriteLine("The waiter kitchen profit is: {0}", waiterKitchenPft);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No kitchen orders.");
                        Console.WriteLine();
                    }

                    if (waiterBarPft > 0)
                    {
                        Console.WriteLine("Bar orders: ");
                        Console.WriteLine();
                        Console.WriteLine(barStr.ToString());
                        Console.WriteLine("The waiter bar profit is: {0}", waiterBarPft);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No bar orders.");
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.Write("Tables: none");
                    Console.WriteLine();
                }

                Console.WriteLine(new String('-', 34));
            }

            Console.WriteLine(new String('=', 34));
            Console.WriteLine("Total kitchen profit is: {0}", kitchenPft);
            Console.WriteLine("Total bar profit is: {0}", barPft);

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Table
    {
        private int tableNumber;
        private List<Order> orders;
        private bool isCurrent = false; // to activate or disactivate a table

        public Table(int tableNumber)
        {
            this.tableNumber = tableNumber;
            this.orders = new List<Order>();
            this.isCurrent = true; // occupied table when initializing
        }

        public int TableNumber
        {
            get { return this.tableNumber; }
        }

        public List<Order> Orders
        {
            get { return this.orders; }
        }

        public bool IsCurrent
        {
            get { return this.isCurrent; }
            set { this.isCurrent = value; }
        }

        public void AddOrder(Order order)
        {
            this.orders.Add(order);
        }

        public double CalculateBill()
        {
            double sum = 0;

            foreach (Order order in orders)
            {
                sum += order.Price * order.Amount;
            }

            return sum;
        }

    }
}

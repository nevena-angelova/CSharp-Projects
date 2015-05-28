using System;

// Меню - Кодове

// 1.Шопска салата
// 2.Градинарска салата
// 3.Крем супа
// 4.Задушени зеленчуци
// 5.Пържени картофи
// 6.Млечно пиле
// 7.Крем карамел
// 8.Плодова салата
// 9.Минерална вода
// 10.Кафе
// 11.Натурален сок
// 12.Кола
// 13.Водка
// 14.Вино
// 15.Ракия
// 16.Бира

namespace Restaurant
{
    class Program
    {
        static void PrintOptions()
        {
            Console.WriteLine("Press \"P\" to adding more workers");
            Console.WriteLine("Press \"1\" for new table or adding another order to a table");
            Console.WriteLine("Press \"2\" for printing one table bill");
            Console.WriteLine("Press \"3\" for printing all bills");
            Console.WriteLine("Press \"4\" for closing an account");
            Console.WriteLine("Press \"5\" for calculating a waiter percent");
            Console.WriteLine("Press \"6\" for calculating the kitchen and bar profit");
            Console.WriteLine("Press \"Esc\" for escape");
        }

        static void Main()
        {
            // *** Console interface for adding orders - Demonstration ***

            NewDay newDay = new NewDay();
            string wtrName;
            Waiter waiter;
            int wtrNumber;
            int allTables = 15; // all the tables in the newDay
            int tableNum = 0;
            Table table = new Table(tableNum); //this table will never be added to the list it will be replaced later
            int menuItemCode;
            int amount;
            ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();

            Console.WriteLine("Press \"Enter\" to open a day.");
            keyinfo = Console.ReadKey();
            Console.WriteLine("Press \"P\" to adding waiters.");
            keyinfo = Console.ReadKey();

            while (true)
            {
                // "P" - enters a new waiter and adds it to the waiters list

                if (keyinfo.Key == ConsoleKey.P)
                {
                    Console.Clear();

                    Console.WriteLine("Enter a waiter name:");
                    wtrName = Console.ReadLine();

                    waiter = new Waiter(wtrName);
                    newDay.AddWorker(waiter);

                    Console.WriteLine("Press \"P\" to adding more waiters.");
                    Console.WriteLine("Press \"1\" for adding table with orders");

                    // check wether there are any waiters and tables, if so prints the other options

                    if (newDay.Waiters.Count > 0 && newDay.GetWaiter(0).Tables.Count > 0)
                    {
                        Console.WriteLine("Press \"2\" for printing one table bill");
                        Console.WriteLine("Press \"3\" for printing all bills");
                        Console.WriteLine("Press \"4\" for closing an account");
                        Console.WriteLine("Press \"5\" for calculating a waiter percent");
                        Console.WriteLine("Press \"6\" for calculating the kitchen and bar profit");
                    }

                    Console.WriteLine("Press \"Esc\" for escape");

                    keyinfo = Console.ReadKey();
                }

                // "D" - adds orders to tables

                if (keyinfo.Key == ConsoleKey.D1)
                {
                    Console.Clear();

                    Console.WriteLine("Enter waiter number (the position in the waiters list):");

                    for (int i = 0; i < newDay.Waiters.Count; i++)
                    {
                        Console.WriteLine("{0} - {1}", newDay.Waiters[i].Name, i);
                    }

                    wtrNumber = int.Parse(Console.ReadLine());

                    waiter = newDay.GetWaiter(wtrNumber);

                    Console.Clear();

                    // prints all the tables and wether they are occupied, if so the waiter's code is printed relevent to the table

                    Console.Write(new String('-', (allTables - 1) * 5));
                    Console.WriteLine();
                    Console.Write("Tables |");

                    for (int i = 0; i < allTables; i++)
                    {
                        Console.Write("{0,3}|", i);
                    }
                    Console.WriteLine();
                    Console.Write(new String('-', (allTables - 1) * 5));
                    Console.WriteLine();
                    Console.Write("Free   |");

                    bool isOccupied = false;

                    // searches for the "i"-th table and if it is occupied no matter where it is, changes isOccupied to true

                    for (int i = 0; i < allTables; i++)
                    {
                        int wtrIndex = 0;

                        for (int j = 0; j < newDay.Waiters.Count; j++)
                        {
                            foreach (Table tbl in newDay.Waiters[j].Tables)
                            {
                                if (tbl.IsCurrent && tbl.TableNumber == i)
                                {
                                    isOccupied = true;
                                    wtrIndex = j;
                                    break;
                                }
                            }
                        }

                        // prints the waiter's index if isOccupied otherwise a blank space

                        if (isOccupied)
                        {
                            Console.Write("{0,3}|", wtrIndex);
                            isOccupied = false;
                        }
                        else
                        {
                            Console.Write("   |");
                        }
                    }

                    Console.WriteLine();
                    Console.Write(new String('-', (allTables - 1) * 5));

                    Console.WriteLine();

                    // ... end of print tables

                    // checks wether the entered table is no accupied by another waiter

                    bool valid = false;

                    while (!valid)
                    {
                        valid = true;
                        Console.WriteLine("Enter a table number:");
                        tableNum = int.Parse(Console.ReadLine());

                        foreach (Waiter wtr in newDay.Waiters)
                        {
                            foreach (Table tbl in wtr.Tables)
                            {
                                if (tbl.IsCurrent && tbl.TableNumber == tableNum && wtr.Name != waiter.Name)
                                {
                                    valid = false;
                                }
                            }
                        }

                        if (!valid)
                        {
                            Console.WriteLine("The table is occupied by another waiter");
                        }

                    }

                    // checks wether the entered table number exists in the current waiter tables
                    // if not, creates a new one else adds the orders to the current

                    if (waiter.Tables.Count > 0)
                    {
                        bool toAdd = true;

                        foreach (Table tbl in waiter.Tables)
                        {
                            if (tbl.TableNumber == tableNum && tbl.IsCurrent == true)
                            {
                                toAdd = false;
                                break;
                            }
                        }

                        if (toAdd)
                        {
                            table = new Table(tableNum);
                            waiter.AddTable(table);
                        }
                    }
                    else
                    {
                        table = new Table(tableNum);
                        waiter.AddTable(table);
                    }

                    Console.WriteLine("Enter \"A\" for adding order:");

                    keyinfo = Console.ReadKey();

                    // "A" - adding menu items

                    while (keyinfo.Key == ConsoleKey.A)
                    {
                        Console.Clear();

                        Console.WriteLine("Enter the menu item code: ");
                        menuItemCode = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter an amount:");
                        amount = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        // checks wether the code is less than the menu items

                        while (!new Order(menuItemCode, amount).LoadFromMenu)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter the menu item code: ");
                            menuItemCode = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter an amount:");
                            amount = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                        }

                        table.AddOrder(new Order(menuItemCode, amount));

                        Console.WriteLine("The order is added!");
                        Console.WriteLine();

                        Console.WriteLine("Press \"A\" for adding another order to the current table");
                        PrintOptions();

                        keyinfo = Console.ReadKey();
                    }
                }

                // "2" - Prints a choosen bill

                if (keyinfo.Key == ConsoleKey.D2)
                {
                    Console.Clear();

                    for (int wtr = 0; wtr < newDay.Waiters.Count; wtr++)
                    {
                        if (newDay.Waiters[wtr].Tables.Count > 0)
                        {
                            Console.Write("{0} - {1} - ", newDay.Waiters[wtr].Name, wtr);
                        }
                        else
                        {
                            Console.Write("{0} - no tables", newDay.Waiters[wtr].Name);
                        }

                        foreach (Table tbl in newDay.Waiters[wtr].Tables)
                        {
                            if (tbl.IsCurrent)
                            {
                                Console.Write("{0}, ", tbl.TableNumber);
                            }

                        }

                        Console.WriteLine();

                    }

                    Console.WriteLine("Enter waiter number (the position in the waiters list):");
                    wtrNumber = int.Parse(Console.ReadLine());

                    waiter = newDay.GetWaiter(wtrNumber);

                    Console.WriteLine("Enter table number:");
                    waiter.PrintBill(int.Parse(Console.ReadLine()));

                    PrintOptions();

                    keyinfo = Console.ReadKey();

                }

                // "3" - prints the total of chosen waiter

                if (keyinfo.Key == ConsoleKey.D3)
                {
                    Console.Clear();

                    Console.WriteLine("Enter waiter number (the position in the waiters list):");

                    for (int i = 0; i < newDay.Waiters.Count; i++)
                    {
                        Console.WriteLine("{0} - {1}", newDay.Waiters[i].Name, i);
                    }

                    wtrNumber = int.Parse(Console.ReadLine());

                    waiter = newDay.GetWaiter(wtrNumber);

                    Console.Clear();

                    waiter.CalculateTotal();

                    PrintOptions();

                    keyinfo = Console.ReadKey();
                }

                // "4" - Closes an account so the table will be free, the account still will be in the list

                if (keyinfo.Key == ConsoleKey.D4)
                {
                    Console.Clear();

                    for (int wtr = 0; wtr < newDay.Waiters.Count; wtr++)
                    {
                        Console.Write("{0} - {1} - ", newDay.Waiters[wtr].Name, wtr);

                        foreach (Table tbl in newDay.Waiters[wtr].Tables)
                        {
                            Console.Write("{0}, ", tbl.TableNumber);
                        }

                        Console.WriteLine();

                    }

                    Console.WriteLine("Enter waiter number (the position in the waiters list):");
                    wtrNumber = int.Parse(Console.ReadLine());

                    waiter = newDay.GetWaiter(wtrNumber);

                    Console.WriteLine("Enter table number:");
                    waiter.CloseTable(int.Parse(Console.ReadLine()));

                    Console.WriteLine("The order is closed");

                    PrintOptions();

                    keyinfo = Console.ReadKey();
                }

                if (keyinfo.Key == ConsoleKey.D5)
                {
                    Console.Clear();

                    Console.WriteLine("Enter waiter number (the position in the waiters list):");

                    for (int i = 0; i < newDay.Waiters.Count; i++)
                    {
                        Console.WriteLine("{0} - {1}", newDay.Waiters[i].Name, i);
                    }

                    wtrNumber = int.Parse(Console.ReadLine());

                    waiter = newDay.GetWaiter(wtrNumber);

                    Console.WriteLine("Enter percent: ");

                    double percent = int.Parse(Console.ReadLine());

                    Console.Clear();

                    waiter.CalculatePercent(wtrNumber, percent);

                    Console.WriteLine();

                    PrintOptions();

                    keyinfo = Console.ReadKey();
                }

                if (keyinfo.Key == ConsoleKey.D6)
                {
                    Console.Clear();

                    newDay.CalculateKitchenAndBarProfit();

                    Console.WriteLine();

                    PrintOptions();

                    keyinfo = Console.ReadKey();
                }

                if (keyinfo.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }

            }
        }

    }
}

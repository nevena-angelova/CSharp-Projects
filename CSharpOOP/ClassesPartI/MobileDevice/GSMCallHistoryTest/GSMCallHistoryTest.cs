using System;
using MobileDevice;

namespace GSMCallHistoryTest
{
    // (ex. 12)

    class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM android = new GSM("Galaxy", "Samsung", 980.99m, "Todor Cvetkov", new Battery("SM200"), new Display("420x580", 16));

            Console.WriteLine(android.ToString());

            android.AddCalls(new Call(DateTime.Now, "0887201776", 10));
            android.AddCalls(new Call(DateTime.Now, "0971201099", 25));
            android.AddCalls(new Call(DateTime.Now, "0873998809", 5));
            android.AddCalls(new Call(DateTime.Now, "0899441611", 35));
            android.AddCalls(new Call(DateTime.Now, "0888121780", 12));

            Console.WriteLine(android.CalcTotalPrice(10));
        }
    }
}

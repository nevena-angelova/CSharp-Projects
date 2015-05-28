//7. Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;

namespace Timer
{
    class Program
    {
        static void Main()
        {
            Timer timer = new Timer(5, delegate { Console.Beep(1500, 1000); });
            timer.Run();
        }
    }
}

using System;
using System.Threading;

namespace Timer
{
    public delegate void delegateFunction(); // declares delegate

    public class Timer
    {
        private int times;
        private delegateFunction myFunction; //creates delegate instance

        public Timer(int times, delegateFunction myFunction)
        {
            this.times = times;
            this.myFunction = myFunction;
        }

        public void Run()
        {
            int count = 0;

            while (true)
            {
                while (count < this.times)
                {
                    count++;
                    Console.WriteLine(count);
                    
                    Thread.Sleep(1000);
                    Console.Clear();
                }

                myFunction();
                count = 0;
            }
        }

    }
}

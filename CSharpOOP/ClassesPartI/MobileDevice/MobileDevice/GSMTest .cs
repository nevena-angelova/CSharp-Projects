using System;


namespace MobileDevice
{
    class GSMTest
    {
        static void Main()
        {
            GSM nokia = new GSM("N85", "Nokia", new Battery("NK"));

            GSM samsung = new GSM("N23", "Samsung", 250, "Lazar Stanev", new Battery("LMN-k2"), new Display("320x420", 3));

            samsung.Owner = "Mihail Kolev";

            GSM iPhone = GSM.IPhone4S;

            GSM[] gsmArray = { nokia, samsung, iPhone };

            foreach (GSM item in gsmArray)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}

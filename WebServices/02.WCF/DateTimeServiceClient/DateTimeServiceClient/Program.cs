namespace DateTimeServiceClient
{
    using DateTimeServiceClient.ServiceReferenceDate;
    using System;

    public class Program
    {
        static void Main()
        {
            DateServiceClient client = new DateServiceClient();

            string day = client.GetDay(DateTime.Now);

            Console.WriteLine(day);
        }
    }
}
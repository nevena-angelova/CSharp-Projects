namespace DateTimeService
{
    using System;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Globalization;

    public class DateService : IDateService
    {
        public string GetDay(DateTime date)
        {
            CultureInfo bg = new CultureInfo("bg-BG");
            return bg.DateTimeFormat.DayNames[(int)date.DayOfWeek];
        }
    }
}
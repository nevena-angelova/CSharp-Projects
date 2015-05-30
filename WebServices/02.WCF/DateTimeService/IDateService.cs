using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace DateTimeService
{
    [ServiceContract]
    public interface IDateService
    {
        [OperationContract]
        string GetDay(DateTime date);
    }
}

namespace StringsServiceLibrary
{
    using System;
    using System.Runtime.Serialization;
    using System.ServiceModel;

    [ServiceContract]
    public interface IStringSearchService
    {
        [OperationContract]
        int StringFoundCount(string text, string searched);
    }
}

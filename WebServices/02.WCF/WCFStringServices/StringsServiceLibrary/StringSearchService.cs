namespace StringsServiceLibrary
{
    using System;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;

    public class StringSearchService : IStringSearchService
    {
        public int StringFoundCount(string text, string searched)
        {
            int foundCount = 0;
            int lastIndex = text.IndexOf(searched);

            while (lastIndex != -1)
            {
                foundCount++;
                lastIndex = text.IndexOf(searched, lastIndex + 1);
            }

            return foundCount;
        }
    }
}

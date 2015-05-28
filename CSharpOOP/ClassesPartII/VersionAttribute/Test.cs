using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [Version(2,12)]
    class Test
    {
        static void Main()
        {
            Type type = typeof(Test);
            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in allAttributes)
            {
                Console.WriteLine(attribute.Version);
            }
        }
    }
}

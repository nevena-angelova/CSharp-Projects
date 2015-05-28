using System;
using System.Runtime.InteropServices;

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct |
  AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Enum)]
    public class VersionAttribute : System.Attribute
    {
        private int major;
        private int minor;

        public VersionAttribute(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public string Version
        {
            get { return this.major + "." + this.minor; }
        }
    }
}

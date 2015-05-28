using System;

namespace Restaurant
{
    class InvalidCodeException : ArgumentException
    {
        private int lineCount;
        private string msg;

        public InvalidCodeException(int lineCount, string msg)
        {
            this.lineCount = lineCount;
            this.msg = msg;
        }

        public int LineCount
        {
            get { return this.lineCount; }
        }

        public string Msg
        {
            get { return this.msg; }
        }
    }
}

using System;
using System.Text;

namespace Person
{
    class Person
    {
        private string name;
        private Nullable<int> age;

        public Person(string name, Nullable<int> age = null)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.name + "\n");

            if (this.age == null)
            {
                result.Append("no age");
            }
            else
            {
                result.Append(this.age);
            }

            return result.ToString();
        }
    }
}

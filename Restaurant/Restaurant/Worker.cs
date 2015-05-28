using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Worker : IWorker
    {
        private string name;
        private double salary;
        private Gender gender;

        public Worker(string name)
        {
            this.name = name;
            this.salary = 0;
            this.gender = Gender.undefined;
        }

        public string Name
        {
            get { return this.name; }
        }

        public double Salary
        {
            get { return this.salary; }
        }

        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public void AddSalary(double salary)
        {
            this.salary += salary;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public interface IWorker
    {
        string Name { get; }

        double Salary { get; }

        void AddSalary(double salary);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public interface IOrder
    {
        int Amount { get; }

        string Type { get; }

        double Price { get; }

        bool IsFood { get; }

        bool LoadFromMenu { get; }
    }

}

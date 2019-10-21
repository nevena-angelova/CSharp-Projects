using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraTwoStackAlgotithm
{
    class Program
    {
        static void Main()
        {

            string equation = "(1+((2+3)*(4*5)))";

            var values = new Stack<decimal>();
            var operators = new Stack<char>();

            for (int i = 0; i < equation.Length; i++)
            {
                if (equation[i] == '(')
                {
                    continue;
                }
                else if (equation[i] == '+' || equation[i] == '*')
                {
                    operators.Push(equation[i]);
                }
                else if (equation[i] == ')')
                {
                    var val2 = values.Pop();
                    var val1 = values.Pop();
                    decimal tempVal = 0;
                    var action = operators.Pop();

                    if (action == '+')
                    {
                        tempVal = val1 + val2;
                    }
                    else if (action == '*')
                    {
                        tempVal = val1 * val2;
                    }

                    values.Push(tempVal);
                }
                else
                {
                    decimal val = 0;
                    if (decimal.TryParse(equation[i].ToString(), out val))
                    {
                        values.Push(val);
                    }
                }
            }

            Console.WriteLine(values.Pop());


        }

    }
}

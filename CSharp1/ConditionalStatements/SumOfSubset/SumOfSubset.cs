// We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.
using System;

class SumOfSubset
{
    static void Main()
    {
        Console.WriteLine("Enter 5 integer numbers:");

        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < numbers.Length; j++)
        {
            for (int k = j + 1; k < numbers.Length; k++)
            {
                int sum = 0;

                sum = numbers[j] + numbers[k];

                if (sum == 0)
                {
                    Console.WriteLine("Zero is {0} + {1}", numbers[j], numbers[k]);
                }

                for (int l = k + 1; l < numbers.Length; l++)
                {
                    sum = 0;

                    sum = numbers[j] + numbers[k] + numbers[l];

                    if (sum == 0)
                    {
                        Console.WriteLine("Zero is {0} + {1} + {2}", numbers[j], numbers[k], numbers[l]);
                    }

                    for (int m = l + 1; m < numbers.Length; m++)
                    {
                        sum = 0;

                        sum = numbers[j] + numbers[k] + numbers[l] + numbers[m];

                        if (sum == 0)
                        {
                            Console.WriteLine("Zero is {0} + {1} + {2} + {3}", numbers[j], numbers[k], numbers[l], numbers[m]);
                        }

                        for (int n = m + 1; n < numbers.Length; n++)
                        {
                            sum = 0;

                            sum = numbers[j] + numbers[k] + numbers[l] + numbers[m] + numbers[n];

                            if (sum == 0)
                            {
                                Console.WriteLine("Zero is {0} + {1} + {2} + {3} + {4}", numbers[j], numbers[k], numbers[l], numbers[m], numbers[n]);
                            }
                        }
                    }
                }
            }
        }
    }
}



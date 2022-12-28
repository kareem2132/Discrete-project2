using System;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
               Console.Write("Enter n1: ");
               int n1 = int.Parse(Console.ReadLine());
               Console.Write("Enter n2: ");
               int n2 = int.Parse(Console.ReadLine());

               for (int i = n1; i <= n2; i++)
               {
                   if (IsPerfect(i))
                   {
                       Console.Write(i + " ");
                   }
               
               }

            static bool IsPerfect(int n)
            {
                int sum = 0;

                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }

                return sum == n;
            }
        }
    }
}

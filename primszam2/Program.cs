using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primszam2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    bool k = true;
                    for (int j = 2; j <= Math.Sqrt(n); j++)
                    {
                        if (n % j == 0)
                        {
                            k = false;
                            Console.Write(j.ToString() + "|");
                        }
                    }
                    if (k)
                    {
                        Console.WriteLine("igen");
                    }
                    else {
                        Console.Write(n.ToString() + "|");
                        Console.WriteLine("nem");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("hiba");
                }

            }
        }
    }
}

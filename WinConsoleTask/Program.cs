using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Введіть x");
            if (double.TryParse(Console.ReadLine(), out x))
            {
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть y");
                if (double.TryParse(Console.ReadLine(), out y))
                {
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть z");
                    if (double.TryParse(Console.ReadLine(), out z))
                    {
                        z = int.Parse(Console.ReadLine());
                    }
                }
              
                double r;
                r = ((2 * Math.Cos(Math.Pow(x, 2)) - 0.5) / (0.5 + Math.Sin(Math.Pow(y, 2-z)))) + (Math.Pow(z, 2)) / (7 - (z / 3));
                Console.WriteLine("Результат r = {0}",r);
            }
            else
            {
                Console.WriteLine("Error");
            }
           

        }
    }
}

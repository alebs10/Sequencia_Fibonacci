using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequência de Fibonnaci");
            Console.WriteLine("Digite a quantidade de sequência que deseja ver: ");
            int n = int.Parse(Console.ReadLine());

            int x = 0, y = 1, total;

            for (int i = 0; i < n; i++)
            {
                total = x + y;
                Console.WriteLine("O numero é " + total);
                y = x;
                x = total;

            }

            Console.ReadKey();
        }
    }
}

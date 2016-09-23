using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world with github");
            Game game1 = new Game(1, 2, 3, 4);
            game1.printState();
            game1[1, 1] = 0;
            game1.printState();
            Console.ReadKey();
        }
    }
}

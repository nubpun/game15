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
            Game game1 = new Game(0, 1, 2 ,3);
            try
            {
                game1.PrintState();
                game1.Shift(1);
                game1.PrintState();
                game1.Shift(3);
                game1.PrintState();
                game1.Shift(2);
                game1.PrintState();
                Console.ReadKey();
                game1.Shift(3);
                game1.PrintState();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            
        }
    }
}

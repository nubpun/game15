using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    class Game
    {
        int[,] field;
        public Game(int n)
        {
            field = new int[n,n];
            for (int i = 0; i < n; i++)
                field[i, i] = i;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    class Game
    {
        int[][] field;
        public Game(params int[] values)
        {
            int n = (int)Math.Sqrt(values.Length);
            field = new int[n][];
            for (int i = 0; i < n; i++)
            {
                field[i] = new int[n]; 
                for (int j = 0; j < n; j++)
                {
                    field[i][j] = values[n * i + j];
                }
            }
                
        }
        public void printState()
        {
            int n = field[0].Length ;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }
        }
        public int this[int x, int y]
        {
            get { return field[x][y]; }
            set { field[x][y] = value; }
        }
    }
}

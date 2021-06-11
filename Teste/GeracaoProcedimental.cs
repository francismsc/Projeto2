using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public struct GeracaoProcedimental
    {
      public char[,] newworld { get; }


        
        public GeracaoProcedimental(int linemax, int colMax)
        {
            newworld = new char[linemax, colMax];
        }

        public void ChangeWorld(int line, int col, int value)
        {
            if (value == 0)
            {

               newworld[line, col] = '.';

            }else
            {
                newworld[line, col] = '#';
            }
        }

        public override string ToString()
        {
            string str = "";
            for (int line = 0; line < newworld.GetLength(0); line++)
            {
                for (int col = 0; col < newworld.GetLength(1); col++)
                {
                    str += newworld[line, col];
                }
                str += "\n";
            }
            return str;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Gerar
    {
        

        private GeracaoProcedimental beforeWorld;
        private GeracaoProcedimental world;

        public int linemax = 8;
        public int colmax = 8;

        public Gerar(int linemax, int colmax, int n)
        {
            
            beforeWorld = RandomWorld(linemax, colmax);
            GerarNewWorld(beforeWorld);
        }

        public void GerarNewWorld(GeracaoProcedimental world1)
        {
            GeracaoProcedimental worldBoard = new GeracaoProcedimental
                (world1.newworld.GetLength(0), world1.newworld.GetLength(1));

            for (int line = 0; line < world1.newworld.GetLength(0); line++)
            {
                for(int col = 0; col <world1.newworld.GetLength(1); col++)
                {
                    worldBoard.ChangeWorld(line, col, CalcWorld(line,col));
                }
            }

            this.world = worldBoard;

        }

        public int CalcWorld(int line, int col)
        {
            int totalsum = 0;
            int actualsum = 0;

            //Upper Left , Middle , Right
            totalsum = Convert.ToInt32(beforeWorld.newworld[Wrap(line - 1, beforeWorld.newworld.GetLength(0)),
                Wrap(col - 1, beforeWorld.newworld.GetLength(1))]);
            Console.WriteLine(totalsum);
            if (totalsum == 35)
            {
                actualsum += 0;
            }
            else
            {
                actualsum += 1;
            }
            totalsum = Convert.ToInt32(beforeWorld.newworld[Wrap(line - 1, beforeWorld.newworld.GetLength(0)), col]);
            if (totalsum == 35)
            {
                actualsum += 0;
            }
            else
            {
                actualsum += 1;
            }
            totalsum = Convert.ToInt32(beforeWorld.newworld[Wrap(line - 1, beforeWorld.newworld.GetLength(0)),
                Wrap(col + 1, beforeWorld.newworld.GetLength(1))]);
            if (totalsum == 35)
            {
                actualsum += 0;
            }
            else
            {
                actualsum += 1;
            }

            //Middle Left, right

            totalsum = Convert.ToInt32(beforeWorld.newworld[line, Wrap(col - 1, beforeWorld.newworld.GetLength(1))]);
            if (totalsum == 35)
            {
                actualsum += 0;
            }
            else
            {
                actualsum += 1;
            }
            totalsum = Convert.ToInt32(beforeWorld.newworld[line, Wrap(col + 1, beforeWorld.newworld.GetLength(1))]);
            if (totalsum == 35)
            {
                actualsum += 0;
            }
            else
            {
                actualsum += 1;
            }

            //Lower Left, Middle, Right
            totalsum = Convert.ToInt32(beforeWorld.newworld[Wrap(line + 1, beforeWorld.newworld.GetLength(0)),
                Wrap(col - 1, beforeWorld.newworld.GetLength(1))]);
            if (totalsum == 35)
            {
                actualsum += 0;
            }
            else
            {
                actualsum += 1;
            }
            totalsum = Convert.ToInt32(beforeWorld.newworld[Wrap(line + 1, beforeWorld.newworld.GetLength(0)), col]);
            if (totalsum == 35)
            {
                actualsum += 0;
            }
            else
            {
                actualsum += 1;
            }
            totalsum = Convert.ToInt32(beforeWorld.newworld[Wrap(line + 1, beforeWorld.newworld.GetLength(0)),
                Wrap(col + 1, beforeWorld.newworld.GetLength(1))]);
            if (totalsum == 35)
            {
                actualsum += 0;
            }
            else
            {
                actualsum += 1;
            }


            if (actualsum-1 >= 5)
            {
                return 1;
            }else
            {
                return 0;
            }

        }

        public int GroundvsRock()
        {
            Random rnd = new Random();
            return rnd.Next(0, 2);
        }

        private GeracaoProcedimental RandomWorld(int linemax,int colmax)
        {
            Random rnd = new Random();
            GeracaoProcedimental mat = new GeracaoProcedimental(linemax, colmax);

            for (int line = 0; line < linemax; line++)
            {
                for (int col = 0; col < colmax; col++)
                {
                    mat.ChangeWorld(line, col, rnd.Next(0,2));
                }
            }
            return mat;
        }

        public int Wrap(int pos, int max)
        {
            if (pos < 0)
            {
                return max - 1;
            }
            else if (pos >= max)
            {
                return 0;
            }

            return pos;
        }

        public void PrintWorld()
        {
            Console.WriteLine(beforeWorld.ToString() + "\n");

            Console.WriteLine(world.ToString() + "\n");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerar FirstWorld = new Gerar
                (8,8,5);
            FirstWorld.PrintWorld();
            Console.ReadLine();
        }
    }
}

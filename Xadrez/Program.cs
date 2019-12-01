using System;
using System.Threading;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PosicaoXadrez pos = new PosicaoXadrez('a', 1);
                Console.WriteLine(pos);
                Console.WriteLine(pos.ToPosicao());
                Console.ReadLine();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }     
        }
             
    }
}

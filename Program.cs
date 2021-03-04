using Scacchi.Pedine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scacchi
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Pedina> pedine = new List<Pedina>();
            GeneraPedine(pedine);
            DisegnaPedine(pedine);
            Console.ReadKey();
        }
        static void DisegnaPedine(List<Pedina> pedine)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    Pedina found = null;
                    foreach (Pedina p in pedine)
                    {
                        if (p.XPosition == x && p.YPosition == y)
                        {
                            found = p;
                            break;
                        }
                    }
                    if (found != null)
                        Console.Write(found.Simbolo);
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }
        static void GeneraPedine(List<Pedina> pedine)
        {
            Random r = new Random();
            for (int i = 0; i < 15; i++)
            {
                Pedina p = null;
                int numero = r.Next(0, 6);
                if (numero == 0)
                    p = new Pedone(r);
                else if (numero == 1)
                    p = new Cavallo(r);
                else if (numero == 2)
                    p = new Alfiere(r);
                else if (numero == 3)
                    p = new Torre(r);
                else if (numero == 4)
                    p = new Re(r);
                else if (numero == 5)
                    p = new Regina(r);
                pedine.Add(p);
            }
        }
    }
}

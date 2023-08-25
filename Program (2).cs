using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOx4
{
    internal class Tringulo
    {
        static void Main(string[] args)
        {
            Triangulo a;
            a = new Triangulo ();


            Console.WriteLine("Digite o valor da base");
            a.setb(double.Parse(Console.ReadLine()));

            Console.WriteLine("valor da altura");

            a.seth(double.Parse(Console.ReadLine()));

            a.calcular();


            Console.WriteLine("O valor da area {0}", a.geta());
        }
    }
}

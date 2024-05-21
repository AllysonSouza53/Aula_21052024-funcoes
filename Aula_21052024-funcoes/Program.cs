using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_21052024_funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int F;
            Console.WriteLine("escolha entre Quadrado(1), Retangulo(2), Trapézio(3),Losango(4)");
            F = int.Parse(Console.ReadLine());
            switch (F)
            {
                case 1:
                    Q();
                    break;
                case 2:
                    R();
                    break; 
                case 3:
                    T();
                    break;
                case 4:
                    L();
                    break;
                default:
                    Console.WriteLine("Forma inesistente");
                    break;
            }
            Console.ReadKey();
        }
        static void Q()
        {
            Console.WriteLine("valor dos lados: ");
            double L = double.Parse(Console.ReadLine());

            double Aq = L * L;

            Console.WriteLine("A Area é:" + Aq);
        }
        static void R()
        {
            Console.WriteLine("valor do lado 1: ");
            double L1 = double.Parse(Console.ReadLine());

            Console.WriteLine("valor do lado 2: ");
            double L2 = double.Parse(Console.ReadLine());

            double Ar = L1 * L2;

            Console.WriteLine("A Area é:"+ Ar);
        }
        static void T()
        {
            Console.WriteLine("valor da base pequena: ");
            double Bp = double.Parse(Console.ReadLine());

            Console.WriteLine("valor da base grande: ");
            double Bg = double.Parse(Console.ReadLine());

            Console.WriteLine("valor da altura ");
            double A = double.Parse(Console.ReadLine());

            double At = (Bp+Bg)*A/2;

            Console.WriteLine("A Area é:" + At);
        }
        static void L()
        {
            Console.WriteLine("valor do diametro 1: ");
            double D1 = double.Parse(Console.ReadLine());

            Console.WriteLine("valor do diametro 2: ");
            double D2 = double.Parse(Console.ReadLine());

            double Al = (D1*D2)/2;

            Console.WriteLine("A Area é:" + Al);
        }
    }

}

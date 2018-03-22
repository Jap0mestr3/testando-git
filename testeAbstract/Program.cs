using System;
using System.Collections.Generic;
using System.Globalization;

namespace testeAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Figura> lista = new List<Figura>();

            Console.Write("Quantas figuras irá digitar?");
            int N = int.Parse(Console.ReadLine());

            for(int i=1; i<=N; i++)
            {
                Console.Write("Figura " + i + "- Triangulo ou Retangulo(t/r)? ");
                char ch = char.Parse(Console.ReadLine());
                if(ch == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Figura f = new Retangulo(largura, altura, "vermelho");
                    lista.Add(f);
                }
                else
                {
                    Console.Write("Lado A: ");
                    double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Lado B: ");
                    double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Lado C: ");
                    double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Figura f = new Triangulo(a, b, c, "azul");
                    lista.Add(f);
                }
            }
            Console.WriteLine("Área das Figuras: ");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Figura " +i+ ": " +lista[i-1].area());
            }
            Console.ReadLine();
        }
    }
}

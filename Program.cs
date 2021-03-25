using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Console.Clear();
        
        const Double g = 9.80665;

        Double anguloGraus , velocidade , anguloRadianos , alcance , altura;

        Console.WriteLine("---------------");
        Console.WriteLine("-- Projétil --");
        Console.WriteLine("---------------\n");

        Console.Write("Entre com a velocidade, em m/s..: ");
        velocidade = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine();

        Console.Write("Entre com o ângulo, em graus....: ");
        anguloGraus = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine();

        anguloRadianos = anguloGraus * (Math.PI/180);

        alcance = (Math.Pow(velocidade, 2) * Math.Sin(2 * anguloRadianos)) / g;

        altura = Math.Pow((velocidade * Math.Sin(anguloRadianos)), 2) / (2 * g);

        Console.Write($"Alcance........: {alcance:N2}\n");
        
        Console.WriteLine();
        
        Console.Write($"Altura máxima..: {altura:N2}");

        }
    }
}

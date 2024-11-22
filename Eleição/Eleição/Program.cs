using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eleicoes_america
{
    internal class Program
    {
        static double porcentagem(double votos, double votosTotais)
        {
            return (votos / votosTotais) * 100;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ELEIÇÕES AMERICANAS 2024");
            Console.ResetColor();

            Console.Write("\nDigite o números de votos para Kamala Harris: ");
            int candidato1 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o números de votos para Donald Trump: ");
            int candidato2 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a quantidade de votos nulos/brancos: ");
            int nulos = int.Parse(Console.ReadLine());

            int total = candidato1 + candidato2 + nulos;

            double cndt1 = porcentagem(candidato1, total);
            double cndt2 = porcentagem(candidato2, total);
            double brancos = porcentagem(nulos, total);

            Console.WriteLine("\nO RESULTADO DAS ELEIÇÕES:");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Kamala Harris recebeu {cndt1:F2}% dos votos.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Donald Trump recebeu {cndt2:F2}% dos votos.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Votos nulos/brancos {brancos:F2}% dos votos.");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gab = new int[10];
            int[,] provas = new int[5, 10];
            Random r = new Random();
            int [] nota = new int[5];
            int soma = 0;
            int maior = int.MinValue;
            double media;

            Console.WriteLine("Gabarito:");
            for (int i = 0; i < gab.Length; i++)
            {
                gab[i] = r.Next(1, 5);
                Console.Write(gab[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Provas:");
            for (int i = 0; i < provas.GetLength(0); i++)
            {
                for (int j = 0; j < provas.GetLength(1); j++)
                {
                    provas[i, j] = r.Next(1, 5);
                    Console.Write(provas[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < provas.GetLength(0); i++)
            {
                for (int j = 0; j < provas.GetLength(1); j++)
                {
                    if (provas[i, j] == gab[j])
                    {
                        nota[i]++;
                    }

                }
                if (nota[i] > maior)
                {
                    maior = nota[i];
                }
                soma = soma + nota[i];
                Console.Write($"Nota do {i + 1}° Aluno: " + nota[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Maior Nota: " + maior);
            media = (double) soma / 5;
            Console.Write("Média: " + media);
            Console.ReadLine();
        }
    }
}

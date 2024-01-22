using System.Collections;
using System.Collections.Generic;

internal class Program
{

    static void Main()
    {
        Console.WriteLine("Digite quantos números quiser (digite 'n' para encerrar): ");

        List<int> list = new List<int>();

        Func<List<int>, int> sumFunc = Sum;

        while (true)
        {
            Console.Write("Número: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "n")
            {
                break;
            }

            if (int.TryParse(input, out int num))
            {
                list.Add(num);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro válido.");
            }
        }

        int sumResult = sumFunc(list);

        Console.WriteLine("Resultado da soma: " + sumResult);
    }

    static int Sum(List<int> numsList)
    {
        int totalSum = 0;
        foreach (int num in numsList)
        {
            totalSum += num;
        }
        return totalSum;
    }
}
using System; //Adiciona a biblioteca System
using Biblioteca_Array;


namespace Lista1_CSharp;
public class Exercicio1
{
    private static void Main()
    {
        // Perguntar ao usuário quantos elementos o array deve ter
        Console.WriteLine("Quantos elementos tera no seu array? ");
        int number = int.Parse(Console.ReadLine());

        // Chamar a função GerarArray, passando o número de elementos
        int[] array = ArrayFunctions.GerarArray(number);

        // Exibir o array gerado
        Console.WriteLine("Array gerado com números aleatórios:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

    }

}
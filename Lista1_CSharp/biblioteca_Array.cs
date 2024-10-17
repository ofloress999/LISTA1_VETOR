using System;

namespace Biblioteca_Array
{
    public static class ArrayFunctions
    {
        public static int[] GerarArray(int number)
        {
            int[] array = new int[number];  // Cria o array com o tamanho fornecido
            Random random = new Random();   // Instância da classe Random para gerar números aleatórios

            // Preenche o array com números aleatórios
            for (int i = 0; i < number; i++)
            {
                array[i] = random.Next(1, 101);  // Gera números aleatórios entre 1 e 100
            }

            // Retorna o array gerado
            return array;
        }

        public static int SomarArray(int[] array)
        {
            int soma = 0;
            
            foreach(var item in array)
            {
                soma += item;
            }

            return soma;
        }

    }
}

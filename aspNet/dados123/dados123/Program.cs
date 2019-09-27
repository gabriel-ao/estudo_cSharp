using System;

namespace dados123
{
    class Program
    {
        static void Main(string[] args)
        {
            // logica para tratar numeros de 1 a 9
            string entrada = "21";
            int quantidadeNumeros = 0;

            char [] vetor = entrada.ToCharArray();

            for (int i = 0; i <= vetor.Length ; i++)
            {
                if (i < vetor.Length-1)
                {
                    if (vetor[i] == vetor[i + 1])
                    {
                        quantidadeNumeros++;
                    }
                    else
                    {
                        quantidadeNumeros++;
                        Console.Write(quantidadeNumeros +""+ vetor[i]);
                        quantidadeNumeros = 0;
                    }
                }
                else
                {
                    quantidadeNumeros++;
                    Console.Write(quantidadeNumeros + "" + vetor[i]);
                    Console.ReadKey();
                }
               
            }

            Console.WriteLine("fim do codigo");
            Console.ReadKey();
        }
    }
}

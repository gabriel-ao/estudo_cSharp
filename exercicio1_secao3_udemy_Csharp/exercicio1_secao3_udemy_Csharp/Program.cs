using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_secao3_udemy_Csharp
{
    class Program
    {
        static List<Produto> peca;
        static double total = 0.0;
        static double aux = 0.0;

        static void Main(string[] args)
        {
            // exercicio 05

            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, 
            //o valor unitário de cada peça 1, o código de uma peça 2, o número de
            //peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.

            //Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1010/uri1010/Program.cs 

            int opcao;
            peca = new List<Produto>();

            try
            {
                do
                {
                    Console.WriteLine("digite 0 para finalizar");
                    Console.WriteLine("digite 1 para adicionar");
                    Console.WriteLine("digite 2 para listar");
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            adicionar();
                            Console.ReadKey();
                            break;
                        case 2:
                            loopProduto();
                            Console.ReadKey();
                            break;
                    }

                } while (opcao != 0);
            }
            catch (FormatException)
            {

                Console.WriteLine("Formatação errada, fim do codigo");
            }

            Console.ReadKey();
            // fim classe
        }

        public static void adicionar()
        {
            Console.WriteLine("exercicio sobre produto! ");

            Console.WriteLine("digite o codigo: ");
            var codigo = Console.ReadLine();

            Console.WriteLine("digite a quantidade: ");
            var quantidade = Console.ReadLine();

            Console.WriteLine("digite o valor do: ");
            var valor = Double.Parse(Console.ReadLine());

            // tipos montados de maneiras diferentes para treino
            Produto produto = new Produto(Convert.ToInt16(quantidade), int.Parse(codigo), valor);

            peca.Add(produto);
            // fim adicionar
        }

        public static void loopProduto()
        {
            try
            {
                foreach (var item in peca)
                {
                    aux = item.valorPecas * item.qtdPecas;
                    total += aux;
                }

                Console.WriteLine($" o valor a pagar é {total}");
                // apos listar, estou zerando a variavel que mostra os tipos
                total = 0.0;

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Lista nula");

            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edificio
{
    class Program
    {
        static Produto[] vetor = new Produto[5];
        static Produto prod = new Produto();
        static int j = 0;

        static void Main(string[] args)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = new Produto();
            }


            int opcao = 0;

            while (opcao != 9)
            {
                //Console.Clear();
                Console.WriteLine("programa que adiciona pessoas no quarto");
                Console.WriteLine("Digite uma das opções a baixo");
                Console.WriteLine("Adicionar cliente = 1 ");
                Console.WriteLine("Listar cliente    = 2 ");
                Console.WriteLine("excluir cliente   = 3 ");
                Console.WriteLine("sair do programa! = 9 ");

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            EscolherQuarto();
                            break;
                        case 2:
                            ListarQuartos();
                            break;
                        case 3:
                            SaidaUsuario();
                            break;
                        case 9:
                            Console.WriteLine("programa finalizado");
                            break;
                        default:
                            Console.WriteLine("não é um opção do menu, favor tente novamente");
                            break;
                    }
                }
                catch (FormatException format)
                {
                    Console.WriteLine("erro de formatação ");
                }
                catch (Exception generico)
                {
                    Console.WriteLine("Erro generico ");
                }

            }
            // fim do main
            Console.ReadKey();
        }

        public static void EscolherQuarto()
        {

            string nome, email;
            int quarto;

            Console.WriteLine("digite um quarto que deseja! ");
            quarto = int.Parse(Console.ReadLine());

            if (quarto > vetor.Length)
            {
                Console.WriteLine(prod.AcimaEsperado());
            }
            else if (vetor[quarto].nome == null)
            {
                Console.WriteLine("nome");
                nome = Console.ReadLine();

                Console.WriteLine("email");
                email = Console.ReadLine();
                vetor[quarto] = new Produto(nome, email, quarto);
                Console.WriteLine($"Cliente: {nome} de email {email} no quarto {quarto}");
            }
            else
            {
                Console.WriteLine("quarto ocupado no momento");
            }
            Console.ReadKey();
            Console.Clear();
            // fim metodo EscolherQuarto
        }

        public static void ListarQuartos()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i].nome != null)
                {
                    Console.WriteLine($"quarto: {vetor[i].quarto}, nome: {vetor[i].nome}, email: {vetor[i].email}");
                }
                else
                {
                    Console.WriteLine($"Quarto {i}, vazio no momento");
                }
            }

            Console.ReadKey();
            Console.Clear();
            // fim metodo ListarQuartos
        }

        public static void SaidaUsuario()
        {
            Console.WriteLine("qual cliente deve ser apagado! ");
            int quarto = int.Parse(Console.ReadLine());

            if (quarto > vetor.Length)
            {
                Console.WriteLine("valor acima da quantidade de quartos");
            }

            else if (vetor[quarto].nome == null)
            {
                Console.WriteLine(prod.QuartoLimpo());
            }
            else
            {
                vetor[quarto].quarto = 0;
                vetor[quarto].nome = null;
                vetor[quarto].email = null;
                Console.WriteLine(prod.QuartoLimpo());
            }

            // chamando o metodo listar para montrar a exclusão
            ListarQuartos();
            // fim metodo SaidaUsuario
        }
    }
}

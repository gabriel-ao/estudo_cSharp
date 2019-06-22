using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_secao3_udemy_Csharp
{
    class Produto
    {
        public int qtdPecas { get; set; }
        public int IdPecas { get; set; }
        public double valorPecas { get; set; }

        public Produto(int qtdPecas, int IdPecas, double valorPecas){
            this.qtdPecas = qtdPecas;
            this.IdPecas = IdPecas;
            this.valorPecas = valorPecas;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edificio
{
    public class Produto
    {
        // construtor vazio
        public Produto()
        {

        }

        // construtor 2 parametros
        public Produto(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
            this.quarto = quarto;
        }


        // construtor 3 parametros
        public Produto(string nome, string email, int quarto)
        {
            this.nome = nome;
            this.email = email;
            this.quarto = quarto;
        }

        // variaveis
        public int quarto { get; set; }
        public string nome { get; set; }
        public string email { get; set; }


        // mensagem de usuario
        public string Mensagem()
        {
            return "nome: "+this.nome+" email "+ this.email; 
        }

        public string AcimaEsperado()
        {
            return " Edficio não comporta o segunte quarto ";
        }

        public string QuartoLimpo()
        {
            return " Quarto consta vazio no momento";
        }

    }
}

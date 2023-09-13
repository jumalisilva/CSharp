using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLojaABC
{
    public class Pessoa
    {
        //variáveis globais
        private string nome;
        private string email;
        private int idade;

        //método construtor, serve para executar a classe
        public Pessoa()
        {

        }

        public void imprimirValores()
        {
            //imprimindo valores
        }

        public int calculaIdade(int idade)
        {
            return this.idade = idade + 1;
        }
    }
}

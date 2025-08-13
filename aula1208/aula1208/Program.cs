using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa objJogador; //Cria uma variável na memória
            Pessoa camisa7;
            Pessoa camisa10;
            objJogador = new Pessoa(); //Cria um objeto
            camisa7 = new Pessoa();
            camisa10 = new Pessoa();

            objJogador.Cadastrar();
            camisa10.Cadastrar();
            camisa7.Cadastrar();
           
            objJogador.Exibir();
            camisa7.Exibir();
            camisa10.Exibir();

        }
    }
}
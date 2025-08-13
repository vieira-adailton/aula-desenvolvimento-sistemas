using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1208
{
    class Pessoa
    {
        public string nome;
        public string email;
        public string telefone;

        public void Cadastrar() { //Função sem retorno
            Console.WriteLine("Digite o nome do jogador: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o E-mail do jogador: ");
            email = Console.ReadLine();
            Console.WriteLine("Digite o telefone do jogador: ");
            telefone = Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("E-mail: {0}", email);
            Console.WriteLine("Telefone: {0}", telefone);
        }
    }
}

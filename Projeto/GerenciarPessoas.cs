using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class GerenciarPessoas
    {
        
        private readonly List<Pessoa> ListaPessoa = new List<Pessoa>();

        public void CadastrarPessoa()
        {
            Pessoa p = new Pessoa();

            Console.WriteLine("Você escolheu cadastrar pessoa. \nDigite o nome da pessoa que deseja cadastrar.");
            p.nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite a idade.");
            p.idade = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o CPF.");
            p.cpf = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o e-mail.");
            p.email = Console.ReadLine();
            Console.WriteLine();

            ListaPessoa.Add(p);

        }

        public void BuscarPessoa()
        {

        }

        public void EditarPessoa()
        {

        }

        public void ListarPessoa()
        {
            int num = ListaPessoa.Count;

          /*  for (int i = 0; i<num; i++)
            {
                Pessoa Atual = ListaPessoa[i];
                Console.WriteLine($"{Atual.nome}, {Atual.idade}, {Atual.cpf}, {Atual.email}.");
            }
          */

            foreach (Pessoa Atual in ListaPessoa)
            {
                Console.WriteLine($"{Atual.nome}, {Atual.idade}, {Atual.cpf}, {Atual.email}.");
            }  

        }
    }
}

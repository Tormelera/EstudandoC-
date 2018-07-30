using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciarPessoas gerenciar = new GerenciarPessoas();

            while (true)
            {
                

                int code;

                Console.WriteLine("Digite 1 para Cadastrar pessoas.\nDigite 2 para Listar pessoas.");
                code = int.Parse(Console.ReadLine());

                switch (code)
                {
                    case 1:

                        gerenciar.CadastrarPessoa();

                        break;

                    case 2:

                        gerenciar.ListarPessoa();

                        break;

                    default:

                        Console.WriteLine("Opção inválida.");

                        break;
                }

                

            }

            Console.ReadKey();


        }
    }
}

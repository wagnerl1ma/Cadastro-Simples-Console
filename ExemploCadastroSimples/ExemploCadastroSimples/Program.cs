using System;
using System.Collections.Generic;

namespace ExemploCadastroSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cadastro Simples";
            Console.WriteLine("Olá, Seja Bem-Vindo!");

            Console.Write("Digite quantos clientes deseja cadastrar: ");
            int qtdCliente = 0;

            //Caso digitar string na variável int, não irá lançar exceção, irá retornar 0
            bool intSucesso = int.TryParse(Console.ReadLine(), out qtdCliente);

            while (intSucesso == false || qtdCliente <= 0)
            {
                Console.Write("Valor inválido! Digite quantos clientes deseja cadastrar: ");
                intSucesso = int.TryParse(Console.ReadLine(), out qtdCliente);
            }


            var listaCliente = new List<Cliente>();

            for (int i = 0; i < qtdCliente; i++)
            {
                Console.Clear();
                Console.Write("Digite o nome do cliente " + (i + 1) + ": ");
                string nomeCliente = Console.ReadLine();

                Console.Write("Digite a idade do cliente " + (i + 1) + ": ");
                int idadeCliente = 0;

                //Caso digitar string na variável int, não irá lançar exceção, irá retornar 0
                bool intIdadeSucesso = int.TryParse(Console.ReadLine(), out idadeCliente);

                while (intIdadeSucesso == false || idadeCliente <= 0)
                {
                    Console.Write("Valor inválido! digite novamente a idade do cliente " + (i + 1) + ": ");
                    intIdadeSucesso = int.TryParse(Console.ReadLine(), out idadeCliente);
                }

                listaCliente.Add(new Cliente { Id = i, Nome = nomeCliente, Idade = idadeCliente });
            }

            Console.Clear();
            Console.WriteLine("Lista dos Clientes Cadastrados: \n");

            foreach (var cliente in listaCliente)
            {
                Console.WriteLine($"Id: {cliente.Id}");
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"Idade: {cliente.Idade} \n");

                Console.WriteLine("###################################\n");
            }

            Console.ReadKey();
        }
    }
}

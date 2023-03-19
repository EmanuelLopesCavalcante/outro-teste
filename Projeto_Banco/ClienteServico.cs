using M1S3_SistemaBanco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco
{
    internal class ClienteServico : IClienteServico
    {
        List<Cliente> clientes = new List<Cliente>();



        public void CriarPessoaFisica()
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            Console.WriteLine("Data de Nascimento do cliente:");
            pessoaFisica.DataNascimento = DateTime.Parse(Console.ReadLine());
            if (!pessoaFisica.EhMaior())
            {
                Console.WriteLine("não é possivel abrir a conta pois o CLiente é menor de idade");
                return;
            }
            Console.WriteLine("A idade do cliente é " + pessoaFisica.Idade);
            Console.WriteLine("Nome do cliente:");
            pessoaFisica.Nome = Console.ReadLine();
            Console.WriteLine("CPF do cliente:");
            pessoaFisica.CPF = Console.ReadLine();
            Console.WriteLine("Endereco do cliente:");
            pessoaFisica.Endereco = Console.ReadLine();
            Console.WriteLine("Telefone do cliente:");
            pessoaFisica.Telefone = Console.ReadLine();
            Console.WriteLine("Email do cliente:");
            pessoaFisica.Email = Console.ReadLine();
            Console.WriteLine("Numero Da Conta");
            pessoaFisica.NumeroConta = int.Parse(Console.ReadLine());
            clientes.Add(pessoaFisica);

        }


       public Cliente BuscarClientePorNumeroDeConta(int numeroConta)
        {
            ;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.NumeroConta == numeroConta)
                {
                    return cliente;
                }
            }
            // mesma coisa que o foreach
            // for(int i =0; i < clientes.Count; i++){
            //    if(clientes[i].NumeroConta == numeroConta);
            //     return clientes[i];
            // }
            return null;
        }

        public void ExibirClientes()
        {
            Console.WriteLine("Número da conta        | Nome / Razão social         | CPF / CNPJ    ");
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine(clientes[i].ResumoCliente());
            }
        }
        public void CriarPessoaJuridica()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            Console.WriteLine("Razão social do cliente:");
            pessoaJuridica.RazaoSocial = Console.ReadLine();
            Console.WriteLine("CNPJ do cliente:");
            pessoaJuridica.CNPJ = Console.ReadLine();
            Console.WriteLine("Endereco do cliente:");
            pessoaJuridica.Endereco = Console.ReadLine();
            Console.WriteLine("Telefone do cliente:");
            pessoaJuridica.Telefone = Console.ReadLine();
            Console.WriteLine("Email do cliente:");
            pessoaJuridica.Email = Console.ReadLine();
            Console.WriteLine("Numero Da Conta");
            pessoaJuridica.NumeroConta = int.Parse(Console.ReadLine());
            clientes.Add(pessoaJuridica);

        }



    }
}


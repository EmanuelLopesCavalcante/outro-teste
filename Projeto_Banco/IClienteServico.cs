using M1S3_SistemaBanco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco
{
    public interface IClienteServico
    {

        void CriarPessoaFisica();
        void CriarPessoaJuridica();
        Cliente BuscarClientePorNumeroDeConta(int numeroConta);
        void ExibirClientes();
    }
}

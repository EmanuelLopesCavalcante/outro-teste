using M1S3_SistemaBanco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco
{
    internal class PessoaJuridica : Cliente
    {
        static List<PessoaJuridica> listapj;
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }

        public PessoaJuridica()
        {

        }
        public PessoaJuridica(string cNPJ, string razaoSocial, string email, string telefone,
                       string end, int numeroConta) : base (email, telefone, end, numeroConta)
        {
            CNPJ = cNPJ;
            RazaoSocial = razaoSocial;
        }

        public override string ResumoCliente()
        {
            return $"{NumeroConta} | {RazaoSocial} | {CNPJ}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_teste
{
    internal class Cliente
    {
        private string nomeTitular;
        private string cpf;
        private string senha;


        public void Cadastrar(string nome,string senha, string doc)
        {
            this.nomeTitular = nome;
            this.cpf = doc;
            this.senha = senha;

        }
        public string getCpf() { return cpf; }


    }
}

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
        

        public void Cadastrar(string nome,string doc)
        {
            this.nomeTitular = nome;
            this.cpf = doc;

        }
        public string getCpf() { return cpf; }


    }
}

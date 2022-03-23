using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_teste
{
    internal class Conta
    {
        private string idConta;
        private double saldo;
        private string senha;
        public Cliente titular;


        public bool Sacar(double valorSaque)
        {
            bool autorizacaoSaque = (this.saldo >= valorSaque) && (valorSaque > 0);

            if(autorizacaoSaque)
            {
                this.saldo -= valorSaque;
                return true;
            }
            else
            { return false;}
                        
        }
        public double getSaldo()
            { return this.saldo; }
                

        public void setSenha(string passwd)
        {            
                this.senha = passwd;         
                        
        }


        public void setID(string valor)
        {
            
            this.idConta = valor;
 
        }

        public string getId()
        {
            return this.idConta;
        }


        public void Depositar(double valorDeposito)
        {
            this.saldo += valorDeposito;            

        }


        public bool Transferir(double valor, Conta contaDestino)
        {
            if (this.Sacar(valor))
            {
                contaDestino.Depositar(valor);
                return true;
            }
            return false;

        }


    }
}

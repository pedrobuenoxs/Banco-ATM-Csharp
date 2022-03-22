using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_teste
{
    internal class Conta
    {
        private int idConta;
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
        public double saldoAtual()
            { return this.saldo; }
        public bool Login(string passwd)
        {
            if (this.senha == passwd)
            {
                return true;
            }
            return false;
        }
                   

        public int addIdConta(int valor)
        {
            this.idConta = valor;
            return this.idConta; 
        }

        public int idDaConta()
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
                this.saldo = this.saldo - valor;
                contaDestino.Depositar(valor);
                return true;
            }
            return false;

        }


    }
}

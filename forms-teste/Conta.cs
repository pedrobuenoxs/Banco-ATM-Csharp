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
        public double saldo;
        public string statusSaque;
        public Cliente titular;


        public bool Sacar(double valorSaque)
        {
            

            if((this.saldo >= valorSaque) && (valorSaque > 0))
            {
                //this.saldo -= valorSaque;
                return true;
                this.statusSaque = "Saque autorizado!";
            }
            else
            {
                this.statusSaque = "Saldo insuficiente!";
                return false;
            }
                        
        }
        public void setSaldo(string login, string passwd)
        {
            dbGetClienteID dbGetClienteID = new dbGetClienteID(login, passwd);
            getContaSaldo getContaSaldo = new getContaSaldo(dbGetClienteID.id);
            this.saldo = getContaSaldo.saldo;
        }
        public double getSaldo()
            { return this.saldo; }
                

        

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

using System;

namespace DIO.Bank
{
    public class Conta
    {
        public Conta(TipoConta tipoConta, double saldo, double credito, string nome) 
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
               
        }
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }  
        private double Credito { get; set; }  
        private string Nome { get; set; }

        public bool Sacar(double ValorSaque)
        {
            if (Saldo - ValorSaque < (Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente!");

                return false;
            }

            Saldo -= ValorSaque;

            Console.WriteLine("Saldo Atual da conta de {0} é {1}", Nome, Saldo); 

            return true; 
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito; 

            Console.WriteLine("Saldo Atual da conta de {0} é {1}", Nome, Saldo); 
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if(Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia); 
            }
        }

        public override string ToString()
        {
            string retorno = ""; 
            retorno += "TipoConta:" + TipoConta + "|";
            retorno += "Nome:" + Nome + "|"; 
            retorno += "Saldo:" + Saldo + "|"; 
            retorno += "Crédito:" + Credito; 

            return retorno; 
        }
    }
}
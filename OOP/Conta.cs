using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Conta : IConta
    {

        public Conta(int numero, double limite) // Método construtor para instanciar a classe que sempre vai solicitar numero da conta e limite
        {
            this.Numero = numero;
            this.Limite = limite;
            Conta.TotalDeContasCriadas++; // Atributo estático da classe
        }

        //propiedades da classe
        protected double Saldo { get; set ; } //get pode ser acessado //set pode setar uma informação ao saldo
        public double Limite { get; private set; } 
        public double Numero { get; private set; } 
        public static int TotalDeContasCriadas { get; set; }

        public static int ProximoTotalContasCriadas()
        {
            return Conta.TotalDeContasCriadas + 1;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual bool Saca(double valor)
        {
            double saldoDisponivel = this.ConsultaSaldoDisponivel();

            if(valor > saldoDisponivel)
            {
                Console.WriteLine("Saque e Saldo indisponivel.");
                return false;
            }
            this.Saldo -= valor;
            return true;

        }
        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }
    }
}
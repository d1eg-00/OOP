using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace OOP
{
    public class ContaPoupanca : Conta , IConta
    {
        //Herdando
        public ContaPoupanca(int numero, double limite) : base(numero, limite)
        {
        
        }

        public void MostrarNumerodaConta()
        {
            Console.WriteLine($@"A Conta Poupança: {this.Numero}");
        }

        public override bool Saca(double valor) //sobrescrita do método saca reutilizando o metodo saca, que vai tirar 6 reais a cada saque realizado da conta
        {
            bool deuCertoSaque = base.Saca(valor);
            if(deuCertoSaque)
            {
                this.Saldo -= 6 ;
            }
            return false;
        }

    }
}
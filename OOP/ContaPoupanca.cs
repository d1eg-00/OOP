using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class ContaPoupanca : Conta
    {
        //Herdando
        public ContaPoupanca(int numero, double limite) : base(numero, limite)
        {
        
        }

        public void MostrarNumerodaConta()
        {
            Console.WriteLine($@"A Conta Poupança: {this.Numero}");
        }

    }
}
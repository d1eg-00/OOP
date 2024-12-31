using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Gerente : Funcionario
    {
        public override void Reajustar() //override vai sobrepor o codigo abstrato
        {
            this.Salario += 1000;
        }
    }
}
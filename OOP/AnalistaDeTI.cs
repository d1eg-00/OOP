using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class AnalistaDeTI : Funcionario
    {
        public override void Reajustar()
        {
            this.Salario += 700;
        }
    }
}
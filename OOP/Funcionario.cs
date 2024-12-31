using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Funcionario
    {
        public string? Nome { get; set; }
        public double? Salario { get; set; }

        public abstract void Reajustar();
        
        
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Funcionario
    {
        private string? Nome { get; set; }
        public double? Salario { get; protected set; }

        public abstract void Reajustar();
        

        //Encapsulando o acesso e atributos da classe

        public void AdicionarNome (string primeiroNome, string sobreNome)
        {
            string nomeCompleto = primeiroNome + " " + sobreNome;
            this.Nome = nomeCompleto;
        }

        public void AdicionarSalarioPadrao (double salario)
        {
            this.Salario = salario;
        }
        
    }

}

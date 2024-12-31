using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public interface IConta // Implementando uma interface obrigando a assinar os métodos implementados
    {
        void Deposita(double valor);
        bool Saca(double valor);
        void AdicionarLimite(double valor);
        double ConsultaSaldoDisponivel();
    }
}
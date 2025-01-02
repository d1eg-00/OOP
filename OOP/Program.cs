using System.ComponentModel.Design.Serialization;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando uma instancia da conta
            //Conta conta = new Conta(123, 300);

#region Instancia Comentada
            // //segunda instancia da conta
            // Conta conta2 = new Conta();

            // //adicionando valores a primeira conta
            // conta1.Saldo = 1500;
            // conta1.Limite = 500;
            // conta1.Numero = 123;

            // //adicionando valores a segunda conta
            // conta2.Saldo = 2000;
            // conta2.Limite = 600;
            // conta2.Numero = 456;

            // Console.WriteLine($@"Olá fulano. seu saldo em conta é {conta1.Saldo}");
            // Console.WriteLine($@"Limite de saque: {conta1.Limite}");
            // Console.WriteLine($@"O número da sua conta: {conta1.Numero}");

            // Console.WriteLine($@"=====================================");

            // Console.WriteLine($@"Olá fulano, seu saldo em conta é {conta2.Saldo}");
            // Console.WriteLine($@"Limite de saque: {conta2.Limite}");
            // Console.WriteLine($@"O número da sua conta: {conta2.Numero}");
#endregion


#region Aprendendo Classes
            // conta.AdicionarLimite(1500);
            // conta.Deposita(1500);
            // conta.Deposita(2500);
            // conta.Deposita(4500);

            // bool saca = conta.Saca(5000);

            // if(saca)
            // {
            //     double saldo = conta.ConsultaSaldoDisponivel();
            //     Console.WriteLine($@"Seu saldo: {saldo}");
            //     Console.WriteLine($@"Seu limite: {conta.Limite}");
            //     Console.WriteLine($@"O Número da conta: {conta.Numero}");
            // }
#endregion


#region Criando um objeto de casa Classe
            //Criando um objeto de casa Classe
            // CartaoDeCredito cdc = new CartaoDeCredito(); // objeto cartao de credito
            // Cliente c = new Cliente(); //pbjeto cliente

            // c.Nome = "Diego Fernandes"; // adicionando o nome do cliente
            // cdc.Numero = "5213645879545"; // add numero do cartão
            // cdc.DataDeValidade = "10/2028"; //add validade do cartão

            // cdc.Cliente = c;

            // Console.WriteLine($@"Cliente: {c.Nome}");
            // Console.WriteLine($@"Númeoro do Cartão: {cdc.Numero}");
            // Console.WriteLine($@"Data de Validade do Cartão: {cdc.DataDeValidade}");
            // Console.WriteLine($@"Cliente Agregado: {cdc.Cliente.Nome}");
#endregion


#region Métodos e Atributos Estáticos da Classe          
            // Conta conta1 = new Conta(123, 500);
            // Conta conta2 = new Conta(456, 800);
            // Conta conta3 = new Conta(789, 900);
            // Conta conta4 = new Conta(921, 1000);

            // Console.WriteLine($@"Total de Contas: {Conta.TotalDeContasCriadas}");

            // int TotalContas = Conta.ProximoTotalContasCriadas();

            // Console.WriteLine($@"Próximo Total de Contas: {TotalContas}");

#endregion

#region Herança
            // ContaPoupanca contaPoupanca = new ContaPoupanca(112, 0);
            // contaPoupanca.Deposita(100);
            // contaPoupanca.Saca(10);
            // contaPoupanca.MostrarNumerodaConta();

            // double saldo = contaPoupanca.ConsultaSaldoDisponivel();

            // Console.WriteLine($@"Saldo Conta Poupança: {saldo}");

            // Conta conta =  new Conta(113, 100);

            // conta.Deposita(500);
            // conta.Saca(140);

            // double saldoContaCorrente = conta.ConsultaSaldoDisponivel();

            // Console.WriteLine($@"Saldo Conta Corrente: {saldoContaCorrente}");
#endregion


#region Implementando Poliformismo

            // AnalistaDeTI analistaDeTI = new AnalistaDeTI();
            // Gerente gerente = new Gerente();
            // GerenteDeAgencia gerenteDeAgencia = new GerenteDeAgencia();
            // GerenteDeTI gerenteDeTI = new GerenteDeTI();

            // analistaDeTI.Nome = "Diego Fernandes";
            // analistaDeTI.Salario = 3000;

            // Console.WriteLine($@"O Salário do Analista de TI: {analistaDeTI.Salario}");
            // analistaDeTI.Reajustar();
            // Console.WriteLine($@"Salario do Analista de TI Reajustado: {analistaDeTI.Salario}");

            // Console.WriteLine("==============================");

            // gerente.Nome = "Rodrigo Reis";
            // gerente.Salario = 7000;

            // Console.WriteLine($@"O Salário do Gerente: {gerente.Salario}");
            // gerente.Reajustar();
            // Console.WriteLine($@"Salario do Gerente Reajustado: {gerente.Salario}");

            // Console.WriteLine("==============================");

            // gerenteDeAgencia.Nome = "Tania Chagas";
            // gerenteDeAgencia.Salario = 8000;

            // Console.WriteLine($@"O Salário do Gerente de Agencia: {gerenteDeAgencia.Salario}");
            // gerenteDeAgencia.Reajustar();
            // Console.WriteLine($@"Salario do Gerente Reajustado: {gerenteDeAgencia.Salario}");

            // Console.WriteLine("==============================");

            // gerenteDeTI.Nome = "Rafael Silva";
            // gerenteDeTI.Salario = 18000;

            // Console.WriteLine($@"O Salário do Gerente do Gerente de TI: {gerenteDeTI.Salario}");
            // gerenteDeTI.Reajustar();
            // Console.WriteLine($@"Salario do Gerente de TI Reajustado: {gerenteDeTI.Salario}");

#endregion

#region Interface


            // ContaPoupanca contaPoupanca = new ContaPoupanca(111, 0);
            // contaPoupanca.Deposita(100);
            // contaPoupanca.Saca(10);

            // double saldoPoupanca = contaPoupanca.ConsultaSaldoDisponivel();
            // Console.WriteLine($@"SALDO Conta Poupança: {saldoPoupanca}");

            // Console.WriteLine("======================");

            // ContaCorrente contaCorrente = new ContaCorrente(111, 0);
            // contaCorrente.Deposita(100);
            // contaCorrente.Saca(20);

            // double saldoContaCorrente = contaCorrente.ConsultaSaldoDisponivel();
            // Console.WriteLine($@"SALDO Conta Corrente: {saldoContaCorrente}");

#endregion

#region Encapsulamento

            AnalistaDeTI analistaDeTI = new AnalistaDeTI();
            analistaDeTI.AdicionarNome ("Diego", "Fernandes");
            analistaDeTI.AdicionarSalarioPadrao(5000);

            analistaDeTI.Reajustar();

            Console.WriteLine($@"Salário do Analista de TI Reajustado: {analistaDeTI.Salario}");

#endregion
            Console.ReadKey();
        }
    }
}

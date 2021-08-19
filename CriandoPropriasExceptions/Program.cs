using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CriandoPropriasExceptions;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           
           try
           {
               CarregarContas();
           }
           catch(Exception)
           {
               Console.WriteLine("CATH NO METODO MAIN");
           }

           Console.WriteLine("Execução finalizada. Tecle entrer para finalizar");
           Console.ReadLine();



            //try
            //{
                //ContaCorrente conta = new ContaCorrente(456, 4578420);
               // ContaCorrente conta2 = new ContaCorrente(485, 456478);
               // SaldoInsuficienteException teste = new SaldoInsuficienteException(58.8, 89.0);

                

                //Console.WriteLine(teste.Message);
                //Console.WriteLine(teste.ValorSaque);

                //conta2.Transferir(-10, conta);
                

                //conta.Depositar(50);
               // Console.WriteLine(conta.Saldo);
               //conta.Sacar(-500);
                //Console.WriteLine(conta.Saldo);
            //}
            //catch (ArgumentException ex)
            //{
                //if(ex.ParamName == "numero")
                //{
                    
                //}

                //Console.WriteLine("Argumento com problema: " + ex.ParamName);
                //Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                //Console.WriteLine(ex.Message);
            //}
            //catch(SaldoInsuficienteException ex)
            //{
                //Console.WriteLine(ex.Message);
                //Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            //}
            //catch (Exception ex)
            //{
                //Console.WriteLine(ex.Message);
            //}
            
            //Metodo();

            //Console.WriteLine("Execução finalizada. Tecle enter para sair");
            //Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }



        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }

    }
}

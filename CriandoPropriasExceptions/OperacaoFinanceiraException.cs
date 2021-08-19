using System;

namespace CriandoPropriasExceptions
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {

        }
         
        public OperacaoFinanceiraException(string mensagem)
            :base(mensagem)
           {

           }

        public OperacaoFinanceiraException(string mensagem, Exception excesaoInterna)
           : base(mensagem, excesaoInterna)
           {
               
           }

         
        
        
    }

     
}
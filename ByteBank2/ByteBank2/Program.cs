using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2
{
     public class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 0);
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "numero")
                {

                }

                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentExeption");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Metodo();
            
            Console.WriteLine("Execção finalizada. Tecle enter para sair");
            Console.ReadLine();
        }
        private static void Metodo()
        {
            TestaDivisao(0);
        }  
    }
}

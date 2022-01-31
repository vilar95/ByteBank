using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;


            Console.WriteLine("Titúlar: " + contaDaGabriela.titular);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Número Da Conta: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

          

            
            {
                ContaCorrente primeiraContaCorrente = new ContaCorrente();
                primeiraContaCorrente.saldo = 200;
                Console.WriteLine(primeiraContaCorrente.saldo);

                primeiraContaCorrente.saldo += 100;
                Console.WriteLine(primeiraContaCorrente.saldo);

                ContaCorrente segundaContaCorrente = new ContaCorrente();
                segundaContaCorrente.saldo = 50;

                Console.WriteLine("primeira conta tem " + primeiraContaCorrente.saldo);
                Console.WriteLine("segunda conta tem " + segundaContaCorrente.saldo);
                
                Console.ReadLine();
            }
        }


    }
    }


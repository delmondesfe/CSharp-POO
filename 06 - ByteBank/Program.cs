using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _06___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Felipe Delmondes";
            cliente.CPF = "45401384807";
            cliente.Profissao = "Analista de sistemas";

            conta.Titular = cliente;
            conta.Saldo = -50;
            
            
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoFelipe = new ContaCorrente();

            contaDoFelipe.titular = "Felipe Delmondes";
            contaDoFelipe.agencia = 863;
            contaDoFelipe.numero = 863452;
            contaDoFelipe.saldo = 100;

            Console.WriteLine("Titualar da Conta: "+ contaDoFelipe.titular);
            Console.WriteLine("Agência: "+ contaDoFelipe.agencia);
            Console.WriteLine("C/C: "+ contaDoFelipe.numero);
            Console.WriteLine("Saldo em conta: "+ contaDoFelipe.saldo);
            

            Console.ReadLine();

        }
    }
}

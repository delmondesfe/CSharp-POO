using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            contaDoBruno.Sacar(200);

            Console.WriteLine(contaDoBruno.saldo);
            Console.ReadLine();

        }
    }
}

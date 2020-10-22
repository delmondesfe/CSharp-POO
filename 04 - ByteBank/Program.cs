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

            //contaDoBruno.Sacar(200);

            contaDoBruno.Depositar(500);

            Console.WriteLine("Saldo atual Bruno: "+ contaDoBruno.saldo);


            ContaCorrente contaDaBia = new ContaCorrente();
            contaDaBia.titular = "Beatriz";

            contaDoBruno.Transferir(100,contaDaBia);

            Console.WriteLine("Saldo conta da bia: "+ contaDaBia.saldo);
            Console.WriteLine("Saldo conta do Bruno: "+ contaDoBruno.saldo);

            Console.ReadLine();

        }
    }
}

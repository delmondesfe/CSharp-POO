using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 8672320);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDoFelipe = new ContaCorrente(862, 8223213);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            contaDoBruno.agencia = 863;
            contaDoBruno.numero = 863452;


            ContaCorrente contaDoFelipe = new ContaCorrente();

            contaDoFelipe.titular = "Felipe";
            contaDoFelipe.agencia = 863;
            contaDoFelipe.numero = 863452;
        }
    }
}

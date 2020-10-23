using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente felipe = new Cliente();
            //felipe.nome = "Felipe Delmondes";
            //felipe.cpf = "45401384807";
            //felipe.profissao = "Analista de sistemas";

            ContaCorrente contaDoFelipe = new ContaCorrente();
            contaDoFelipe.titular = felipe;
            contaDoFelipe.titular.nome = "Felipe Cicero Delmondes";
            contaDoFelipe.titular.profissao = "Analista de sistemas";
            contaDoFelipe.titular.cpf = "45401384807";
            contaDoFelipe.saldo = 500;
            contaDoFelipe.agencia = 563;
            contaDoFelipe.numero = 5634527;

            Console.WriteLine(contaDoFelipe.titular.nome);
            Console.WriteLine(felipe.nome);
            Console.WriteLine(felipe.profissao);

            Console.ReadLine();

        }
    }
}

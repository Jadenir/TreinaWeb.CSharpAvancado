using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o que você quer inverter: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Sua nova frase é {0}", frase.InverterCaixas());
            Console.ReadKey();
        }
    }
}

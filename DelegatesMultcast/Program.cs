using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesMultcast
{
    class Program
    {
        delegate void VerificacaoIdade(int idade);
        static VerificacaoIdade verificadorIdade;

        static void Main(string[] args)
        {
            //Usuario informa se ele é homem ou mulher
            //usuario também informa a idade

            //Se for homem:
            //Se tiver menos que 21 anos: "Você ainda está crescendo"
            //se tiver mais que 21 anos: "Você já cresceu"
            //Se tiver mais que 25 anos: "Você pode carregar bastente peso"
            //Se tiver menor que 25 anos: "Você não pode carregar tanto peso"

            //Se for mulher:
            //Se tiver menos que 18 anos: "Você ainda está crescendo"
            //se tiver mais que 18 anos: "Você já cresceu"
            //Se tiver mais que 30 anos: "Você pode carregar bastente peso"
            //Se tiver menor que 30 anos: "Você não pode carregar tanto peso"

            Console.WriteLine("Digite seu sexo: ");
            string sexoUsuario = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idadeUsuario = Convert.ToInt32(Console.ReadLine());
            if (sexoUsuario.Equals("H"))
            {
                verificadorIdade = new VerificacaoIdade(VerificaIdadeHomem);
                verificadorIdade += VerificaCarregamentoPesoHomem;
            }
            else
            {
                verificadorIdade = new VerificacaoIdade(VerificaIdadeMulher);
                verificadorIdade += VerificaCarregamentoPesoMulher;
            }
            verificadorIdade(idadeUsuario);
            Console.ReadKey();
        }

        //Homens
        static void VerificaIdadeHomem(int idade)
        {
            if (idade < 21)
            {
                Console.WriteLine("Você ainda está crescendo.");
            }
            else
            {
                Console.WriteLine("Você já cresceu.");
            }
        }
        static void VerificaCarregamentoPesoHomem(int idade)
        {
            if (idade > 25)
            {
                Console.WriteLine("Você pode carregar bastante peso.");
            }
            else
            {
                Console.WriteLine("Você não pode carregar tanto peso.");
            }
        }
        //Mulher
        static void VerificaIdadeMulher(int idade)
        {
            if (idade < 18)
            {
                Console.WriteLine("Você ainda está crescendo.");
            }
            else
            {
                Console.WriteLine("Você já cresceu.");
            }
        }
        static void VerificaCarregamentoPesoMulher(int idade)
        {
            if (idade > 03)
            {
                Console.WriteLine("Você pode carregar bastante peso.");
            }
            else
            {
                Console.WriteLine("Você não pode carregar tanto peso.");
            }
        }
    }
}

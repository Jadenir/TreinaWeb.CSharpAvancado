using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a fonte de dados
            List<Pessoa> pessoas = CarregarPessoas();
            //1 - Todas as pessoas com mais de 2 irmãos
            //Consult padrão LING
            /*IEnumerable<Pessoa> pessoasMaisDoisIrmaos = from pessoa in pessoas
                                                        where pessoa.QuantidadeIrmaos >= 2
                                                        select pessoa;*/
            //Consulta LINQ com expressão LAMBDA (Metodos de extensão)
            IEnumerable<Pessoa> pessoasMaisDoisIrmaos = pessoas
                .Where(p => p.QuantidadeIrmaos > 2);
            foreach (Pessoa p in pessoasMaisDoisIrmaos)
            {
                Console.WriteLine("{0}, {1}, {2}", p.Nome, p.Idade, p.QuantidadeIrmaos);
            }
            Console.WriteLine("#############################################");
            //2 - Nome e idade de todas as pessoas maiores de idade
            /*var pessoasMaioresIdade = from pessoa in pessoas
                                      where pessoa.Idade > 18
                                      orderby pessoa.Idade descending
                                      select new { pessoa.Nome, pessoa.Idade };
                                      */
            var pessoasMaioresIdade = pessoas
                .Where(pessoa => pessoa.Idade > 18)
                .OrderByDescending(pessoa => pessoa.Nome.Length)
                .ThenBy(pessoa => pessoa.Idade)
                .Select(pessoa => new { pessoa.Nome, pessoa.Idade });
            foreach (var pessoa in pessoasMaioresIdade)
            {
                Console.WriteLine("{0}, {1}", pessoa.Nome, pessoa.Idade);
            }


            Console.ReadKey();
        }
        static List<Pessoa> CarregarPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa
            {
                Nome = "João",
                Idade = 18,
                QuantidadeIrmaos = 2
            });
            pessoas.Add(new Pessoa
            {
                Nome = "Maria",
                Idade = 30,
                QuantidadeIrmaos = 0
            });
            pessoas.Add(new Pessoa
            {
                Nome = "José",
                Idade = 50,
                QuantidadeIrmaos = 6
            });
            return pessoas;
        }
    }
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int QuantidadeIrmaos { get; set; }
    }
}

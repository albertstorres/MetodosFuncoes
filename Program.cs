using System;

namespace MetodosFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuPrimeiroMetodo("C# é legal!");
            string meuSegundoMetodo = MeuSegundoMetodo("Com o tipo, return funciona.");
            string nomeCompleto = RetornaNome("Anthony", "Sevy");
            string nomeIdadeOpicional = MetodoComParametroOpicional("Albert", "Sevy", 35);

            Console.WriteLine(meuSegundoMetodo);
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(nomeIdadeOpicional);
        }

        static void MeuPrimeiroMetodo(string parametro)
        {
            Console.WriteLine(parametro);
        }

        static string MeuSegundoMetodo(string parametro)
        {
            return parametro;
        }

        static string RetornaNome(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }

        static string MetodoComParametroOpicional(string nome, string sobrenome, int idade = 34)//DEFINIR UM VALOR PARA IDADE TORNA ELE OPCIONAL. CASO O USUÁRIO PASSE OUTRO VALOR, SERÁ ATRIBUÍDO.
        {
            return nome + " " + sobrenome + " " + "tem" + " " + idade.ToString() + " anos.";
        }
    }
}

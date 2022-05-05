using System;

namespace ano_bisexto
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            

            Console.WriteLine("Digite o ano: ");
            ano = Convert.ToInt32(Console.ReadLine());

            if (ano % 4 == 0)
            {
                Console.WriteLine($"{ano} é um ano bissexto");
            }
            else if (ano % 100 != 0)
            {
                Console.WriteLine($"{ano} não é bissexto");
            }
            else if (ano % 400 == 0)
            {
                Console.WriteLine($"{ano} é um ano bissexto");
            }

        }
    }
}

using System;

namespace Ano_bissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 0;
            Console.WriteLine("Digite o Ano:");
            ano = Int32.Parse(Console.ReadLine());

            if (((ano%4==0) && (ano%100 != 0)) || (ano%400==0))
            {
                Console.WriteLine(" Este ano "+ ano +" é bissexto !!!!" );
            }
            else
            {
                Console.WriteLine("Este ano "+ ano + " não é bissexto");
            }
        }
    }
}

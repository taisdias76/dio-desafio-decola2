using System;

namespace Introdução_ao_Git_e_ao_GitHub
{
    class ParImpar
    {
        static void Main(string[] args)
        {
            //Programa que identifica se um número informado é par ou ímpar

            //declarando as variaveis
            int a = 0;

            //entrada de dados
            Console.WriteLine("Informe um número: ");
            a = Convert.ToInt32(Console.ReadLine());

            //condicional
            if (a % 2 == 0)
            {
                Console.WriteLine("O número informado é par.");
            }
            else
            {
                Console.WriteLine("O número informado é ímpar.");
            }

            Console.ReadKey();
        }

    }

}    
using System;

namespace Introdução_ao_Git_e_ao_GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            //algoritmo que calcula a idade média de 3 alunos
            double media = 0;
            double idade1 = 0;
            double idade2 = 0;
            double idade3 = 0;

            Console.WriteLine("Informe a idade do 1º aluno: ");
            idade1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a idade do 2º aluno: ");
            idade2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a idade do 3º aluno: ");
            idade3 = Convert.ToDouble(Console.ReadLine());

            media = (idade1 + idade2 + idade3)/3;
            Console.WriteLine("A idade média dos três alunos é "+media);
            Console.ReadKey();
        }
    }
}

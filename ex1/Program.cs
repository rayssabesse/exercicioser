using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gradeb = false;

            while (gradeb == false) 
            {
                Console.WriteLine("Digite uma nota entre 0 e 10: ");
                int grade = int.Parse(Console.ReadLine());
                if (grade == 2)
                {
                    gradeb = true;
                }
                else
                {
                    Console.WriteLine("Valor Inválido");
                }
            }
            Console.WriteLine("Fim da Execução");
        }
    }
}

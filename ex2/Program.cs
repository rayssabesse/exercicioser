using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = false;

            while (a == false)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Digite seu nome: ");
                Console.ForegroundColor = ConsoleColor.White;
                string name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Digite sua senha: ");
                Console.ForegroundColor = ConsoleColor.White;
                string password = Console.ReadLine();

                if (name == password)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sua senha e seu nome não podem ser o mesmo.");
                    Console.WriteLine("Tente novamente.");
                }
                else
                {
                    a = true;
                }
            }

        }
    }
}


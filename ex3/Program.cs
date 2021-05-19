using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = false;
            bool b = true;
            bool c = true;
            bool d = true;
            bool e = false;
            string name = "";
            int age = 0;
            int salary = 0;
            string ms = "";

            while (e == false)
            {
                while (a == false)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Digite seu nome: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    name = Console.ReadLine();

                    if (name != "")
                    {
                        a = true;
                        b = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Resposta Inválida. Tente Novamente.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (b == false)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Digite sua idade: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    age = int.Parse(Console.ReadLine());

                    if (age > 0 && age <= 150)
                    {
                        b = true;
                        c = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Resposta Inválida. Tente Novamente.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (c == false)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Digite seu salário: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    salary = int.Parse(Console.ReadLine());

                    if (salary > 0)
                    {
                        c = true;
                        d = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Resposta Inválida. Tente Novamente.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (d == false)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(
                        "Digite seu estado civil: \n" +
                        "'s'(solteiro(a))\n" +
                        "'c'(casado(a))\n" +
                        "'v'(viuvo(a))\n" +
                        "'d'(divorciado(a))"
                        );
                    Console.ForegroundColor = ConsoleColor.White;
                    ms = Console.ReadLine();

                    if (ms == "s" || ms == "c" || ms == "v" || ms == "d")
                    {
                        d = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Resposta Inválida. Tente Novamente.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                if (a == true && b == true && c == true && d == true)
                {
                    Console.WriteLine("\nNome: " + name);
                    Console.WriteLine("Idade: " + age);
                    Console.WriteLine("Salário : " + salary);
                    Console.WriteLine("Estado Civil: " + ms);
                    e = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não foi possível concluir a operação. Tente Novamente.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}

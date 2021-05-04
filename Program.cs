using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-_-_-_-_-_-_-_-_-_");
            Console.WriteLine("1: Calculadora");
            Console.WriteLine("2: Tabuada");
            Console.WriteLine("0: Sair");
            Console.WriteLine("-_-_-_-_-_-_-_-_-_");
            Console.Write("Escolha um: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Calculadora(); break;
                case 2: Tabuada(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Tabuada()
        {
            Console.Clear();
            Console.WriteLine("-_-_-_-_-_-_-_");
            Console.WriteLine("1: Tabuada do 1");
            Console.WriteLine("2: Tabuada do 2");
            Console.WriteLine("3: Tabuada do 3");
            Console.WriteLine("4: Outra");
            Console.WriteLine("5: Menu");
            Console.WriteLine("0: Sair");

            Console.WriteLine("-_-_-_-_-_-_-_");
            Console.Write("Escolha uma tabuada: ");
            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Tab1(); break;
                case 2: Tab2(); break;
                case 3: Tab3(); break;
                case 4: Outra(); break;
                case 5: Menu(); break;
                case 0: System.Environment.Exit(0); break;
            }

            static void Tab1()
            {
                Console.Clear();
                int con = 0;
                while (con <= 10)
                {
                    Console.WriteLine($"1x{con} = {1 * con}");
                    con++;
                }
                Console.ReadKey();
                Menu();
            }

            static void Tab2()
            {
                Console.Clear();
                int con = 0;
                while (con <= 10)
                {
                    Console.WriteLine($"2x{con} = {2 * con}");
                    con++;
                }
                Console.ReadKey();
                Menu();
            }

            static void Tab3()
            {
                Console.Clear();
                int con = 0;
                while (con <= 10)
                {
                    Console.WriteLine($"3x{con} = {3 * con}");
                    con++;
                }
                Console.ReadKey();
                Menu();
            }

            static void Outra()
            {
                Console.Clear();
                int con = 0;
                Console.Write("Escolha o número da tabuada: ");
                int tab = int.Parse(Console.ReadLine());
                while (con <= 10)
                {
                    Console.WriteLine($"{tab}x{con} = {tab * con}");
                    con++;
                }
                Console.ReadKey();
                Menu();
            }
        }

        static void Calculadora()
        {
            Console.Clear();
            Console.WriteLine("-_-_-_-_-_-_-_-_-_");
            Console.WriteLine("1: Soma");
            Console.WriteLine("2: Subtração");
            Console.WriteLine("3: Multiplicação");
            Console.WriteLine("4: Divisão");
            Console.WriteLine("5: Menu");
            Console.WriteLine("0: Sair");
            Console.WriteLine("-_-_-_-_-_-_-_-_-_");
            Console.Write("Escolha uma operação: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Sum(); break;
                case 2: Sub(); break;
                case 3: Mult(); break;
                case 4: Div(); break;
                case 5: Menu(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

            static void Sum()
            {
                Console.Clear();

                Console.WriteLine("Primeiro: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Resultado: " + (v1 + v2));
                Console.ReadKey();
                Menu();
            }

            static void Sub()
            {
                Console.Clear();
                Console.WriteLine("Primeiro: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Resultado: " + (v1 - v2));
                Console.ReadKey();
                Menu();
            }

            static void Mult()
            {
                Console.Clear();
                Console.Write("Valor 1: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.Write("Valor 2: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine($"Resultado: {v1 * v2}");
                Console.ReadKey();
                Menu();
            }

            static void Div()
            {
                Console.Clear();

                Console.Write("Primeiro: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.Write("Segundo: ");
                float v2 = float.Parse(Console.ReadLine());

                if (v2 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Não é possível dividir por zero\n");
                    Console.WriteLine("Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    Div();
                }

                Console.WriteLine($"Resultado: " + (v1 / v2));
                Console.ReadKey();
                Menu();
            }

        }

    }
}

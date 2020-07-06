using System;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminar = false;
            int primeiro, segundo;
            while (!terminar)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Insira os dois números que você deseja ver o MDC.");
                Console.Write("Primeiro número: ");
                bool primeirobool = Int32.TryParse(Console.ReadLine(), out primeiro);
                Console.Write("Segundo número: ");
                bool segundobool = Int32.TryParse(Console.ReadLine(), out segundo);


                if (!primeirobool || !segundobool)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                    Console.ReadKey();
                }
                else
                {
                    int resto = primeiro % segundo;
                    int primeironovo = primeiro;
                    int segundonovo = segundo;
                    int restonovo = resto;
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (primeirobool && segundobool && resto == 0)
                    {
                        Console.WriteLine($"O MDC de {primeiro} e {segundo} = {segundo}");
                        Console.ResetColor();
                        Console.WriteLine("Pressione uma tecla para finalizar o programa.");
                        Console.ReadKey();
                        terminar = true;
                    }
                    if (primeirobool && segundobool && resto != 0)
                    {
                        while (restonovo != 0)
                        {
                            primeironovo = segundonovo;
                            segundonovo = restonovo;
                            restonovo = primeironovo % segundonovo;
                        }
                        Console.WriteLine($"O MDC de {primeiro} e {segundo} = {segundonovo}");
                        Console.ResetColor();
                        Console.WriteLine("Pressione uma tecla para finalizar o programa.");
                        Console.ReadKey();
                        terminar = true;
                    }
                }
            }
        }
    }
}

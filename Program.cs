using System;

namespace SeqPares
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int num;
                int i = 0;


                Console.WriteLine("▄▄▄▄▄                            ▄▄▄▄▄ ");
                Console.WriteLine("▄▄▄▄▄ SEQUÊNCIA DE NÚMEROS PARES ▄▄▄▄▄");
                Console.WriteLine("▄▄▄▄▄                            ▄▄▄▄▄ \n");

                Console.Write("Digite um numero: ");
                num = Convert.ToInt32(Console.ReadLine());



                while (i <= num)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }

                    i++;
                }



            }
            catch (FormatException)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Formato inválido...");
                Console.ResetColor();
            }
            catch (OverflowException)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Limite de numeração excedida!");
                Console.ResetColor();
            }
        }
    }

}

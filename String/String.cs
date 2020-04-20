using System;

namespace ConsoleApp5
{
    class String
    {
        static void Main(string[] args)
        {
            string s = "Четные числа в строке";
            Console.WriteLine("Нечетные символы в строке:");
            for (int i = 1; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    char a = s[i];
                    Console.Write(a);
                }
            }
            Console.ReadKey();
        }
    }
}

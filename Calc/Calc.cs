using System;

namespace _1
{
    class Calc
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double first, second;
                string action;

                Console.WriteLine("Калькулятор для операций над двумя числами");
                Console.WriteLine("_________________________________________");

                //ОБРАБОТКА ИСКЛЮЧЕНИЙ
                try
                {
                    //ВВОД ПЕРВОГО ЧИСЛА
                    Console.WriteLine("Введите первое число");
                    first = Double.Parse(Console.ReadLine());

                    //ВВОД ВТОРОГО ЧИСЛА            
                    Console.WriteLine("\nВведите второе число");
                    second = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nНекорректно введенные данные");
                    Console.ReadKey();
                    continue;
                }

                //ВВОД ОПЕРАЦИИ          
                Console.WriteLine("\nВыберите операцию: '+', '-' ,'/', '*'");
                action = (Console.ReadLine());

                //ВВОД И ОБРАБОТКА ОПЕРАЦИЙ
                switch (action)
                {
                    case "+":
                        Console.WriteLine("________________________________________");
                        Console.WriteLine("Сумма: {0} + {1} = " + (first + second), first, second);
                        break;
                    case "-":
                        Console.WriteLine("________________________________________");
                        Console.WriteLine("Вычитание: {0} - {1} = " + (first - second), first, second);
                        break;
                    case "/":
                        if (second == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                        }
                        else
                        {
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("Деление: {0} / {1} = " + (first / second), first, second);
                        }
                        break;
                    case "*":
                        Console.WriteLine("________________________________________");
                        Console.WriteLine("Умножение: {0} * {1} = " + (first * second), first, second);
                        break;
                    default:
                        Console.WriteLine("Ошибка! Выбрана некорректная операция. Повторите вввод");
                        break;
                }
                Console.ReadKey();
            }
        }
    }

}

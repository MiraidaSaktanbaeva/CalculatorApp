using System;

class Program
{
    static void Main()
    {
        double a = 0, b = 0;

        while (true)
        {
            Console.WriteLine("Операция: умножение");

            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Ввести A");
            Console.WriteLine("2. Ввести B");
            Console.WriteLine("5. *");

            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Введите A: ");
                a = Convert.ToDouble(Console.ReadLine());
            }
            else if (choice == "2")
            {
                Console.Write("Введите B: ");
                b = Convert.ToDouble(Console.ReadLine());
            }
            else if (choice == "5")
            {
                Console.WriteLine("Результат: " + (a * b));
            }
        }
    }
}
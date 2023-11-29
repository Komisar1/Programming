using System;

class Program
{
    static void Main()
    {
        int x, y;
        bool flg1, flg2;
        Console.WriteLine("Введите координату X: ");
        flg1 = int.TryParse(Console.ReadLine(), out x);
        Console.WriteLine("Введите координату Y: ");
        flg2 = int.TryParse(Console.ReadLine(), out y);

        if (flg1 && flg2)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка находится в первом квадранте");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится во втором квадранте");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в третьем квадранте");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка находится в четвертом квадранте");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Точка лежит на оси Y");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Точка лежит на оси X");
            }
            else
            {
                Console.WriteLine("Точка находится в начале координат");
            }
        }
        else
            Console.WriteLine("Введены некорректные данные");

    }
}
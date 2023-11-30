using System;

class MainClass
{
    public static void Main(string[] args)
    {
        char vvod;
        bool flg;
        Console.Write("Введите латинский символ, обозначающий ось: ");
        flg = char.TryParse(Console.ReadLine(), out vvod);
        string axisName = "";

        if (Char.IsLetter(vvod)) // проверка на то, что введённое значение является буквой
        {
            switch (vvod)
            {
                case 'x':
                    Console.WriteLine("Латинский символ x соответствует оси абсцисс в терминах математики");

                    break;
                case 'y':
                    Console.WriteLine("Латинский символ y соответствует оси ординат в терминах математики");
                    break;
                case 'z':
                    Console.WriteLine("Латинский символ z соответствует оси аппликат в терминах математики");
                    break;
                default:
                    Console.WriteLine("Оси, закодированной таким латинским символом - не существует");
                    break;

            }
        }
        else
        {
            Console.WriteLine("Введены некорректные данные");
        }
        Console.ReadKey(true);
    }
}
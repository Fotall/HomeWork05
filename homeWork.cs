public static class HomeWork05
{
    public static void ex01()
    {
        // принимает на вход трёхзначное число 
        // и на выходе показывает вторую цифру этого числа
        System.Console.WriteLine(Console.ReadLine()![1]);
    }
    public static void ex02()
    {
        //выводит третью цифру заданного числа или сообщает,
        // что третьей цифры нет.
        int a = 640;
        if (a < 100)
        {
            Console.WriteLine("Нет третей цифры");
        }
        else
        {
            String b = a.ToString();
            System.Console.WriteLine(b[2]);
        }
    }
    public static void ex03()
    {
        //принимает на вход цифру,
        // обозначающую день недели, и проверяет, 
        //является ли этот день выходным.
        int day = 8;
        if (day < 5)
        {
            Console.WriteLine("Рабочий");
        }
        else
        {
            if (day < 8)
            {
                Console.WriteLine("Выходной");
            }
            else
            {
                Console.WriteLine("Такого дня нет");
            }
        }

    }
}
﻿try
{
    Console.WriteLine("Введите число");
    int x = Convert.ToInt32(Console.ReadLine());

    if (x > 7) Console.WriteLine("Привет");
}

catch
{
    Console.WriteLine("Вы ввели неверные данные");
}
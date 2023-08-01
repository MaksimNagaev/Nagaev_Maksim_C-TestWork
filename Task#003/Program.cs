try
{
Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] newarray = new int[N];
Randomize(newarray);
Console.WriteLine("Сгенерированный массив:");
Printarray(newarray);
FindMult3(newarray);
}
catch
{
    Console.WriteLine("Вы ввели неверные данные");
}


void Randomize(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
void Printarray(int[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}
void FindMult3(int[] array2)
{
    Console.WriteLine("Значения кратные 3 в данном массиве:");
    int count = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if ((array2[i] % 3) == 0) {Console.Write($"{array2[i]} ");count++;}
    }
    if (count == 0) Console.WriteLine("Указанные значения не найдены");
}
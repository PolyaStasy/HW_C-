// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Count(int[] arrayCount)
{
    int res = 0;
    for (int i = 0; i < arrayCount.Length; i++)
    {
        if(arrayCount[i] > 0) res = res + 1;
    }
    return res;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

// --------------
Console.WriteLine("Введите стороны: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Положительных чисел: " + Count(array));